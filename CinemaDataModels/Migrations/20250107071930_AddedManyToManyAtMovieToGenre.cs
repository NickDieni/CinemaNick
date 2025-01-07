using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaDataModels.Migrations
{
    /// <inheritdoc />
    public partial class AddedManyToManyAtMovieToGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genres_GenresGenreId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Movies_MoviesMovieId",
                table: "GenreMovie");

            migrationBuilder.RenameColumn(
                name: "MoviesMovieId",
                table: "GenreMovie",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "GenresGenreId",
                table: "GenreMovie",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreMovie_MoviesMovieId",
                table: "GenreMovie",
                newName: "IX_GenreMovie_MovieId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genres_GenreId",
                table: "GenreMovie",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Movies_MovieId",
                table: "GenreMovie",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Genres_GenreId",
                table: "GenreMovie");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreMovie_Movies_MovieId",
                table: "GenreMovie");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "GenreMovie",
                newName: "MoviesMovieId");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GenreMovie",
                newName: "GenresGenreId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreMovie_MovieId",
                table: "GenreMovie",
                newName: "IX_GenreMovie_MoviesMovieId");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ReleaseDate",
                table: "Movies",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Genres_GenresGenreId",
                table: "GenreMovie",
                column: "GenresGenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreMovie_Movies_MoviesMovieId",
                table: "GenreMovie",
                column: "MoviesMovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
