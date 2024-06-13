using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class AdminRepository(MuseumSystemDbContext context) : IAdminRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(Admin admin)
        {
            await _context.Admins.AddAsync(admin);
            
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Admin admin)
        {
            _context.Remove(admin);

            await _context.SaveChangesAsync();
        }

        public async Task<Admin> GetAsync(string login)
        {
            return await _context.Admins
                .Include(a => a.Role)
                .Include(a => a.Museum)
                .FirstOrDefaultAsync(a => a.Login == login);
        }

        public async Task<Admin> GetAsync(int adminId)
        {
            return await _context.Admins
                .Include(a => a.Role)
                .Include(a => a.Museum)
                .FirstOrDefaultAsync(a => a.IdAdmin == adminId);
        }

        public async Task UpdateAsync(Admin admin)
        {
            _context.Update(admin);

            await _context.SaveChangesAsync();
        }
    }
}
