using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.ModelsDTO;
using System.Security.Claims;

namespace MuseumSystem.Web.Controllers
{
    public class AdminController(IClientService clientService, IAdminService adminService) : Controller
    {
        private readonly IClientService _clientService = clientService;
        private readonly IAdminService _adminService = adminService;

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var adminLogin = HttpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).ToString();
            var admin = await _adminService.GetAdminAsync(adminLogin);

            var adminDTO = new AdminDTO
            {
                Clients = await _clientService.GetClients(),
                Admin = admin,
            };

            return View(adminDTO);
        }
    }
}
