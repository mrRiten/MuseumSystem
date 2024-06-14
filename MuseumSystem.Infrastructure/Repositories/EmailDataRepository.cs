using Microsoft.EntityFrameworkCore;
using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Core;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Repositories
{
    public class EmailDataRepository(MuseumSystemDbContext context) : IEmailDataRepository
    {
        private readonly MuseumSystemDbContext _context = context;

        public async Task CreateAsync(EmailData emailData)
        {
            await _context.EmailDatas.AddAsync(emailData);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(EmailData emailData)
        {
            _context.EmailDatas.Remove(emailData);

            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<EmailData>> GetAllAsync()
        {
            return await _context.EmailDatas
                .Include(ed => ed.Client)
                .Include(ed => ed.TargetEvent)
                .Include(ed => ed.TargetRecord)
                .ToListAsync();
        }

        public async Task<EmailData> GetAsync(int id)
        {
            return await _context.EmailDatas.FindAsync(id);
        }
    }
}
