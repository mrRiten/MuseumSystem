using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class Record
    {
        [Key]
        public int IdRecord { get; set; }

        public int EventId { get; set; }

        public DateTime dateTime { get; set; }

        public Event Event { get; set; }
        public ICollection<EmailData> EmailDatas { get; set; }
    }
}
