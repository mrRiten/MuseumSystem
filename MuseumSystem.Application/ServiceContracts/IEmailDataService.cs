using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IEmailDataService
    {
        public Task CreateAsync(EmailData emailData);
        public Task<ICollection<EmailData>> GetAllAsync();
        public Task DeleteAsync(int id);
    }
}
