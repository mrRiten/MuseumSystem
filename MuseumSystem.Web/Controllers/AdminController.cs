using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MuseumSystem.Application.ServiceContracts;

namespace MuseumSystem.Web.Controllers
{
    public class AdminController(IClientService clientService) : Controller
    {
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
