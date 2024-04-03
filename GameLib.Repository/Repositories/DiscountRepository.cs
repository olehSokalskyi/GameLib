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
    public class DiscountRepository: IRepository<Discount>
    {
        private readonly AppDbContext _context;
        public DiscountRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Discount>> GetAllAsync()
        {
            return await _context.Discounts.ToListAsync();
        }

        public async Task<Discount> GetByIdAsync(Guid id)
        {
            return await _context.Discounts.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Discount entity)
        {
            await _context.Discounts.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Discount entity)
        {
            _context.Discounts.Update(entity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Discount entity)
        {
            _context.Discounts.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
            return await _context.Discounts.AnyAsync(x => x.Id == id);
        }
    }
}
