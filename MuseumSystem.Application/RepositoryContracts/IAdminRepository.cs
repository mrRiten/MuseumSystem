using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IAdminRepository
    {
        public Task<Admin> GetAsync(string login);
        public Task<Admin> GetAsync(int adminId);

        public Task CreateAsync(Admin admin);
        public Task UpdateAsync(Admin admin);
        public Task DeleteAsync(Admin admin);
    }
}
