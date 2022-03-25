using Pri.Oe.WebApi.Music.Api.Dtos.Artists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Dtos.Albums
{
    public class AlbumResponseDto:BaseDto
    {
        public string Name { get; set; }
        public string ReleaseYear { get; set; }
        public string Image { get; set; }
        public string ArtistName { get; set; }
        public int ArtistId { get; set; }
    }
}
