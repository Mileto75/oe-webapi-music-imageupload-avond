using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Dtos.Albums
{
    public class AlbumRequestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public int ArtistId { get; set; }
        public IFormFile Image { get; set; }
    }
}
