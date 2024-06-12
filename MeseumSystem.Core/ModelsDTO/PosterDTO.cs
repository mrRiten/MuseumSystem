using MuseumSystem.Core.Models;
using MuseumSystem.Core.UploadModels;

namespace MuseumSystem.Core.ModelsDTO
{
    public class PosterDTO
    {
        public Museum? Museum { get; set; }
        public Event? CurrentEvent { get; set; }
        public UploadRecord? UploadRecord { get; set; }
    }
}
