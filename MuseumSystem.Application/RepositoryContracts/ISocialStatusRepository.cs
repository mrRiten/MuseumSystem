using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.RepositoryContracts
{
    public interface ISocialStatusRepository
    {
        public Task<ICollection<SocialStatus>> GetByRecordAsync(int recordId);

        public Task CreateAsync(SocialStatus socialStatus);
        public Task UpdateAsync(SocialStatus socialStatus);
        public Task DeleteAsync(SocialStatus socialStatus);
    }
}
