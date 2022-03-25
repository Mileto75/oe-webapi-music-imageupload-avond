using Pri.Oe.WebApi.Music.Core.Entities;
using Pri.Oe.WebApi.Music.Core.Repositories.Interfaces;
using Pri.WebApi.Music.Core.Interfaces.Services;
using Pri.WebApi.Music.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.WebApi.Music.Core.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public Task<bool> AddAsync(string name, DateTime releaseDate, string image, int artistId)
        {
            throw new NotImplementedException();
        }

        public Task<ItemResultModel<Album>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ItemResultModel<Album>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, string name, DateTime releaseDate, string image, int artistId)
        {
            throw new NotImplementedException();
        }
    }
}
