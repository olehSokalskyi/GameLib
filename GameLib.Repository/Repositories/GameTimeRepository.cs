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
    public class GameTimeRepository : IRepository<GameTime>
    {
        private readonly AppDbContext _context;
        public GameTimeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(GameTime entity)
        {
            await _context.GameTimes.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(GameTime entity)
        {
           _context.GameTimes.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
            return await _context.GameTimes.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<GameTime>> GetAllAsync()
        {
            return await _context.GameTimes.ToListAsync();
        }

        public async Task<GameTime> GetByIdAsync(Guid id)
        {
           return await _context.GameTimes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(GameTime entity)
        {
            _context.GameTimes.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
