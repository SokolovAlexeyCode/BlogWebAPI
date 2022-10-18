using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SokolDev.SQLiteAccess.Migrations
{
    public partial class AddAuthorNickName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Author",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Author");
        }
    }
}
