using Pri.Oe.WebApi.Music.Api.Dtos.Albums;
using System;
using System.Collections.Generic;

namespace Pri.Oe.WebApi.Music.Api.Dtos.Artists
{
    public class ArtistResponseDto : BaseDto
    {
        public string Name { get; set; }
        public int Followers { get; set; }
        public int Popularity { get; set; }
        public string Image { get; set; }
    }
}
