using Microsoft.AspNetCore.Mvc;
using Pri.Oe.WebApi.Music.Api.Dtos.Albums;
using Pri.Oe.WebApi.Music.Core.Entities;
using Pri.Oe.WebApi.Music.Core.Repositories.Interfaces;
using Pri.WebApi.Music.Core.Interfaces.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        
        public AlbumsController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _albumService.GetAllAsync();
            if(!result.IsSuccess)
            {
                return BadRequest(result.Error);
            }
            var albumsResponseDto = result.Items.Select(
                r => new AlbumResponseDto 
                {
                    Id = r.Id,
                    Name = r.Name,
                    ArtistId = r.ArtistId,
                    ArtistName = r.Artist.Name,
                    Image = r.Image,
                    ReleaseYear = r.ReleaseDate.Year.ToString()
                }).ToList();
            { }
            
            return Ok(albumsResponseDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]AlbumRequestDto albumRequestDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            //call service method
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(AlbumRequestDto albumRequestDto)
        {
            return Ok();
        }
    }
}
