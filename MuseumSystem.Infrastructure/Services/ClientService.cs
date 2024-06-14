using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;
using MuseumSystem.Core.UploadModels;

namespace MuseumSystem.Infrastructure.Services
{
    public class ClientService(IClientRepository clientRepository) : IClientService
    {
        private readonly IClientRepository _clientRepository = clientRepository;

        public bool CheckUniqueClient(string email, out int clientId)
        {
            var client = _clientRepository.GetByEmail(email);

            if (client == null)
            {
                clientId = 0;
                return true;
            }

            clientId = client.IdClient;
            return false;
        }

        public async Task CreateClientAsync(UploadRecord model)
        {
            var client = new Client
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
            };

            await _clientRepository.CreateAsync(client);
        }

        public async Task<Client> GetClient(int id)
        {
            return await _clientRepository.GetAsync(id);
        }

        public async Task<ICollection<Client>> GetClients()
        {
            return await _clientRepository.GetAllAsync();
        }

        public async Task<Client> GetLastClient()
        {
            return await _clientRepository.GetLast();
        }
    }
}
