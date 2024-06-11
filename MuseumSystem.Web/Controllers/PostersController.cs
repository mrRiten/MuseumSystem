using Microsoft.AspNetCore.Mvc;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;
using MuseumSystem.Core.ModelsDTO;

namespace MuseumSystem.Web.Controllers
{
    public class PostersController(IEventService eventService, IMuseumService museumService,
        IClientService clientService, IRecordService recordService) : Controller
    {
        private readonly IEventService _eventService = eventService;
        private readonly IMuseumService _museumService = museumService;
        private readonly IClientService _clientService = clientService;
        private readonly IRecordService _recordService = recordService;

        [HttpGet("posters")]
        public async Task<IActionResult> AllPosters(string slugMuseum)
        {
            var museum = await _museumService.GetAsync(slugMuseum);
            var events = await _eventService.GetEventByMuseum(museum.IdMuseum);

            var museumDTO = new MuseumDTO
            {
                Museum = museum,
                Events = events
            };

            return View(museumDTO);
        }

        [HttpGet("posters/{slugEvent}")]
        public async Task<IActionResult> Poster(string slugEvent)
        {
            var currentEvent = await _eventService.GetEventBySlug(slugEvent);
            var museum = await _museumService.GetAsync(currentEvent.MuseumId);

            var posterDTO = new PosterDTO
            {
                CurrentEvent = currentEvent,
                Museum = museum,
            };

            return View(posterDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Poster(PosterDTO posterDTO, string slugEvent)
        {
            if (ModelState.IsValid)
            {
                _clientService.CreateClientAsync(posterDTO.UploadRecord);
                var client = await _clientService.GetLastClient();

                var clientRecord = new RecordClient
                {
                    RecordId = posterDTO.UploadRecord.RecordId,
                    ClientId = client.IdClient,
                    RecordPrice = posterDTO.UploadRecord.Price,
                };

                await _recordService.CreateRecordClient(clientRecord);

                return Redirect($"posters/{slugEvent}");
            }
            
            return View(posterDTO);
        }


    }
}
