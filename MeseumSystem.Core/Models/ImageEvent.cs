using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class ImageEvent
    {
        [Key]
        public int IdImageEvent { get; set; }

        public int EventId { get; set; }

        public string NamePath { get; set; }

        public Event Event { get; set; }
    }
}
