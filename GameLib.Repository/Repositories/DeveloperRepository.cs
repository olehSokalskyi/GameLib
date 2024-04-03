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
    public class DeveloperRepository: IRepository<Developer>
    {
        private readonly AppDbContext _context;
        public DeveloperRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Developer>> GetAllAsync()
        {
            return await _context.Developers.ToListAsync();
        }

        public async Task<Developer> GetByIdAsync(Guid id)
        {
            return await _context.Developers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Developer entity)
        {
            await _context.Developers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Developer entity)
        {
            _context.Developers.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Developer entity)
        {
            _context.Developers.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
            return await _context.Developers.AnyAsync(x => x.Id == id);
        }

    }
}
