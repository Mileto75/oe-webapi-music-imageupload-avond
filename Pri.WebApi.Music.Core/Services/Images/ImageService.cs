using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Pri.Oe.WebApi.Music.Core.Entities.Base;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Core.Services.Images
{
    public class ImageService : IImageService
    {
        private readonly IHostEnvironment _webHostEnvironment;

        public ImageService(IHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> AddOrUpdateImageAsync<T>(Guid entityId, IFormFile image)
        {
            // sets path for image property in database
            var pathForDatabase = Path.Combine("images",
                typeof(T).Name.ToLower()); // Reads name of the T type as string, example: artist or album

            // get path to folder where we want to save images
            var folderPathForImages = Path.Combine(
                _webHostEnvironment.ContentRootPath, // Gets the rooturl from filesystem on server from root to the folder of the API project, like: C:\devhowest\pri\Pri.WebApi.Music\Pri.WebApi.Music.Api
                "wwwroot",
                pathForDatabase);


            // create folder if it does not exists
            if (!Directory.Exists(folderPathForImages))
            {
                Directory.CreateDirectory(folderPathForImages);
            }

            // get extension from file (this includes the . (dot)) example: .jpg
            var fileExtension = Path.GetExtension(image.FileName);

            // create new filename for image, in this case, the filename is the entityId, example: 56eb6039-1959-4413-82c5-08d98db42562.jpg
            var newFileNameWithExtension = $"{entityId}{fileExtension}";

            // get full file path, example: C:\devhowest\pri\Pri.WebApi.Music\Pri.WebApi.Music.Api\wwwroot\images\artist\56eb6039-1959-4413-82c5-08d98db42562.jpg
            var filePath = Path.Combine(folderPathForImages, newFileNameWithExtension);

            // save file to disk
            if (image.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
            }

            var filePathForDatabase = Path.Combine(pathForDatabase, newFileNameWithExtension);

            return filePathForDatabase;
        }
    }
}
