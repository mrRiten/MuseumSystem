using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IImageEventRepository
    {
        public Task<ImageEvent> GetFirstByEventAsync(int eventId);
        public Task<ICollection<ImageEvent>> GetAllByEventAsync(int eventId);

        public Task CreateAsync(ImageEvent imageEvent);
        public Task UpdateAsync(ImageEvent imageEvent);
        public Task DeleteAsync(ImageEvent imageEvent);
    }
}
