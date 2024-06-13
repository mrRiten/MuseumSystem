using MuseumSystem.Core.Models;
using MuseumSystem.Core.UploadModels;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IAdminService
    {
        public Task<Admin> GetAdminAsync(int id);
        public Task<Admin> GetAdminAsync(string name);

        public Task CreateAsync(UploadRegisterAdmin uploadAdmin);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(Admin admin);
    }
}
