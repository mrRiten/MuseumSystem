using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class RecordClientRepository(MuseumSystemDbContext context) : IRecordClientRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(RecordClient recordClient)
        {
            await _context.RecordClients.AddAsync(recordClient);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(RecordClient[] recordClients)
        {
            _context.RecordClients.RemoveRange(recordClients);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(RecordClient recordClient)
        {
            _context.RecordClients.Remove(recordClient);

            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Record>> GetByClientAsync(int clientId)
        {
            return await _context.RecordClients
                .Where(rc => rc.ClientId == clientId)
                .Include(rc => rc.Record)
                    .ThenInclude(r => r.Event)
                        .ThenInclude(e => e.Museum)
                .Where(rc => rc.Record.dateTime.Day >= DateTime.Today.Day)
                .Select(rc => rc.Record)
                .ToArrayAsync();
        }

        public async Task<ICollection<RecordClient>> GetByRecordAsync(int recordId)
        {
            return await _context.RecordClients.Where(rc => rc.RecordId == recordId).ToArrayAsync();
        }

        public async Task UpdateAsync(RecordClient recordClient)
        {
            _context.RecordClients.Update(recordClient);

            await _context.SaveChangesAsync();
        }

    }
}
