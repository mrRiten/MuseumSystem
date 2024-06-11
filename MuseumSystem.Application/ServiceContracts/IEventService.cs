using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IEventService
    {
        public Task<Event> GetEventBySlug(string slug);
        public Task<ICollection<Event>> GetEventByMuseum(int museumId);
    }
}
