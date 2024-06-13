using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IEventService
    {
        public Task<ICollection<Record>> GetRecordsByClient(int clientId);
        public Task<Event> GetEventBySlug(string slug);
        public Task<ICollection<Event>> GetEventByMuseum(int museumId);
        public Task<ImageEvent> GetFirstImage(int eventId);
        public Task<ICollection<ImageEvent>> GetImages(int eventId);
    }
}
