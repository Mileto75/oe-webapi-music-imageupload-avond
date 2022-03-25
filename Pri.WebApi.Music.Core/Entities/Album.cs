using Pri.Oe.WebApi.Music.Core.Entities.Base;
using System;

namespace Pri.Oe.WebApi.Music.Core.Entities
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Image { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
