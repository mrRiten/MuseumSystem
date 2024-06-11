using Microsoft.AspNetCore.Mvc;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.ModelsDTO;

namespace MuseumSystem.Web.Controllers
{
    public class PostersController(IEventService eventService, IMuseumService museumService) : Controller
    {
        private readonly IEventService _eventService = eventService;
        private readonly IMuseumService _museumService = museumService;

        [HttpGet("posters/")]
        public async Task<IActionResult> AllPosters(string museumSlug)
        {
            var museum = await _museumService.GetAsync(museumSlug);
            var events = await _eventService.GetEventByMuseum(museum.IdMuseum);

            var postersDTO = new MuseumDTO
            {
                Museum = museum,
                Events = events
            };

            return View(postersDTO);
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


    }
}
