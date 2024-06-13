using Microsoft.AspNetCore.Mvc;

namespace MuseumSystem.Web.Controllers
{
    public class AdminController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
