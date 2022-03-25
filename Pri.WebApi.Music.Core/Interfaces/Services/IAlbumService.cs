using Pri.Oe.WebApi.Music.Core.Entities;
using Pri.WebApi.Music.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.WebApi.Music.Core.Interfaces.Services
{
    public interface IAlbumService
    {
        public Task<ItemResultModel<Album>> GetAllAsync();
        public Task<bool> AddAsync(string name, DateTime releaseDate,string image, int artistId);
        public Task<bool> UpdateAsync(int id, string name, DateTime releaseDate, string image, int artistId);
        public Task<ItemResultModel<Album>> GetByIdAsync(int id);


    }
}
