using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class initial_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentTypes",
                columns: table => new
                {
                    Id_EquipmentType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentTypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypes", x => x.Id_EquipmentType);
                });

            migrationBuilder.CreateTable(
                name: "ProvidersType",
                columns: table => new
                {
                    Id_ProviderType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderTypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidersType", x => x.Id_ProviderType);
                });

            migrationBuilder.CreateTable(
                name: "Ubications",
                columns: table => new
                {
                    Id_Ubication = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UbicationName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubications", x => x.Id_Ubication);
                });

            migrationBuilder.CreateTable(
                name: "UsersType",
                columns: table => new
                {
                    Id_UsersType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersTypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersType", x => x.Id_UsersType);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id_Equipment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipement_Internal_Code = table.Column<string>(maxLength: 20, nullable: false),
                    Equipment_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Equipment_TradeMark = table.Column<string>(maxLength: 50, nullable: false),
                    Equipment_Model = table.Column<string>(maxLength: 20, nullable: false),
                    Equipment_SN = table.Column<string>(maxLength: 30, nullable: false),
                    Equipment_Observations = table.Column<string>(maxLength: 5000, nullable: false),
                    Equipment_Status = table.Column<bool>(nullable: false),
                    Equipment_Warranty = table.Column<string>(nullable: false),
                    EquipmentTypeId_EquipmentType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id_Equipment);
                    table.ForeignKey(
                        name: "FK_Equipments_EquipmentTypes_EquipmentTypeId_EquipmentType",
                        column: x => x.EquipmentTypeId_EquipmentType,
                        principalTable: "EquipmentTypes",
                        principalColumn: "Id_EquipmentType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id_Providers = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<string>(maxLength: 12, nullable: false),
                    TypeIdentification = table.Column<string>(maxLength: 3, nullable: false),
                    ProviderName = table.Column<string>(maxLength: 50, nullable: false),
                    ProviderTypeId_ProviderType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id_Providers);
                    table.ForeignKey(
                        name: "FK_Providers_ProvidersType_ProviderTypeId_ProviderType",
                        column: x => x.ProviderTypeId_ProviderType,
                        principalTable: "ProvidersType",
                        principalColumn: "Id_ProviderType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_Users = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    N_Identification = table.Column<string>(maxLength: 10, nullable: false),
                    TypeDocument = table.Column<string>(maxLength: 5, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(maxLength: 10, nullable: true),
                    UserPassword = table.Column<string>(maxLength: 18, nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    UserTypeId_UsersType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_Users);
                    table.ForeignKey(
                        name: "FK_Users_UsersType_UserTypeId_UsersType",
                        column: x => x.UserTypeId_UsersType,
                        principalTable: "UsersType",
                        principalColumn: "Id_UsersType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id_Purchase = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseEvidence = table.Column<string>(nullable: false),
                    NumberInvoice = table.Column<string>(maxLength: 50, nullable: false),
                    PurchaseDescription = table.Column<string>(nullable: false),
                    EquipmentId = table.Column<int>(nullable: false),
                    ProvidersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id_Purchase);
                    table.ForeignKey(
                        name: "FK_Purchases_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id_Equipment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_Providers_ProvidersId",
                        column: x => x.ProvidersId,
                        principalTable: "Providers",
                        principalColumn: "Id_Providers",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lendings",
                columns: table => new
                {
                    Id_Lending = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateLending = table.Column<DateTime>(nullable: false),
                    CodeEquipment = table.Column<string>(maxLength: 20, nullable: false),
                    DescriptionMantenaince = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    EquipmentId = table.Column<int>(nullable: false),
                    UbicationId = table.Column<int>(nullable: false),
                    UsersId_Users = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lendings", x => x.Id_Lending);
                    table.ForeignKey(
                        name: "FK_Lendings_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id_Equipment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lendings_Ubications_UbicationId",
                        column: x => x.UbicationId,
                        principalTable: "Ubications",
                        principalColumn: "Id_Ubication",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lendings_Users_UsersId_Users",
                        column: x => x.UsersId_Users,
                        principalTable: "Users",
                        principalColumn: "Id_Users",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id_Logs = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDescription = table.Column<string>(nullable: false),
                    UsersId_Users = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id_Logs);
                    table.ForeignKey(
                        name: "FK_Logs_Users_UsersId_Users",
                        column: x => x.UsersId_Users,
                        principalTable: "Users",
                        principalColumn: "Id_Users",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mantenainces",
                columns: table => new
                {
                    Id_Mantenaince = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateMantenaince = table.Column<DateTime>(nullable: false),
                    StratusMantenaince = table.Column<bool>(nullable: false),
                    CodeEquipment = table.Column<string>(maxLength: 20, nullable: false),
                    DescriptionMantenaince = table.Column<string>(nullable: false),
                    UsersId = table.Column<int>(nullable: false),
                    EquipmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenainces", x => x.Id_Mantenaince);
                    table.ForeignKey(
                        name: "FK_Mantenainces_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id_Equipment",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mantenainces_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id_Users",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_EquipmentTypeId_EquipmentType",
                table: "Equipments",
                column: "EquipmentTypeId_EquipmentType");

            migrationBuilder.CreateIndex(
                name: "IX_Lendings_EquipmentId",
                table: "Lendings",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lendings_UbicationId",
                table: "Lendings",
                column: "UbicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Lendings_UsersId_Users",
                table: "Lendings",
                column: "UsersId_Users");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UsersId_Users",
                table: "Logs",
                column: "UsersId_Users");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenainces_EquipmentId",
                table: "Mantenainces",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenainces_UsersId",
                table: "Mantenainces",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_ProviderTypeId_ProviderType",
                table: "Providers",
                column: "ProviderTypeId_ProviderType");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_EquipmentId",
                table: "Purchases",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_ProvidersId",
                table: "Purchases",
                column: "ProvidersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId_UsersType",
                table: "Users",
                column: "UserTypeId_UsersType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lendings");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Mantenainces");

            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Ubications");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "UsersType");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropTable(
                name: "ProvidersType");
        }
    }
}
