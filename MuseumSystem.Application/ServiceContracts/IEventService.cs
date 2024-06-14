using MuseumSystem.Core.Models;
using System.ComponentModel;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IEventService
    {
        public Task<ICollection<Record>> GetRecordsByClient(int clientId);
        public Task<Event> GetBySlug(string slug);
        public Task<ICollection<Event>> GetByMuseum(int museumId);
        public Event GetByRecord(int recordId);
        public Task<ImageEvent> GetFirstImage(int eventId);
        public Task<ICollection<ImageEvent>> GetImages(int eventId);
    }
}
