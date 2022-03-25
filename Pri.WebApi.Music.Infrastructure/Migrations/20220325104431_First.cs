using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pri.WebApi.Music.Infrastructure.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Followers = table.Column<int>(type: "int", nullable: false),
                    Popularity = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Followers", "Image", "Name", "Popularity" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 15044763, "images/artist/metallica.jpg", "Metallica", 85 },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 17664350, "images/artist/gunsnroses.jpg", "Guns N' Roses", 82 },
                    { new Guid("00000000-0000-0000-0000-000000000003"), 11175759, "images/artist/nirvana.jpg", "Nirvana", 82 },
                    { new Guid("00000000-0000-0000-0000-000000000004"), 5980792, "images/artist/pearljam.jpg", "Pearl Jam", 79 },
                    { new Guid("00000000-0000-0000-0000-000000000005"), 9637, "images/artist/channelzero.jpg", "Channel Zero", 30 },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 78309, "images/artist/therapy.jpg", "Therapy?", 44 },
                    { new Guid("00000000-0000-0000-0000-000000000007"), 4468769, "images/artist/rageagainstthemachine.jpg", "Rage Against The Machine", 73 },
                    { new Guid("00000000-0000-0000-0000-000000000008"), 2141, "images/artist/kinghiss.jpg", "King Hiss", 15 }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), "images/album/andjusticeforall.jpg", "...And Justice for All", new DateTime(1988, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000001"), "images/album/metallica.jpg", "Metallica", new DateTime(1991, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000001"), "images/album/masterofpuppets.jpg", "Master of Puppets", new DateTime(1986, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), "images/album/hardwired.jpg", "Hardwired...To Self-Destruct", new DateTime(2016, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000002"), "images/album/appetitefordestruction.jpg", "Appetite For Destruction", new DateTime(1987, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000002"), "images/album/useyourillusion1.jpg", "Use Your Illusion I", new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000002"), "images/album/useyourillusion2.jpg", "Use Your Illusion II", new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000003"), "images/album/mtvunpluggedinnewyork.jpg", "MTV Unplugged In New York", new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000003"), "images/album/liveatreading.jpg", "Live at Reading", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000003"), "images/album/nevermind.jpg", "Nevermind", new DateTime(1991, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000004"), "images/album/ten.jpg", "Ten", new DateTime(1991, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000004"), "images/album/spintheblackcirclelive.jpg", "Spin The Black Circle Live In Seattle '95", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000005"), "images/album/livetheanciennebelgique.jpg", "Live @ The Ancienne Belgique", new DateTime(2010, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000005"), "images/album/blackfuel.jpg", "Black Fuel", new DateTime(1997, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new Guid("00000000-0000-0000-0000-000000000007"), "images/album/rageagainstthemachine.jpg", "Rage Against The Machine", new DateTime(1992, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new Guid("00000000-0000-0000-0000-000000000007"), "images/album/evilempire.jpg", "Evil Empire", new DateTime(1996, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
