using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaDataModels.Migrations
{
    /// <inheritdoc />
    public partial class Tester : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Movies_MovieId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_PostalCodes_PostalCodeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MovieId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Genres");

            migrationBuilder.RenameColumn(
                name: "PostalCodeId",
                table: "Users",
                newName: "PostalCodesPostalCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PostalCodeId",
                table: "Users",
                newName: "IX_Users_PostalCodesPostalCodeId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ReleaseDate",
                table: "Movies",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresGenreId = table.Column<int>(type: "int", nullable: false),
                    MoviesMovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresGenreId, x.MoviesMovieId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresGenreId",
                        column: x => x.GenresGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesMovieId",
                table: "GenreMovie",
                column: "MoviesMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PostalCodes_PostalCodesPostalCodeId",
                table: "Users",
                column: "PostalCodesPostalCodeId",
                principalTable: "PostalCodes",
                principalColumn: "PostalCodeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PostalCodes_PostalCodesPostalCodeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.RenameColumn(
                name: "PostalCodesPostalCodeId",
                table: "Users",
                newName: "PostalCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_PostalCodesPostalCodeId",
                table: "Users",
                newName: "IX_Users_PostalCodeId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MovieId",
                table: "Genres",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Movies_MovieId",
                table: "Genres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PostalCodes_PostalCodeId",
                table: "Users",
                column: "PostalCodeId",
                principalTable: "PostalCodes",
                principalColumn: "PostalCodeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
