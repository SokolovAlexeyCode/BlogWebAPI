using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SokolDev.SQLiteAccess.Migrations
{
    public partial class AddIndexForPostByPostId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "PostIdIndex",
                table: "Posts",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "PostIdIndex",
                table: "Posts");
        }
    }
}
