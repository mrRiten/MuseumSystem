using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class EmailData
    {
        [Key]
        public int IdEmailData { get; set; }

        public int ClientId { get; set; }

        public int TargetEventId { get; set; }

        public int TargetRecordId { get; set; }

        public Client Client { get; set; }
        public Record TargetRecord { get; set; }
        public Event TargetEvent { get; set; }
    }
}
