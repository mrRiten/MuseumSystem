using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string MiddleName { get; set; }
    
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
