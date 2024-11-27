using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaDataModels.Migrations
{
    /// <inheritdoc />
    public partial class ChangedStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostalCodes_Users_UserId",
                table: "PostalCodes");

            migrationBuilder.DropIndex(
                name: "IX_PostalCodes_UserId",
                table: "PostalCodes");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Showtimes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostalCodes");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.AddColumn<int>(
                name: "PostalCodeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Movies",
                type: "decimal(3,1)",
                precision: 3,
                scale: 1,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldPrecision: 2,
                oldScale: 1);

            migrationBuilder.AddColumn<int>(
                name: "ShowtimeId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PostalCodeId",
                table: "Users",
                column: "PostalCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ShowtimeId",
                table: "Movies",
                column: "ShowtimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Showtimes_ShowtimeId",
                table: "Movies",
                column: "ShowtimeId",
                principalTable: "Showtimes",
                principalColumn: "ShowtimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PostalCodes_PostalCodeId",
                table: "Users",
                column: "PostalCodeId",
                principalTable: "PostalCodes",
                principalColumn: "PostalCodeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Showtimes_ShowtimeId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_PostalCodes_PostalCodeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PostalCodeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ShowtimeId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PostalCodeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ShowtimeId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Showtimes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PostalCodes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Movies",
                type: "decimal(2,1)",
                precision: 2,
                scale: 1,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldPrecision: 3,
                oldScale: 1);

            migrationBuilder.CreateIndex(
                name: "IX_PostalCodes_UserId",
                table: "PostalCodes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostalCodes_Users_UserId",
                table: "PostalCodes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
