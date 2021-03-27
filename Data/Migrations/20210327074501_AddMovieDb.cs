using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace popflix.Data.Migrations
{
    public partial class AddMovieDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Banner = table.Column<byte[]>(nullable: true),
                    MovieLink = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    About = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: false),
                    Producer = table.Column<string>(nullable: false),
                    Actors = table.Column<string>(nullable: false),
                    WatchTime = table.Column<string>(nullable: false),
                    Release = table.Column<string>(nullable: false),
                    Ratings = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
