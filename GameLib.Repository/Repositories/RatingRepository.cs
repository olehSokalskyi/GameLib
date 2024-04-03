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
    public class RatingRepository : IRepository<Rating>
    {
        private readonly AppDbContext _context;
        public RatingRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Rating entity)
        {
            await _context.Ratings.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Rating entity)
        {
            _context.Ratings.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
            return await _context.Ratings.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Rating>> GetAllAsync()
        {
            return await _context.Ratings.ToListAsync();
        }

        public async Task<Rating> GetByIdAsync(Guid id)
        {
            return await _context.Ratings.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Rating entity)
        {
            _context.Ratings.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
