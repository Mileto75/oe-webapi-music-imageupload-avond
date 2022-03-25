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
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AlbumRequestDto albumRequestDto)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(AlbumRequestDto albumRequestDto)
        {
            return Ok();
        }
    }
}
