using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Data.Migrations
{
    /// <inheritdoc />
    public partial class Towns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Town_AreaId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Town",
                table: "Town");

            migrationBuilder.RenameTable(
                name: "Town",
                newName: "Towns");

            migrationBuilder.RenameIndex(
                name: "IX_Town_IsDeleted",
                table: "Towns",
                newName: "IX_Towns_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Towns",
                table: "Towns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Towns_AreaId",
                table: "Cars",
                column: "AreaId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Towns_AreaId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Towns",
                table: "Towns");

            migrationBuilder.RenameTable(
                name: "Towns",
                newName: "Town");

            migrationBuilder.RenameIndex(
                name: "IX_Towns_IsDeleted",
                table: "Town",
                newName: "IX_Town_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Town",
                table: "Town",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Town_AreaId",
                table: "Cars",
                column: "AreaId",
                principalTable: "Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
