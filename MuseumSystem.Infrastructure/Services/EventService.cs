using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Services
{
    public class EventService(IEventRepository eventRepository, IRecordRepository recordRepository,
        IImageEventRepository imageEventRepository, IRecordClientRepository recordClientRepository) : IEventService
    {
        private readonly IEventRepository _eventRepository = eventRepository;
        private readonly IRecordRepository _recordRepository = recordRepository;
        private readonly IImageEventRepository _imageEventRepository = imageEventRepository;
        private readonly IRecordClientRepository _recordClientRepository = recordClientRepository;


        public async Task<ICollection<Event>> GetByMuseum(int museumId)
        {
            return await _eventRepository.GetByMuseumAsync(museumId);
        }

        public Event GetByRecord(int recordId)
        {
            return _eventRepository.GetByRecord(recordId);
        }

        public async Task<Event> GetBySlug(string slug)
        {
            var currentEvent = await _eventRepository.GetAsync(slug);
            currentEvent.Records = await _recordRepository.GetByEventAsync(currentEvent.IdEvent);

            return currentEvent;
        }

        public async Task<ImageEvent> GetFirstImage(int eventId)
        {
            return await _imageEventRepository.GetFirstByEventAsync(eventId);
        }

        public async Task<ICollection<ImageEvent>> GetImages(int eventId)
        {
            return await _imageEventRepository.GetAllByEventAsync(eventId);
        }

        public async Task<ICollection<Record>> GetRecordsByClient(int clientId)
        {
            return await _recordClientRepository.GetByClientAsync(clientId);
        }
    }
}
