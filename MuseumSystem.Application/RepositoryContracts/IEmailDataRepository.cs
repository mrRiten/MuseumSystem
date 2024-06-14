using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IEmailDataRepository
    {
        public Task<ICollection<EmailData>> GetAllAsync();
        public Task<EmailData> GetAsync(int id);

        public Task DeleteAsync(EmailData emailData);
        public Task CreateAsync(EmailData emailData);
    }
}
