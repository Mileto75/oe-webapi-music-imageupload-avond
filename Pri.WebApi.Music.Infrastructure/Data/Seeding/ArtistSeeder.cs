using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Infrastructure.Data.Seeding
{
    public class ArtistSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Name = "Metallica", Followers = 15044763, Popularity = 85, Image = "images/artist/metallica.jpg", Id = 1, },
                new Artist { Name = "Guns N' Roses", Followers = 17664350, Popularity = 82,  Image = "images/artist/gunsnroses.jpg", Id = 2, },
                new Artist { Name = "Nirvana", Followers = 11175759, Popularity = 82, Image = "images/artist/nirvana.jpg", Id = 3, },
                new Artist { Name = "Pearl Jam", Followers = 5980792, Popularity = 79,  Image = "images/artist/pearljam.jpg", Id = 4, },
                new Artist { Name = "Channel Zero", Followers = 9637, Popularity = 30, Image = "images/artist/channelzero.jpg", Id = 5, },
                new Artist { Name = "Therapy?", Followers = 78309, Popularity = 44, Image = "images/artist/therapy.jpg", Id = 6, },
                new Artist { Name = "Rage Against The Machine", Followers = 4468769, Popularity = 73, Image = "images/artist/rageagainstthemachine.jpg", Id = 7, },
                new Artist { Name = "King Hiss", Followers = 2141, Popularity = 15, Image = "images/artist/kinghiss.jpg", Id = 8, }
            );
        }
    }
}
