using GameLib.Core;
using GameLib.Core.Entities;
using GameLib.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLib.Repository.Repositories
{
    public class PlatformRepository: IRepository<Platform>
    {
        private readonly AppDbContext _context;
        public PlatformRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Platform entity)
        {
            await _context.Platforms.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Platform entity)
        {
            _context.Platforms.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
            return await _context.Platforms.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Platform>> GetAllAsync()
        {
            return await _context.Platforms.ToListAsync();
        }

        public async Task<Platform> GetByIdAsync(Guid id)
        {
            return await _context.Platforms.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateAsync(Platform entity)
        {
            _context.Platforms.Update(entity);
            return _context.SaveChangesAsync();
        }
    }
}
