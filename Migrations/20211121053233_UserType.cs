using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeDigitalFactory.Services.Migrations
{
    public partial class UserType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAdmin",
                table: "Usuario",
                type: "bit",
                unicode: false,
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Usuario");
        }
    }
}
