using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Api.Dtos.Artists
{
    public class ArtistUpdateRequestDto : BaseDto
    {
        public string Name { get; set; }
        public int Popularity { get; set; }
    }
}
