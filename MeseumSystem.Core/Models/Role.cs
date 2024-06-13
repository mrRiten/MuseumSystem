using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        public string Name { get; set; }

        public ICollection<Admin> Admins { get; set; }
    }
}
