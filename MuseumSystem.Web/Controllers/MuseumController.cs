using Microsoft.AspNetCore.Mvc;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.ModelsDTO;

namespace MuseumSystem.Web.Controllers
{
    public class MuseumController(IMuseumService museumService, IEventService eventService) : Controller
    {
        private readonly IMuseumService _museumService = museumService;
        private readonly IEventService _eventService = eventService;

        [HttpGet("museums/{museumSlug}")]
        public async Task<IActionResult> Museum(string museumSlug)
        {
            var museum = await _museumService.GetAsync(museumSlug);
            var events = await _eventService.GetEventByMuseum(museum.IdMuseum);

            var museumDTO = new MuseumDTO
            {
                Museum = museum,
                Events = events,
            };

            return View(museumDTO);
        }
    }
}
