using MuseumSystem.Core.Models;

namespace MuseumSystem.Core.ModelsDTO
{
    public class PosterDTO
    {
        public Museum Museum { get; set; }
        public Event CurrentEvent { get; set; }
    }
}
