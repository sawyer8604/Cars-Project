using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cars.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Areas_AreaId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeID",
                table: "Models");

            migrationBuilder.DropIndex(
                name: "IX_Models_MakeID",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "MakeID",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "AreId",
                table: "Cars",
                newName: "ModelId");

            migrationBuilder.AlterColumn<string>(
                name: "SellersPhoneNumber",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Areas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Areas_AreaId",
                table: "Cars",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Areas_AreaId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ModelId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "ModelId",
                table: "Cars",
                newName: "AreId");

            migrationBuilder.AddColumn<int>(
                name: "MakeID",
                table: "Models",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SellersPhoneNumber",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Models_MakeID",
                table: "Models",
                column: "MakeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Areas_AreaId",
                table: "Cars",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeID",
                table: "Models",
                column: "MakeID",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
