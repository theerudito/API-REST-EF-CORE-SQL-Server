using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSQLServer.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NarutoId",
                table: "Jutsus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jutsus_NarutoId",
                table: "Jutsus",
                column: "NarutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jutsus_Characters_NarutoId",
                table: "Jutsus",
                column: "NarutoId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jutsus_Characters_NarutoId",
                table: "Jutsus");

            migrationBuilder.DropIndex(
                name: "IX_Jutsus_NarutoId",
                table: "Jutsus");

            migrationBuilder.DropColumn(
                name: "NarutoId",
                table: "Jutsus");
        }
    }
}
