using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SokolDev.SQLiteAccess.Migrations
{
    public partial class AddIndexForBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogId",
                table: "Blogs",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogId",
                table: "Blogs");
        }
    }
}
