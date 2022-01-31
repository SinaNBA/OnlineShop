using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class inisiate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductFiles_FileId",
                table: "ProductFiles",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFiles_ProductId",
                table: "ProductFiles",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFiles_Files_FileId",
                table: "ProductFiles",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFiles_Products_ProductId",
                table: "ProductFiles",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFiles_Files_FileId",
                table: "ProductFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFiles_Products_ProductId",
                table: "ProductFiles");

            migrationBuilder.DropIndex(
                name: "IX_ProductFiles_FileId",
                table: "ProductFiles");

            migrationBuilder.DropIndex(
                name: "IX_ProductFiles_ProductId",
                table: "ProductFiles");
        }
    }
}
