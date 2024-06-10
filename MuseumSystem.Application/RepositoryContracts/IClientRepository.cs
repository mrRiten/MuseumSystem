﻿using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IClientRepository
    {
        public Task<Client> GetAsync(int id);
        public Task<Client> GetAsync(string fullName);
        public Task<Client> GetByRecord(int recordId);

        public Task CreateAsync(Client client);
        public Task UpdateAsync(Client client);
        public Task DeleteAsync(Client client);
    }
}
