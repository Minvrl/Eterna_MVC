using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Eterna.Migrations
{
    public partial class ForgotThesetoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Members");
        }
    }
}
