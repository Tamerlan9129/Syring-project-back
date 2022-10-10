using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Syring_project.Migrations
{
    public partial class CategoryComponentAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryComponent_Categories_CategoryId",
                table: "CategoryComponent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryComponent",
                table: "CategoryComponent");

            migrationBuilder.RenameTable(
                name: "CategoryComponent",
                newName: "CategoryComponents");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryComponent_CategoryId",
                table: "CategoryComponents",
                newName: "IX_CategoryComponents_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryComponents",
                table: "CategoryComponents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryComponents_Categories_CategoryId",
                table: "CategoryComponents",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryComponents_Categories_CategoryId",
                table: "CategoryComponents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryComponents",
                table: "CategoryComponents");

            migrationBuilder.RenameTable(
                name: "CategoryComponents",
                newName: "CategoryComponent");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryComponents_CategoryId",
                table: "CategoryComponent",
                newName: "IX_CategoryComponent_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryComponent",
                table: "CategoryComponent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryComponent_Categories_CategoryId",
                table: "CategoryComponent",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
