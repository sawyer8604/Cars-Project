using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Data.Migrations
{
    /// <inheritdoc />
    public partial class Townss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Towns_AreaId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "AreaId",
                table: "Cars",
                newName: "TownId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_AreaId",
                table: "Cars",
                newName: "IX_Cars_TownId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Towns_TownId",
                table: "Cars",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Towns_TownId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "Cars",
                newName: "AreaId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_TownId",
                table: "Cars",
                newName: "IX_Cars_AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Towns_AreaId",
                table: "Cars",
                column: "AreaId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
