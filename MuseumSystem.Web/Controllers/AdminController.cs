using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.ModelsDTO;
using System.Security.Claims;

namespace MuseumSystem.Web.Controllers
{
    public class AdminController(IClientService clientService, IAdminService adminService, IEventService eventService) : Controller
    {
        private readonly IClientService _clientService = clientService;
        private readonly IAdminService _adminService = adminService;
        private readonly IEventService _eventService = eventService;

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var adminLogin = HttpContext.User.Identity.Name;
            var admin = await _adminService.GetAdminAsync(adminLogin);

            var clients = await _clientService.GetClients();
            foreach (var client in clients)
            {
                client.Records = await _eventService.GetRecordsByClient(client.IdClient);
            }

            var adminDTO = new AdminDTO
            {
                Clients = clients,
                Admin = admin,
            };

            return View(adminDTO);
        }
    }
}
