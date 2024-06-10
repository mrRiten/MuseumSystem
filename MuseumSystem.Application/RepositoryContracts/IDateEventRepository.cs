using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IDateEventRepository
    {
        public Task<ICollection<DateEvent>> GetByReEventAsync(int eventId);
        
        public Task CreateAsync(DateEvent dateEvent);
        public Task UpdateAsync(DateEvent dateEvent);
        public Task DeleteAsync(DateEvent dateEvent);
    }
}
