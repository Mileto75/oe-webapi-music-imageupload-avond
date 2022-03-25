using Microsoft.AspNetCore.Http;
using Pri.Oe.WebApi.Music.Core.Entities.Base;
using System;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Core.Services.Images
{
    public interface IImageService
    {
        Task<string> AddOrUpdateImageAsync<T>(Guid entityId, IFormFile image);
    }
}
