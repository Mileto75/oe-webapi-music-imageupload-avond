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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
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
                    { 1, 15044763, "images/artist/metallica.jpg", "Metallica", 85 },
                    { 2, 17664350, "images/artist/gunsnroses.jpg", "Guns N' Roses", 82 },
                    { 3, 11175759, "images/artist/nirvana.jpg", "Nirvana", 82 },
                    { 4, 5980792, "images/artist/pearljam.jpg", "Pearl Jam", 79 },
                    { 5, 9637, "images/artist/channelzero.jpg", "Channel Zero", 30 },
                    { 6, 78309, "images/artist/therapy.jpg", "Therapy?", 44 },
                    { 7, 4468769, "images/artist/rageagainstthemachine.jpg", "Rage Against The Machine", 73 },
                    { 8, 2141, "images/artist/kinghiss.jpg", "King Hiss", 15 }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Image", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, "andjusticeforall.jpg", "...And Justice for All", new DateTime(1988, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, "metallica.jpg", "Metallica", new DateTime(1991, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, "masterofpuppets.jpg", "Master of Puppets", new DateTime(1986, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, "hardwired.jpg", "Hardwired...To Self-Destruct", new DateTime(2016, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, "appetitefordestruction.jpg", "Appetite For Destruction", new DateTime(1987, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, "useyourillusion1.jpg", "Use Your Illusion I", new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 2, "useyourillusion2.jpg", "Use Your Illusion II", new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, "mtvunpluggedinnewyork.jpg", "MTV Unplugged In New York", new DateTime(1994, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, "liveatreading.jpg", "Live at Reading", new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 3, "nevermind.jpg", "Nevermind", new DateTime(1991, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4, "ten.jpg", "Ten", new DateTime(1991, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 4, "spintheblackcirclelive.jpg", "Spin The Black Circle Live In Seattle '95", new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 5, "livetheanciennebelgique.jpg", "Live @ The Ancienne Belgique", new DateTime(2010, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 5, "blackfuel.jpg", "Black Fuel", new DateTime(1997, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 7, "rageagainstthemachine.jpg", "Rage Against The Machine", new DateTime(1992, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 7, "evilempire.jpg", "Evil Empire", new DateTime(1996, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
