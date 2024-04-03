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
    public class LanguageRepository : IRepository<Language>
    {
        private readonly AppDbContext _context;
        public LanguageRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Language entity)
        {
            await _context.Languages.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Language entity)
        {
            _context.Languages.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
           return await _context.Languages.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Language>> GetAllAsync()
        {
            return await _context.Languages.ToListAsync();
        }

        public async Task<Language> GetByIdAsync(Guid id)
        {
            return await _context.Languages.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Language entity)
        {
            _context.Languages.Update(entity);
            await _context.SaveChangesAsync();  
        }
    }
}
