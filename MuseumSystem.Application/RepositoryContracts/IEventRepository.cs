using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IEventRepository
    {
        public Task<Event> GetAsync(int id);
        public Task<Event> GetAsync(string slug);
        public Task<ICollection<Event>> GetByMuseumAsync(int museumId);
    
        public Task CreateAsync(Event eventItem);
        public Task UpdateAsync(Event eventItem);
        public Task DeleteAsync(Event eventItem);
    }
}
