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
    public class RoleRepository: IRepository<Role>
    {
        private readonly AppDbContext _context;
        public RoleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Role entity)
        {
            await _context.Roles.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Role entity)
        {
            _context.Roles.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistItem(Guid id)
        {
            return await _context.Roles.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> GetByIdAsync(Guid id)
        {
            return await _context.Roles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Role entity)
        {
            _context.Roles.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
