using Microsoft.AspNetCore.Mvc;

namespace MuseumSystem.Web.Controllers
{
    public class AuthorizeController : Controller
    {
        public async Task<IActionResult> Login()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {

            return RedirectToAction("Login", "Authorize");
        }
    }
}
