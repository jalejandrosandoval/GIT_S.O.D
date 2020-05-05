using Microsoft.EntityFrameworkCore.Migrations;

namespace AppWeb_MVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id_Equipment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_Code = table.Column<string>(maxLength: 100, nullable: false),
                    Equipement_Internal_Code = table.Column<string>(maxLength: 100, nullable: false),
                    Equipment_Name = table.Column<string>(maxLength: 100, nullable: false),
                    Equipment_TradeMark = table.Column<string>(maxLength: 100, nullable: false),
                    Equipment_SN = table.Column<string>(maxLength: 50, nullable: false),
                    Equipment_Type = table.Column<string>(nullable: false),
                    Equipment_Observations = table.Column<string>(nullable: true),
                    Equipment_Warranty = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id_Equipment);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id_Providers = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<string>(maxLength: 10, nullable: false),
                    TypeIdentification = table.Column<string>(maxLength: 5, nullable: false),
                    ProviderName = table.Column<string>(maxLength: 50, nullable: false),
                    PType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id_Providers);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_Users = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_Identification = table.Column<string>(maxLength: 10, nullable: false),
                    TypeDocument = table.Column<string>(maxLength: 3, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    UserEmail = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    UserPassword = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_Users);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
