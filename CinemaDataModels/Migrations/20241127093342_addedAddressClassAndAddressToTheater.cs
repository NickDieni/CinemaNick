using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaDataModels.Migrations
{
    /// <inheritdoc />
    public partial class addedAddressClassAndAddressToTheater : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "PostalCodes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<int>(type: "int", nullable: false),
                    Building = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheaterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Theaters_TheaterId",
                        column: x => x.TheaterId,
                        principalTable: "Theaters",
                        principalColumn: "TheaterId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostalCodes_AddressId",
                table: "PostalCodes",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TheaterId",
                table: "Addresses",
                column: "TheaterId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostalCodes_Addresses_AddressId",
                table: "PostalCodes",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostalCodes_Addresses_AddressId",
                table: "PostalCodes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_PostalCodes_AddressId",
                table: "PostalCodes");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "PostalCodes");
        }
    }
}
