﻿using MuseumSystem.Core.Models;
using MuseumSystem.Core.UploadModels;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IClientService
    {
        public Task CreateClientAsync(UploadRecord model);
        public Task<ICollection<Client>> GetClients();
        public Task<Client> GetClient(int id);
        public bool CheckUniqueClient(string email, out int userId);
        public Task<Client> GetLastClient();
    }
}
