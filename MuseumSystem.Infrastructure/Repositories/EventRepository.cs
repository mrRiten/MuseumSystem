using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class EventRepository(MuseumSystemDbContext context) : IEventRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(Event eventItem)
        {
            await _context.Events.AddAsync(eventItem);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Event eventItem)
        {
            _context.Events.Remove(eventItem);
        
            await _context.SaveChangesAsync();
        }

        public async Task<Event> GetAsync(int id)
        {
            return await _context.Events
                .Include(e => e.Museum)
                .FirstOrDefaultAsync(e => e.IdEvent == id);
        }

        public async Task<Event> GetAsync(string slug)
        {
            return await _context.Events
                .Include(e => e.Museum)
                .FirstOrDefaultAsync(e => e.SlugEvent == slug);
        }

        public async Task<ICollection<Event>> GetByMuseumAsync(int museumId)
        {
            return await _context.Events
                .Include(e => e.Museum)
                .Where(e => e.MuseumId == museumId).ToListAsync();
        }

        public Event GetByRecord(int recordId)
        {
            return _context.Records
                .Include(r => r.Event)
                .FirstOrDefault(r => r.IdRecord == recordId).Event;
        }

        public async Task UpdateAsync(Event eventItem)
        {
            _context.Events.Update(eventItem);

            await _context.SaveChangesAsync();
        }
    }
}
