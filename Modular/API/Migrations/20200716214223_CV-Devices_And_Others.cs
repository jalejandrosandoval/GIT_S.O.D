using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CVDevices_And_Others : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentsId_Departments",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionsId_Positions",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CharacteristicsDevices",
                columns: table => new
                {
                    Id_CharacteristicsDevices = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(maxLength: 50, nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    SerialNumber = table.Column<string>(maxLength: 50, nullable: false),
                    Product_ID = table.Column<string>(maxLength: 50, nullable: false),
                    MAC = table.Column<string>(maxLength: 50, nullable: false),
                    IP = table.Column<string>(maxLength: 50, nullable: false),
                    SO = table.Column<string>(maxLength: 100, nullable: false),
                    RAM = table.Column<string>(maxLength: 100, nullable: false),
                    Processor = table.Column<string>(maxLength: 100, nullable: false),
                    Storage = table.Column<string>(maxLength: 10, nullable: false),
                    StorageType = table.Column<string>(maxLength: 50, nullable: false),
                    TarGraphicCard = table.Column<bool>(nullable: false),
                    Screen = table.Column<string>(maxLength: 100, nullable: false),
                    Observartions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacteristicsDevices", x => x.Id_CharacteristicsDevices);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id_Departments = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentsName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id_Departments);
                });

            migrationBuilder.CreateTable(
                name: "Devices_Accessories",
                columns: table => new
                {
                    Id_CV_Devices = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDevices = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices_Accessories", x => x.Id_CV_Devices);
                });

            migrationBuilder.CreateTable(
                name: "Devices_Mantenaince",
                columns: table => new
                {
                    Id_DevicesMantenaince = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description_Mantenaince = table.Column<string>(nullable: false),
                    Status_Mantenaince = table.Column<bool>(nullable: false),
                    Date_Mantenaince = table.Column<DateTime>(nullable: false),
                    Observartions_Mantenaince = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices_Mantenaince", x => x.Id_DevicesMantenaince);
                });

            migrationBuilder.CreateTable(
                name: "DevicesTypes",
                columns: table => new
                {
                    Id_DevicesTypes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DevicesTypesName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicesTypes", x => x.Id_DevicesTypes);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id_Positions = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UPositionsTypeName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id_Positions);
                });

            migrationBuilder.CreateTable(
                name: "CV_Devices",
                columns: table => new
                {
                    Id_CV_Devices = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Id_User = table.Column<int>(nullable: false),
                    UsersId_Users = table.Column<int>(nullable: true),
                    Id_Departments = table.Column<int>(nullable: false),
                    DepartmentsId_Departments = table.Column<int>(nullable: true),
                    Id_Positions = table.Column<int>(nullable: false),
                    PositionsId_Positions = table.Column<int>(nullable: true),
                    Id_TypesDevices = table.Column<int>(nullable: false),
                    DevicesTypesId_DevicesTypes = table.Column<int>(nullable: true),
                    NameDevice = table.Column<string>(maxLength: 50, nullable: false),
                    Id_Characteristics = table.Column<int>(nullable: false),
                    CharacteristicsDevicesId_CharacteristicsDevices = table.Column<int>(nullable: true),
                    Id_DevicesAccessories = table.Column<int>(nullable: false),
                    Devices_AccessoriesId_CV_Devices = table.Column<int>(nullable: true),
                    Id_DevicesMantenaince = table.Column<int>(nullable: false),
                    Devices_MantenainceId_DevicesMantenaince = table.Column<int>(nullable: true),
                    Observartions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV_Devices", x => x.Id_CV_Devices);
                    table.ForeignKey(
                        name: "FK_CV_Devices_CharacteristicsDevices_CharacteristicsDevicesId_CharacteristicsDevices",
                        column: x => x.CharacteristicsDevicesId_CharacteristicsDevices,
                        principalTable: "CharacteristicsDevices",
                        principalColumn: "Id_CharacteristicsDevices",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CV_Devices_Departments_DepartmentsId_Departments",
                        column: x => x.DepartmentsId_Departments,
                        principalTable: "Departments",
                        principalColumn: "Id_Departments",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CV_Devices_DevicesTypes_DevicesTypesId_DevicesTypes",
                        column: x => x.DevicesTypesId_DevicesTypes,
                        principalTable: "DevicesTypes",
                        principalColumn: "Id_DevicesTypes",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CV_Devices_Devices_Accessories_Devices_AccessoriesId_CV_Devices",
                        column: x => x.Devices_AccessoriesId_CV_Devices,
                        principalTable: "Devices_Accessories",
                        principalColumn: "Id_CV_Devices",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CV_Devices_Devices_Mantenaince_Devices_MantenainceId_DevicesMantenaince",
                        column: x => x.Devices_MantenainceId_DevicesMantenaince,
                        principalTable: "Devices_Mantenaince",
                        principalColumn: "Id_DevicesMantenaince",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CV_Devices_Positions_PositionsId_Positions",
                        column: x => x.PositionsId_Positions,
                        principalTable: "Positions",
                        principalColumn: "Id_Positions",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CV_Devices_Users_UsersId_Users",
                        column: x => x.UsersId_Users,
                        principalTable: "Users",
                        principalColumn: "Id_Users",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentsId_Departments",
                table: "Users",
                column: "DepartmentsId_Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PositionsId_Positions",
                table: "Users",
                column: "PositionsId_Positions");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Devices_CharacteristicsDevicesId_CharacteristicsDevices",
                table: "CV_Devices",
                column: "CharacteristicsDevicesId_CharacteristicsDevices");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Devices_DepartmentsId_Departments",
                table: "CV_Devices",
                column: "DepartmentsId_Departments");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Devices_DevicesTypesId_DevicesTypes",
                table: "CV_Devices",
                column: "DevicesTypesId_DevicesTypes");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Devices_Devices_AccessoriesId_CV_Devices",
                table: "CV_Devices",
                column: "Devices_AccessoriesId_CV_Devices");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Devices_Devices_MantenainceId_DevicesMantenaince",
                table: "CV_Devices",
                column: "Devices_MantenainceId_DevicesMantenaince");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Devices_PositionsId_Positions",
                table: "CV_Devices",
                column: "PositionsId_Positions");

            migrationBuilder.CreateIndex(
                name: "IX_CV_Devices_UsersId_Users",
                table: "CV_Devices",
                column: "UsersId_Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentsId_Departments",
                table: "Users",
                column: "DepartmentsId_Departments",
                principalTable: "Departments",
                principalColumn: "Id_Departments",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Positions_PositionsId_Positions",
                table: "Users",
                column: "PositionsId_Positions",
                principalTable: "Positions",
                principalColumn: "Id_Positions",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentsId_Departments",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Positions_PositionsId_Positions",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CV_Devices");

            migrationBuilder.DropTable(
                name: "CharacteristicsDevices");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "DevicesTypes");

            migrationBuilder.DropTable(
                name: "Devices_Accessories");

            migrationBuilder.DropTable(
                name: "Devices_Mantenaince");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Users_DepartmentsId_Departments",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PositionsId_Positions",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DepartmentsId_Departments",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PositionsId_Positions",
                table: "Users");
        }
    }
}
