using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Eterna.Migrations
{
    public partial class IsPrimaryBoolAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "ProjectImgs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "ProjectImgs");
        }
    }
}
