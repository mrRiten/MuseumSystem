using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;
using System.Data;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class ClientRepository(MuseumSystemDbContext context) : IClientRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(Client client)
        {
            await _context.Clients.AddAsync(client);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Client client)
        {
            _context.Clients.Remove(client);

            await _context.SaveChangesAsync();
        }

        public async Task<Client> GetAsync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<Client> GetAsync(string fullName)
        {
            return await _context.Clients.FirstOrDefaultAsync(
                c => c.FirstName + c.LastName + c.MiddleName == fullName);
        }

        public Client? GetByEmail(string email)
        {
            return _context.Clients.FirstOrDefault(c => c.Email == email);
        }

        public async Task<ICollection<Client>> GetByRecord(int recordId)
        {
            var records = await _context.RecordClients.Where(r => r.RecordId == recordId).ToListAsync();

            // Fix: Finish this code
            throw new NotImplementedException();
        }

        public async Task<Client> GetLast()
        {
            return await _context.Clients
                .OrderByDescending(c => c.IdClient)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            _context.Clients.Update(client);

            await _context.SaveChangesAsync();
        }
    }
}
