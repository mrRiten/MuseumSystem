using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Services
{
    public class EventService(IEventRepository eventRepository, IRecordRepository recordRepository) : IEventService
    {
        private readonly IEventRepository _eventRepository = eventRepository;
        private readonly IRecordRepository _recordRepository = recordRepository;

        public async Task<ICollection<Event>> GetEventByMuseum(int museumId)
        {
            return await _eventRepository.GetByMuseumAsync(museumId);
        }

        public async Task<Event> GetEventBySlug(string slug)
        {
            var currentEvent = await _eventRepository.GetAsync(slug);
            currentEvent.Records = await _recordRepository.GetByEventAsync(currentEvent.IdEvent);

            return currentEvent;
        }
    }
}
