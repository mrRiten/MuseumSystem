using MuseumSystem.Core.UploadModels;
using System.Security.Claims;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IAuthorizeService
    {
        public Task<ClaimsPrincipal?> SingInAsync(UploadLoginAdmin admin);
        public Task SingOutAsync(ClaimsPrincipal claims);
    }
}
