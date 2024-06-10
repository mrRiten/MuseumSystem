using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface IRecordRepository
    {
        public Task<Record> GetAsync(int id);
        public Task<ICollection<Record>> GetByEventAsync(int eventId);

        public Task CreateAsync(Record record);
        public Task UpdateAsync(Record record);
        public Task DeleteAsync(Record record);
    }
}
