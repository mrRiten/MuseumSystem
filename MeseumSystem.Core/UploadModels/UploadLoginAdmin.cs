using System.ComponentModel.DataAnnotations;

namespace MuseumSystem.Core.UploadModels
{
    public class UploadLoginAdmin
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
