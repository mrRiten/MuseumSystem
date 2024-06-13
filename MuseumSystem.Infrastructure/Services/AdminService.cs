using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;
using MuseumSystem.Core.UploadModels;

namespace MuseumSystem.Infrastructure.Services
{
    public class AdminService(IAdminRepository adminRepository) : IAdminService
    {
        private readonly IAdminRepository _adminRepository = adminRepository;

        public async Task CreateAsync(UploadRegisterAdmin uploadAdmin)
        {
            var admin = new Admin
            {
                Login = uploadAdmin.Login,
                HashPassword = uploadAdmin.Password,
                MuseumId = uploadAdmin.MuseumId,
                RoleId = 1,
            };

            await _adminRepository.CreateAsync(admin);
        }

        public async Task DeleteAsync(int id)
        {
            var admin = await _adminRepository.GetAsync(id);

            await _adminRepository.DeleteAsync(admin);
        }

        public async Task<Admin> GetAdminAsync(int id)
        {
            return await _adminRepository.GetAsync(id);
        }

        public async Task<Admin> GetAdminAsync(string name)
        {
            return await _adminRepository.GetAsync(name);
        }

        public Task UpdateAsync(Admin admin)
        {
            return _adminRepository.UpdateAsync(admin);
        }
    }
}
