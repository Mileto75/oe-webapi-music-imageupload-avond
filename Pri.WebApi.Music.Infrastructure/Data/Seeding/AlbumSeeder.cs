using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Core.Entities;
using System;

namespace Pri.Oe.WebApi.Music.Infrastructure.Data.Seeding
{
    public class AlbumSeeder
    {

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                // Metallica
                new Album
                {
                    Id = 1,
                    Name = "...And Justice for All",
                    ReleaseDate = DateTime.Parse("7/09/1988 0:00:00"),
                    Image = "images/album/andjusticeforall.jpg",
                    ArtistId = 1
                },
                new Album
                {
                    Id = 2,
                    Name = "Metallica",
                    ReleaseDate = DateTime.Parse("12/08/1991 0:00:00"),
                    Image = "images/album/metallica.jpg",
                    ArtistId = 1
                },
                new Album
                {
                    Id = 3,
                    Name = "Master of Puppets",
                    ReleaseDate = DateTime.Parse("3/03/1986 0:00:00"),
                    Image = "images/album/masterofpuppets.jpg",
                    ArtistId = 1
                },
                new Album
                {
                    Id = 4,
                    Name = "Hardwired...To Self-Destruct",
                    ReleaseDate = DateTime.Parse("18/11/2016 0:00:00"),
                    Image = "images/album/hardwired.jpg",
                    ArtistId = 1
                },

                // Guns 'n Roses
                new Album
                {
                    Id = 5,
                    Name = "Appetite For Destruction",
                    ReleaseDate = DateTime.Parse("21/07/1987 0:00:00"),
                    Image = "images/album/appetitefordestruction.jpg",
                    ArtistId = 2
                },
                new Album
                {
                    Id = 6,
                    Name = "Use Your Illusion I",
                    ReleaseDate = DateTime.Parse("17/09/1991 0:00:00"),
                    Image = "images/album/useyourillusion1.jpg",
                    ArtistId = 2
                },
                new Album
                {
                    Id = 7,
                    Name = "Use Your Illusion II",
                    ReleaseDate = DateTime.Parse("17/09/1991 0:00:00"),
                    Image = "images/album/useyourillusion2.jpg",
                    ArtistId = 2
                },

                // Nirvana
                new Album
                {
                    Id = 8,
                    Name = "MTV Unplugged In New York",
                    ReleaseDate = DateTime.Parse("1/11/1994 0:00:00"),
                    Image = "images/album/mtvunpluggedinnewyork.jpg",
                    ArtistId = 3
                },
                new Album
                {
                    Id = 9,
                    Name = "Live at Reading",
                    ReleaseDate = DateTime.Parse("1/01/2009 0:00:00"),
                    Image = "images/album/liveatreading.jpg",
                    ArtistId = 3
                },
                new Album
                {
                    Id = 10,
                    Name = "Nevermind",
                    ReleaseDate = DateTime.Parse("26/09/1991 0:00:00"),
                    Image = "images/album/nevermind.jpg",
                    ArtistId = 3
                },

                // Pearl Jam
                new Album
                {
                    Id = 11,
                    Name = "Ten",
                    ReleaseDate = DateTime.Parse("27/08/1991 0:00:00"),
                    Image = "images/album/ten.jpg",
                    ArtistId = 4
                },
                new Album
                {
                    Id = 12,
                    Name = "Spin The Black Circle Live In Seattle '95",
                    ReleaseDate = DateTime.Parse("1/01/1995 0:00:00"),
                    Image = "images/album/spintheblackcirclelive.jpg",
                    ArtistId = 4
                },

                // Channel Zero
                new Album
                {
                    Id = 13,
                    Name = "Live @ The Ancienne Belgique",
                    ReleaseDate = DateTime.Parse("30/04/2010 0:00:00"),
                    Image = "images/album/livetheanciennebelgique.jpg",
                    ArtistId = 5
                },
                new Album
                {
                    Id = 14,
                    Name = "Black Fuel",
                    ReleaseDate = DateTime.Parse("27/01/1997 0:00:00"),
                    Image = "images/album/blackfuel.jpg",
                    ArtistId = 5
                },

                // Rage against The Machine
                new Album
                {
                    Id = 15,
                    Name = "Rage Against The Machine",
                    ReleaseDate = DateTime.Parse("03/11/1992 0:00:00"),
                    Image = "images/album/rageagainstthemachine.jpg",
                    ArtistId = 7
                },
                new Album
                {
                    Id = 16,
                    Name = "Evil Empire",
                    ReleaseDate = DateTime.Parse("16/04/1996 0:00:00"),
                    Image = "images/album/evilempire.jpg",
                    ArtistId = 7
                }
                );
        }
    }
}
