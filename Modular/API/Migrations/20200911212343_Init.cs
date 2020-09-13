using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AFP",
                columns: table => new
                {
                    Id_AFP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAFP = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AFP", x => x.Id_AFP);
                });

            migrationBuilder.CreateTable(
                name: "ARL",
                columns: table => new
                {
                    Id_ARL = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameARL = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARL", x => x.Id_ARL);
                });

            migrationBuilder.CreateTable(
                name: "CCF",
                columns: table => new
                {
                    Id_CCF = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCCF = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CCF", x => x.Id_CCF);
                });

            migrationBuilder.CreateTable(
                name: "Configuration_Initial",
                columns: table => new
                {
                    ID_ConfigInit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration_Initial", x => x.ID_ConfigInit);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsCols",
                columns: table => new
                {
                    Id_Departments = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentsName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsCols", x => x.Id_Departments);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsEmp",
                columns: table => new
                {
                    Id_Departments = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentsName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsEmp", x => x.Id_Departments);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    Id_EmployeeType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeTypeName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.Id_EmployeeType);
                });

            migrationBuilder.CreateTable(
                name: "EPS",
                columns: table => new
                {
                    Id_EPS = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEPS = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EPS", x => x.Id_EPS);
                });

            migrationBuilder.CreateTable(
                name: "Internal_Information",
                columns: table => new
                {
                    Id_Internal_Information = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internal_Information", x => x.Id_Internal_Information);
                });

            migrationBuilder.CreateTable(
                name: "ProvidersType",
                columns: table => new
                {
                    Id_ProviderType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidersTypeName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvidersType", x => x.Id_ProviderType);
                });

            migrationBuilder.CreateTable(
                name: "StatusCivil",
                columns: table => new
                {
                    Id_StatusCivil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_StatusCivil = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCivil", x => x.Id_StatusCivil);
                });

            migrationBuilder.CreateTable(
                name: "TypeCity",
                columns: table => new
                {
                    Id_TypeCity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_TypeCity = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCity", x => x.Id_TypeCity);
                });

            migrationBuilder.CreateTable(
                name: "TypeDocument",
                columns: table => new
                {
                    Id_TypeDocument = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_TypeDocument = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDocument", x => x.Id_TypeDocument);
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
                name: "CitiesCols",
                columns: table => new
                {
                    Id_CitiesCol = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(maxLength: 50, nullable: false),
                    Id_DepartmentsCols = table.Column<int>(nullable: false),
                    DepartmentsColId_Departments = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesCols", x => x.Id_CitiesCol);
                    table.ForeignKey(
                        name: "FK_CitiesCols_DepartmentsCols_DepartmentsColId_Departments",
                        column: x => x.DepartmentsColId_Departments,
                        principalTable: "DepartmentsCols",
                        principalColumn: "Id_Departments",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id_Employee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    IdTypeDocument = table.Column<int>(nullable: false),
                    TypeDocumentId_TypeDocument = table.Column<int>(nullable: false),
                    N_Document = table.Column<string>(maxLength: 10, nullable: false),
                    Date_Birth = table.Column<DateTime>(nullable: false),
                    Date_ExpeditionDoc = table.Column<DateTime>(nullable: false),
                    IdStatusCivil = table.Column<int>(nullable: false),
                    StatusCivilId_StatusCivil = table.Column<int>(nullable: false),
                    Gen = table.Column<string>(maxLength: 20, nullable: false),
                    MilitaryNotebook = table.Column<bool>(nullable: false),
                    NumberMilitaryote = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(nullable: false),
                    GroupBlood = table.Column<string>(maxLength: 2, nullable: false),
                    RH = table.Column<string>(maxLength: 2, nullable: false),
                    PersonsDepends = table.Column<string>(maxLength: 2, nullable: false),
                    Childrens = table.Column<string>(maxLength: 2, nullable: false),
                    Studies = table.Column<string>(maxLength: 50, nullable: false),
                    Studies_In = table.Column<string>(maxLength: 50, nullable: true),
                    IdEmployeeType = table.Column<int>(nullable: false),
                    EmployeeTypeId_EmployeeType = table.Column<int>(nullable: false),
                    IdInternalInformation = table.Column<int>(nullable: false),
                    Internal_InformationId_Internal_Information = table.Column<int>(nullable: false),
                    DepartmentsId_Departments = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id_Employee);
                    table.ForeignKey(
                        name: "FK_Employees_DepartmentsEmp_DepartmentsId_Departments",
                        column: x => x.DepartmentsId_Departments,
                        principalTable: "DepartmentsEmp",
                        principalColumn: "Id_Departments",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTypes_EmployeeTypeId_EmployeeType",
                        column: x => x.EmployeeTypeId_EmployeeType,
                        principalTable: "EmployeeTypes",
                        principalColumn: "Id_EmployeeType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Internal_Information_Internal_InformationId_Internal_Information",
                        column: x => x.Internal_InformationId_Internal_Information,
                        principalTable: "Internal_Information",
                        principalColumn: "Id_Internal_Information",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_StatusCivil_StatusCivilId_StatusCivil",
                        column: x => x.StatusCivilId_StatusCivil,
                        principalTable: "StatusCivil",
                        principalColumn: "Id_StatusCivil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_TypeDocument_TypeDocumentId_TypeDocument",
                        column: x => x.TypeDocumentId_TypeDocument,
                        principalTable: "TypeDocument",
                        principalColumn: "Id_TypeDocument",
                        onDelete: ReferentialAction.Cascade);
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
                    Id_UsersType = table.Column<int>(nullable: false),
                    UserTypeId_UsersType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_Users);
                    table.ForeignKey(
                        name: "FK_Users_UsersType_UserTypeId_UsersType",
                        column: x => x.UserTypeId_UsersType,
                        principalTable: "UsersType",
                        principalColumn: "Id_UsersType",
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
                    Status = table.Column<bool>(nullable: false),
                    NameContact = table.Column<string>(maxLength: 100, nullable: false),
                    EmailContact = table.Column<string>(nullable: false),
                    NumberPhone = table.Column<string>(maxLength: 50, nullable: false),
                    Id_ProvidersType = table.Column<int>(nullable: false),
                    ProvidersTypeId_ProviderType = table.Column<int>(nullable: true),
                    Adress = table.Column<string>(maxLength: 100, nullable: true),
                    IdCity = table.Column<int>(nullable: false),
                    CitiesColId_CitiesCol = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id_Providers);
                    table.ForeignKey(
                        name: "FK_Providers_CitiesCols_CitiesColId_CitiesCol",
                        column: x => x.CitiesColId_CitiesCol,
                        principalTable: "CitiesCols",
                        principalColumn: "Id_CitiesCol",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Providers_ProvidersType_ProvidersTypeId_ProviderType",
                        column: x => x.ProvidersTypeId_ProviderType,
                        principalTable: "ProvidersType",
                        principalColumn: "Id_ProviderType",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Afiliations",
                columns: table => new
                {
                    Id_Afiliations = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmployee = table.Column<int>(nullable: false),
                    EmployeesId_Employee = table.Column<int>(nullable: false),
                    IdEPS = table.Column<int>(nullable: false),
                    EPSId_EPS = table.Column<int>(nullable: false),
                    IdARL = table.Column<int>(nullable: false),
                    ARLId_ARL = table.Column<int>(nullable: false),
                    IdAFP = table.Column<int>(nullable: false),
                    AFPId_AFP = table.Column<int>(nullable: false),
                    IdCCF = table.Column<int>(nullable: false),
                    CCFId_CCF = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afiliations", x => x.Id_Afiliations);
                    table.ForeignKey(
                        name: "FK_Afiliations_AFP_AFPId_AFP",
                        column: x => x.AFPId_AFP,
                        principalTable: "AFP",
                        principalColumn: "Id_AFP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Afiliations_ARL_ARLId_ARL",
                        column: x => x.ARLId_ARL,
                        principalTable: "ARL",
                        principalColumn: "Id_ARL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Afiliations_CCF_CCFId_CCF",
                        column: x => x.CCFId_CCF,
                        principalTable: "CCF",
                        principalColumn: "Id_CCF",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Afiliations_EPS_EPSId_EPS",
                        column: x => x.EPSId_EPS,
                        principalTable: "EPS",
                        principalColumn: "Id_EPS",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Afiliations_Employees_EmployeesId_Employee",
                        column: x => x.EmployeesId_Employee,
                        principalTable: "Employees",
                        principalColumn: "Id_Employee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Cities",
                columns: table => new
                {
                    Id_Employee_Cities = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmployee = table.Column<int>(nullable: false),
                    EmployeeId_Employee = table.Column<int>(nullable: false),
                    IdCitiesCol = table.Column<int>(nullable: false),
                    CitiesColId_CitiesCol = table.Column<int>(nullable: false),
                    IdTypeCity = table.Column<int>(nullable: false),
                    TypeCityId_TypeCity = table.Column<int>(nullable: false),
                    Adress = table.Column<string>(maxLength: 50, nullable: false),
                    Neighborhood = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Cities", x => x.Id_Employee_Cities);
                    table.ForeignKey(
                        name: "FK_Employee_Cities_CitiesCols_CitiesColId_CitiesCol",
                        column: x => x.CitiesColId_CitiesCol,
                        principalTable: "CitiesCols",
                        principalColumn: "Id_CitiesCol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Cities_Employees_EmployeeId_Employee",
                        column: x => x.EmployeeId_Employee,
                        principalTable: "Employees",
                        principalColumn: "Id_Employee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Cities_TypeCity_TypeCityId_TypeCity",
                        column: x => x.TypeCityId_TypeCity,
                        principalTable: "TypeCity",
                        principalColumn: "Id_TypeCity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afiliations_AFPId_AFP",
                table: "Afiliations",
                column: "AFPId_AFP");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliations_ARLId_ARL",
                table: "Afiliations",
                column: "ARLId_ARL");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliations_CCFId_CCF",
                table: "Afiliations",
                column: "CCFId_CCF");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliations_EPSId_EPS",
                table: "Afiliations",
                column: "EPSId_EPS");

            migrationBuilder.CreateIndex(
                name: "IX_Afiliations_EmployeesId_Employee",
                table: "Afiliations",
                column: "EmployeesId_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_CitiesCols_DepartmentsColId_Departments",
                table: "CitiesCols",
                column: "DepartmentsColId_Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cities_CitiesColId_CitiesCol",
                table: "Employee_Cities",
                column: "CitiesColId_CitiesCol");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cities_EmployeeId_Employee",
                table: "Employee_Cities",
                column: "EmployeeId_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Cities_TypeCityId_TypeCity",
                table: "Employee_Cities",
                column: "TypeCityId_TypeCity");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentsId_Departments",
                table: "Employees",
                column: "DepartmentsId_Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypeId_EmployeeType",
                table: "Employees",
                column: "EmployeeTypeId_EmployeeType");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Internal_InformationId_Internal_Information",
                table: "Employees",
                column: "Internal_InformationId_Internal_Information");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StatusCivilId_StatusCivil",
                table: "Employees",
                column: "StatusCivilId_StatusCivil");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TypeDocumentId_TypeDocument",
                table: "Employees",
                column: "TypeDocumentId_TypeDocument");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_CitiesColId_CitiesCol",
                table: "Providers",
                column: "CitiesColId_CitiesCol");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_ProvidersTypeId_ProviderType",
                table: "Providers",
                column: "ProvidersTypeId_ProviderType");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId_UsersType",
                table: "Users",
                column: "UserTypeId_UsersType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afiliations");

            migrationBuilder.DropTable(
                name: "Configuration_Initial");

            migrationBuilder.DropTable(
                name: "Employee_Cities");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AFP");

            migrationBuilder.DropTable(
                name: "ARL");

            migrationBuilder.DropTable(
                name: "CCF");

            migrationBuilder.DropTable(
                name: "EPS");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "TypeCity");

            migrationBuilder.DropTable(
                name: "CitiesCols");

            migrationBuilder.DropTable(
                name: "ProvidersType");

            migrationBuilder.DropTable(
                name: "UsersType");

            migrationBuilder.DropTable(
                name: "DepartmentsEmp");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "Internal_Information");

            migrationBuilder.DropTable(
                name: "StatusCivil");

            migrationBuilder.DropTable(
                name: "TypeDocument");

            migrationBuilder.DropTable(
                name: "DepartmentsCols");
        }
    }
}
