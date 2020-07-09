using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_ProvidersType",
                table: "Providers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_EquipmentsType",
                table: "Equipments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_ProvidersType",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Id_EquipmentsType",
                table: "Equipments");
        }
    }
}
