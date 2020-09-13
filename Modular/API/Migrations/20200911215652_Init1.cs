using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageRoute",
                table: "Configuration_Initial",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEnterprise",
                table: "Configuration_Initial",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PageName",
                table: "Configuration_Initial",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageRoute",
                table: "Configuration_Initial");

            migrationBuilder.DropColumn(
                name: "NameEnterprise",
                table: "Configuration_Initial");

            migrationBuilder.DropColumn(
                name: "PageName",
                table: "Configuration_Initial");
        }
    }
}
