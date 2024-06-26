﻿namespace MuseumSystem.Web.WebHelpers
{
    public static class ImageSaveWebHelper
    {
        public static void SaveImages(int eventId, ICollection<IFormFile> files, IWebHostEnvironment webHost)
        {
            var uploadDirectory = Path.Combine(webHost.WebRootPath, $"upload/{eventId}");

            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }

            foreach (var file in files)
            {
                if (file != null && file.Length > 0)
                {
                    var filePath = Path.Combine(uploadDirectory, Path.GetFileName(file.FileName));

                    using var stream = new FileStream(filePath, FileMode.Create);
                    file.CopyTo(stream);
                }
            }
        }
    }
}
