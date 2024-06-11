using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Column(TypeName = "decimal(8, 2)")]
        public decimal? PreferentialPrice { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal? RetirementPrice { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal FullPrice { get; set; }

        public Museum Museum { get; set; }
        public ICollection<ImageEvent> ImageEvents { get; set; }
        public ICollection<Record> Records { get; set; }
    }
}
