using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class FixedAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetsType",
                columns: table => new
                {
                    Id_AssetsType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetsTypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetsType", x => x.Id_AssetsType);
                });

            migrationBuilder.CreateTable(
                name: "Fixed_Assets",
                columns: table => new
                {
                    Id_Fixed_Assests = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FixedAssetsName = table.Column<string>(maxLength: 50, nullable: false),
                    AssetsCharacteristicsMark = table.Column<string>(maxLength: 50, nullable: false),
                    AssetsCharacteristicsModel = table.Column<string>(maxLength: 50, nullable: true),
                    AssetsCharacteristicsSerialNumber = table.Column<string>(maxLength: 50, nullable: true),
                    AssetsCharacteristicsProductId = table.Column<string>(maxLength: 50, nullable: true),
                    AssetsCharacteristicsMemoryRam = table.Column<string>(maxLength: 50, nullable: true),
                    AssetsCharacteristicsStorage = table.Column<string>(maxLength: 50, nullable: true),
                    AssetsCharacteristicsStorageType = table.Column<string>(maxLength: 50, nullable: true),
                    AssetsCharacteristics_Others = table.Column<string>(maxLength: 5000, nullable: false),
                    Id_AssestsType = table.Column<int>(nullable: false),
                    AssetsTypeId_AssetsType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixed_Assets", x => x.Id_Fixed_Assests);
                    table.ForeignKey(
                        name: "FK_Fixed_Assets_AssetsType_AssetsTypeId_AssetsType",
                        column: x => x.AssetsTypeId_AssetsType,
                        principalTable: "AssetsType",
                        principalColumn: "Id_AssetsType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fixed_Assets_AssetsTypeId_AssetsType",
                table: "Fixed_Assets",
                column: "AssetsTypeId_AssetsType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fixed_Assets");

            migrationBuilder.DropTable(
                name: "AssetsType");
        }
    }
}
