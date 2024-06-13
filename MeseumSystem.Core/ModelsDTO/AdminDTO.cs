using MuseumSystem.Core.Models;

namespace MuseumSystem.Core.ModelsDTO
{
    public class AdminDTO
    {
        public Admin Admin { get; set; }
         
        public ICollection<Client> Clients { get; set; }

        public ICollection<Event>? UserEvent { get; set; }
    }
}
