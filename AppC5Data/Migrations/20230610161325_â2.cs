using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppC5Data.Migrations
{
    public partial class â2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnhDaidien",
                table: "SanPhams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnhDaidien",
                table: "SanPhams");
        }
    }
}
