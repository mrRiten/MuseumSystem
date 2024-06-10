using MuseumSystem.Core.Models;

namespace MuseumSystem.Core.ModelsDTO
{
    public class MuseumDTO
    {
        public Museum Museum { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
