using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class Record
    {
        [Key]
        public int IdRecord { get; set; }

        public int SocialStatusId { get; set; }

        public int EventId { get; set; }

        public SocialStatus SocialStatus { get; set; }
        public Event Event { get; set; }
    }
}
