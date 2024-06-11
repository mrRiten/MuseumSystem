using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IMuseumRepository
    {
        public Task<Museum> GetAsync(int id);
        public Task<Museum> GetAsync(string slug);
        public Task<ICollection<Museum>> GetAllAsync();

        public Task CreateAsync(Museum museum);
        public Task UpdateAsync(Museum museum);
        public Task DeleteAsync(Museum museum);
    }
}
