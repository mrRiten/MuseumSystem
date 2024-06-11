using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IRecordClientRepository
    {
        public Task<ICollection<RecordClient>> GetByClientAsync(int clientId);
        public Task<ICollection<RecordClient>> GetByRecordAsync(int recordId);

        public Task CreateAsync(RecordClient recordClient);
        public Task UpdateAsync(RecordClient recordClient);

        public Task DeleteAsync(RecordClient[] recordClients );
        public Task DeleteAsync(RecordClient recordClient);
    }
}
