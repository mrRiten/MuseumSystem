using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuseumSystem.Core.Models
{
    public class RecordClient
    {
        [Key]
        public int IdRecordClient { get; set; }

        public int RecordId { get; set; }

        public int ClientId { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        public Record Record { get; set; }

        public Client Client { get; set; }
    }
}
