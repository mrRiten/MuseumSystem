using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.UploadModels;

namespace MuseumSystem.Web.Controllers
{
    public class AuthorizeController(IAuthorizeService authorizeService) : Controller
    {
        private readonly IAuthorizeService _authorizeService = authorizeService;

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UploadLoginAdmin model)
        {
            if (ModelState.IsValid)
            {
                var claimsPrincipal = await _authorizeService.SingInAsync(model);
                var authenticationProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(12)
                };

                await HttpContext.SignInAsync(claimsPrincipal, authenticationProperties);

                return RedirectToAction("Index", "Admin");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Authorize");
        }
    }
}
