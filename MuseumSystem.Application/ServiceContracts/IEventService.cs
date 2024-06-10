using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IEventService
    {
        public Task<ICollection<Event>> GetEventByMuseum(int museumId);
    }
}
