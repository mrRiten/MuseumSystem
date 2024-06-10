using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IMuseumService
    {
        public Task<Museum> GetAsync(string slug);
        public Task<ICollection<Museum>> GetAllAsync();
    }
}
