using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.UploadModels;
using System.Security.Claims;

namespace MuseumSystem.Infrastructure.Services
{
    public class AuthorizeService(IAdminRepository adminRepository) : IAuthorizeService
    {
        private readonly IAdminRepository _adminRepository = adminRepository;

        public async Task<ClaimsPrincipal?> SingInAsync(UploadLoginAdmin model)
        {
            var admin = await _adminRepository.GetAsync(model.Login);

            if (admin != null && admin.HashPassword == model.Password)
            {
                var claims = new List<Claim>
                {
                    new(ClaimTypes.Name, admin.Login),
                    new(ClaimTypes.Role, admin.Role.Name)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                return claimsPrincipal;
            }

            return null;
        }

        public Task SingOutAsync(ClaimsPrincipal claims)
        {
            throw new NotImplementedException();
        }
    }
}
