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
    public class GenreRepository: IRepository<Genre>
    {
        private readonly AppDbContext _context;
        public GenreRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Genre>> GetAllAsync()
        {
            return await _context.Genres.ToListAsync();
        }

        public Task<Genre> GetByIdAsync(Guid id)
        {
            return _context.Genres.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task AddAsync(Genre entity)
        {
           await _context.Genres.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Genre entity)
        {
            _context.Genres.Update(entity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Genre entity)
        {
            _context.Genres.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
            return await _context.Genres.AnyAsync(x => x.Id == id);
        }


    }
}
