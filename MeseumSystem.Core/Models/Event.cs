using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class Event
    {
        [Key]
        public int IdEvent { get; set; }

        public string NameEvent { get; set; }

        public string DescriptionEvent { get; set; }

        public int AgeRating { get; set; }

        public int MuseumId { get; set; }

        public string SlugEvent { get; set; }

        public Museum Museum { get; set; }

        public List<DateEvent> DateEvents { get; set; }
        public List<ImageEvent> ImageEvents { get; set; }
        public List<Record> Record { get; set; }
    }
}
