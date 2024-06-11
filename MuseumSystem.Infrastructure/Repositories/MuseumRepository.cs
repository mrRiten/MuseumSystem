using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class MuseumRepository(MuseumSystemDbContext context) : IMuseumRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(Museum museum)
        {
            await _context.Museums.AddAsync(museum);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Museum museum)
        {
            _context.Museums.Remove(museum);

            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Museum>> GetAllAsync()
        {
            return await _context.Museums.ToListAsync();
        }

        public async Task<Museum> GetAsync(int id)
        {
            return await _context.Museums.FindAsync(id);
        }

        public async Task<Museum> GetAsync(string slug)
        {
            return await _context.Museums.FirstOrDefaultAsync(m => m.SlugMuseum == slug);
        }

        public async Task UpdateAsync(Museum museum)
        {
            _context.Museums.Update(museum);

            await _context.SaveChangesAsync();
        }
    }
}
