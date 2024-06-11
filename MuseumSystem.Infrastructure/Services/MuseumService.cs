using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Services
{
    public class MuseumService(IMuseumRepository museumRepository) : IMuseumService
    {
        private readonly IMuseumRepository _museumRepository = museumRepository;

        public async Task<ICollection<Museum>> GetAllAsync()
        {
            return await _museumRepository.GetAllAsync();
        }

        public async Task<Museum> GetAsync(string slug)
        {
            return await _museumRepository.GetAsync(slug);
        }

        public async Task<Museum> GetAsync(int id)
        {
            return await _museumRepository.GetAsync(id);
        }
    }
}
