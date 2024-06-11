using MuseumSystem.Core.Models;

namespace MuseumSystem.Application.ServiceContracts
{
    public interface IRecordService
    {
        public Task CreateRecordClient(RecordClient recordClient);
        public Task CreateRecord(Record record);

    }
}
