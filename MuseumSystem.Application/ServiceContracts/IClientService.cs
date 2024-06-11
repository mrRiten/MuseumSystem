using MuseumSystem.Core.Models;
using MuseumSystem.Core.UploadModels;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IClientService
    {
        public Task CreateClientAsync(UploadRecord model);
        public Task<Client> GetClient(int id);
        public Task<Client> GetLastClient();
    }
}
