using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Services
{
    public class EmailDataService(IEmailDataRepository emailDataRepository) : IEmailDataService
    {
        private readonly IEmailDataRepository _emailDataRepository = emailDataRepository;

        public async Task CreateAsync(EmailData emailData)
        {
            await _emailDataRepository.CreateAsync(emailData);
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _emailDataRepository.GetAsync(id);

            await _emailDataRepository.DeleteAsync(item);
        }

        public async Task<ICollection<EmailData>> GetAllAsync()
        {
            return await _emailDataRepository.GetAllAsync();
        }
    }
}
