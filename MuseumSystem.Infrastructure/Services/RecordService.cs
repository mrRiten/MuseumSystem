using MuseumSystem.Application.RepositoryContracts;
using MuseumSystem.Application.ServiceContracts;
using MuseumSystem.Core.Models;

namespace MuseumSystem.Infrastructure.Services
{
    public class RecordService(IRecordRepository recordRepository, IRecordClientRepository recordClientRepository) : IRecordService
    {
        private readonly IRecordClientRepository _recordClientRepository = recordClientRepository;
        private readonly IRecordRepository _recordRepository = recordRepository;

        public async Task CreateRecord(Record record)
        {
            await _recordRepository.CreateAsync(record);
        }

        public async Task CreateRecordClient(RecordClient recordClient)
        {
            await _recordClientRepository.CreateAsync(recordClient);
        }
    }
}
