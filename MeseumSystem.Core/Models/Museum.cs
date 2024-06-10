using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class Museum
    {
        [Key] 
        public int IdMuseum { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string DateDescription { get; set; }

        public string SlugMuseum { get; set; }

        public List<Admin> Admins { get; set; }
        public List<Event> Events { get; set; }
    }
}
