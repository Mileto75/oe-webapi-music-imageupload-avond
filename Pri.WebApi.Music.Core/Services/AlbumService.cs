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

        public async Task<ItemResultModel<Album>> GetAllAsync()
        {
            return new ItemResultModel<Album>
            {
                Items = await _albumRepository.ListAllAsync(),
                Error = "",
                IsSuccess = true
            };
        }

        public async Task<ItemResultModel<Album>> GetByIdAsync(int id)
        {
            ItemResultModel<Album> itemResultModel = new();
            if(id < 1)
            {
                itemResultModel.IsSuccess = false;
                itemResultModel.Error = "No album found!";
                return itemResultModel;
            }
            var album = await _albumRepository.GetByIdAsync(id);
            if(album == null)
            {
                itemResultModel.IsSuccess = false;
                itemResultModel.Error = "No album found!";
                return itemResultModel;
            }
            itemResultModel.Items = new List<Album> { album };
            itemResultModel.IsSuccess = true;
            return itemResultModel;
        }

        public Task<bool> UpdateAsync(int id, string name, DateTime releaseDate, string image, int artistId)
        {
            throw new NotImplementedException();
        }
    }
}
