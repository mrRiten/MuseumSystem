using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class RecordClient
    {
        [Key]
        public int IdRecordClient { get; set; }

        public int RecordId { get; set; }

        public int ClientId { get; set; }

        public decimal Price { get; set; }

        public Record Record { get; set; }

        public Client Client { get; set; }
    }
}
