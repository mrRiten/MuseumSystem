using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class ImageEventRepository(MuseumSystemDbContext context) : IImageEventRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(ImageEvent imageEvent)
        {
            await _context.AddAsync(imageEvent);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ImageEvent imageEvent)
        {
            _context.Remove(imageEvent);

            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<ImageEvent>> GetAllByEventAsync(int eventId)
        {
            return await _context.ImageEvents
                .Where(ie => ie.EventId == eventId)
                .ToListAsync();
        }

        public async Task<ImageEvent> GetFirstByEventAsync(int eventId)
        {
            return await _context.ImageEvents
                .Where(ie => ie.EventId == eventId)
                .OrderByDescending(ie => ie.EventId)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(ImageEvent imageEvent)
        {
            _context.Update(imageEvent);

            await _context.SaveChangesAsync();
        }
    }
}
