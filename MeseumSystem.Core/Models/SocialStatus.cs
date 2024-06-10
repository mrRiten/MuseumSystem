using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MuseumSystem.Core.Models
{
    public class SocialStatus
    {
        [Key]
        public int IdSocialStatus { get; set; }

        public string NameSocialStatus { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price {  get; set; }
    }
}
