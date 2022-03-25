using Microsoft.AspNetCore.Http;
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
        public async Task<bool> AddAsync(string name, DateTime releaseDate, IFormFile image, int artistId)
        {
            var newAlbum = new Album 
            {
                Name = name,
                ReleaseDate = releaseDate,
                Image = image.FileName,
                ArtistId = artistId
            };
            try 
            {
                await _albumRepository.AddAsync(newAlbum);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
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

        public async Task<bool> UpdateAsync(int id, string name, DateTime releaseDate, IFormFile image, int artistId)
        {
            var albumToUpdate = await _albumRepository.GetByIdAsync(id);
            if(albumToUpdate == null)
            {
                return false;
            }
            albumToUpdate.Name = name;
            albumToUpdate.ArtistId = artistId;
            albumToUpdate.ReleaseDate = releaseDate;
            albumToUpdate.Image = image.FileName;
            try 
            {
                await _albumRepository.UpdateAsync(albumToUpdate);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
