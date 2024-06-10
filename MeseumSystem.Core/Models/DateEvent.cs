using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class DateEvent
    {
        [Key]
        public int IdDateEvent { get; set; }

        public int EventId { get; set; }

        public DateTime EventDate { get; set; }

        public Event Event { get; set; }
    }
}
