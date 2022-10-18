using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SokolDev.SQLiteAccess.Migrations
{
    public partial class DeleteAuthorAlias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Author");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Author",
                type: "TEXT",
                nullable: true);
        }
    }
}
