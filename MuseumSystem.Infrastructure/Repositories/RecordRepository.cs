using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class RecordRepository(MuseumSystemDbContext context) : IRecordRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(Record record)
        {
            await _context.Records.AddAsync(record);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Record record)
        {
            _context.Remove(record);

            await _context.SaveChangesAsync();
        }

        public async Task<Record> GetAsync(int id)
        {
            return await _context.Records.FindAsync(id);
        }

        public async Task<ICollection<Record>> GetByEventAsync(int eventId)
        {
            return await _context.Records
                .Include(r => r.Event)
                .Where(r => r.EventId == eventId)
                .ToListAsync();
        }

        public async Task UpdateAsync(Record record)
        {
            _context.Records.Update(record);

            await _context.SaveChangesAsync();
        }
    }
}
