﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bussiness_Logic.Models.AssetsType", b =>
                {
                    b.Property<int>("Id_AssetsType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetsTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_AssetsType");

                    b.ToTable("AssetsType");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.CV_Devices", b =>
                {
                    b.Property<int>("Id_CV_Devices")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CharacteristicsDevicesId_CharacteristicsDevices")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentsId_Departments")
                        .HasColumnType("int");

                    b.Property<int?>("DevicesTypesId_DevicesTypes")
                        .HasColumnType("int");

                    b.Property<int?>("Devices_AccessoriesId_CV_Devices")
                        .HasColumnType("int");

                    b.Property<int?>("Devices_MantenainceId_DevicesMantenaince")
                        .HasColumnType("int");

                    b.Property<int>("Id_Characteristics")
                        .HasColumnType("int");

                    b.Property<int>("Id_Departments")
                        .HasColumnType("int");

                    b.Property<int>("Id_DevicesAccessories")
                        .HasColumnType("int");

                    b.Property<int>("Id_DevicesMantenaince")
                        .HasColumnType("int");

                    b.Property<int>("Id_Positions")
                        .HasColumnType("int");

                    b.Property<int>("Id_TypesDevices")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("NameDevice")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Observartions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionsId_Positions")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId_Users")
                        .HasColumnType("int");

                    b.HasKey("Id_CV_Devices");

                    b.HasIndex("CharacteristicsDevicesId_CharacteristicsDevices");

                    b.HasIndex("DepartmentsId_Departments");

                    b.HasIndex("DevicesTypesId_DevicesTypes");

                    b.HasIndex("Devices_AccessoriesId_CV_Devices");

                    b.HasIndex("Devices_MantenainceId_DevicesMantenaince");

                    b.HasIndex("PositionsId_Positions");

                    b.HasIndex("UsersId_Users");

                    b.ToTable("CV_Devices");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.CharacteristicsDevices", b =>
                {
                    b.Property<int>("Id_CharacteristicsDevices")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MAC")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Observartions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Product_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SO")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Screen")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("StorageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("TarGraphicCard")
                        .HasColumnType("bit");

                    b.HasKey("Id_CharacteristicsDevices");

                    b.ToTable("CharacteristicsDevices");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Departments", b =>
                {
                    b.Property<int>("Id_Departments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_Departments");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.DevicesTypes", b =>
                {
                    b.Property<int>("Id_DevicesTypes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DevicesTypesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_DevicesTypes");

                    b.ToTable("DevicesTypes");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Devices_Accessories", b =>
                {
                    b.Property<int>("Id_CV_Devices")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("StatusDevices")
                        .HasColumnType("bit");

                    b.HasKey("Id_CV_Devices");

                    b.ToTable("Devices_Accessories");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Devices_Mantenaince", b =>
                {
                    b.Property<int>("Id_DevicesMantenaince")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Mantenaince")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description_Mantenaince")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observartions_Mantenaince")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status_Mantenaince")
                        .HasColumnType("bit");

                    b.HasKey("Id_DevicesMantenaince");

                    b.ToTable("Devices_Mantenaince");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Equipment", b =>
                {
                    b.Property<int>("Id_Equipment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Equipement_Internal_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("EquipmentTypeId_EquipmentType")
                        .HasColumnType("int");

                    b.Property<string>("Equipment_Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Equipment_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Equipment_Observations")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<string>("Equipment_SN")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("Equipment_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Equipment_TradeMark")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Equipment_Warranty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_EquipmentsType")
                        .HasColumnType("int");

                    b.HasKey("Id_Equipment");

                    b.HasIndex("EquipmentTypeId_EquipmentType");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.EquipmentType", b =>
                {
                    b.Property<int>("Id_EquipmentType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EquipmentTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_EquipmentType");

                    b.ToTable("EquipmentTypes");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Fixed_Assets", b =>
                {
                    b.Property<int>("Id_Fixed_Assests")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetsCharacteristicsMark")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AssetsCharacteristicsMemoryRam")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AssetsCharacteristicsModel")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AssetsCharacteristicsProductId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AssetsCharacteristicsSerialNumber")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AssetsCharacteristicsStorage")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AssetsCharacteristicsStorageType")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AssetsCharacteristics_Others")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.Property<int?>("AssetsTypeId_AssetsType")
                        .HasColumnType("int");

                    b.Property<string>("FixedAssetsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Id_AssestsType")
                        .HasColumnType("int");

                    b.HasKey("Id_Fixed_Assests");

                    b.HasIndex("AssetsTypeId_AssetsType");

                    b.ToTable("Fixed_Assets");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Lending", b =>
                {
                    b.Property<int>("Id_Lending")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeEquipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DateLending")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionMantenaince")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("UbicationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId_Users")
                        .HasColumnType("int");

                    b.HasKey("Id_Lending");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("UbicationId");

                    b.HasIndex("UsersId_Users");

                    b.ToTable("Lendings");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Logs", b =>
                {
                    b.Property<int>("Id_Logs")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LogDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsersId_Users")
                        .HasColumnType("int");

                    b.HasKey("Id_Logs");

                    b.HasIndex("UsersId_Users");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Mantenaince", b =>
                {
                    b.Property<int>("Id_Mantenaince")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeEquipment")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DateMantenaince")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionMantenaince")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<bool>("StratusMantenaince")
                        .HasColumnType("bit");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id_Mantenaince");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("UsersId");

                    b.ToTable("Mantenainces");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Positions", b =>
                {
                    b.Property<int>("Id_Positions")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UPositionsTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id_Positions");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.ProviderType", b =>
                {
                    b.Property<int>("Id_ProviderType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProviderTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_ProviderType");

                    b.ToTable("ProvidersType");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Providers", b =>
                {
                    b.Property<int>("Id_Providers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_ProvidersType")
                        .HasColumnType("int");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ProviderTypeId_ProviderType")
                        .HasColumnType("int");

                    b.Property<string>("TypeIdentification")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.HasKey("Id_Providers");

                    b.HasIndex("ProviderTypeId_ProviderType");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Purchase", b =>
                {
                    b.Property<int>("Id_Purchase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<string>("NumberInvoice")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ProvidersId")
                        .HasColumnType("int");

                    b.Property<string>("PurchaseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseEvidence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Purchase");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("ProvidersId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Ubication", b =>
                {
                    b.Property<int>("Id_Ubication")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UbicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id_Ubication");

                    b.ToTable("Ubications");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Users", b =>
                {
                    b.Property<int>("Id_Users")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentsId_Departments")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Id_UsersType")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("N_Identification")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("PositionsId_Positions")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TypeDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(18)")
                        .HasMaxLength(18);

                    b.Property<int?>("UserTypeId_UsersType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id_Users");

                    b.HasIndex("DepartmentsId_Departments");

                    b.HasIndex("PositionsId_Positions");

                    b.HasIndex("UserTypeId_UsersType");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.UsersType", b =>
                {
                    b.Property<int>("Id_UsersType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UsersTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id_UsersType");

                    b.ToTable("UsersType");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.CV_Devices", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.CharacteristicsDevices", "CharacteristicsDevices")
                        .WithMany("CV_Devices")
                        .HasForeignKey("CharacteristicsDevicesId_CharacteristicsDevices");

                    b.HasOne("Bussiness_Logic.Models.Departments", "Departments")
                        .WithMany("CV_Devices")
                        .HasForeignKey("DepartmentsId_Departments");

                    b.HasOne("Bussiness_Logic.Models.DevicesTypes", "DevicesTypes")
                        .WithMany("CV_Devices")
                        .HasForeignKey("DevicesTypesId_DevicesTypes");

                    b.HasOne("Bussiness_Logic.Models.Devices_Accessories", "Devices_Accessories")
                        .WithMany("CV_Devices")
                        .HasForeignKey("Devices_AccessoriesId_CV_Devices");

                    b.HasOne("Bussiness_Logic.Models.Devices_Mantenaince", "Devices_Mantenaince")
                        .WithMany("CV_Devices")
                        .HasForeignKey("Devices_MantenainceId_DevicesMantenaince");

                    b.HasOne("Bussiness_Logic.Models.Positions", "Positions")
                        .WithMany("CV_Devices")
                        .HasForeignKey("PositionsId_Positions");

                    b.HasOne("Bussiness_Logic.Models.Users", "Users")
                        .WithMany("CV_Devices")
                        .HasForeignKey("UsersId_Users");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Equipment", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.EquipmentType", "EquipmentType")
                        .WithMany("Equipments")
                        .HasForeignKey("EquipmentTypeId_EquipmentType");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Fixed_Assets", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.AssetsType", "AssetsType")
                        .WithMany("Fixed_Assets")
                        .HasForeignKey("AssetsTypeId_AssetsType");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Lending", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.Equipment", "Equipments")
                        .WithMany("Lendings")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bussiness_Logic.Models.Ubication", "Ubication")
                        .WithMany()
                        .HasForeignKey("UbicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bussiness_Logic.Models.Users", "Users")
                        .WithMany("Lendings")
                        .HasForeignKey("UsersId_Users");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Logs", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId_Users");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Mantenaince", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.Equipment", "Equipments")
                        .WithMany("Mantenainces")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bussiness_Logic.Models.Users", "Users")
                        .WithMany("Mantenainces")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Providers", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.ProviderType", "ProviderType")
                        .WithMany("Providers")
                        .HasForeignKey("ProviderTypeId_ProviderType");
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Purchase", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.Equipment", "Equipments")
                        .WithMany("Purchases")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bussiness_Logic.Models.Providers", "Providers")
                        .WithMany("Purchases")
                        .HasForeignKey("ProvidersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bussiness_Logic.Models.Users", b =>
                {
                    b.HasOne("Bussiness_Logic.Models.Departments", null)
                        .WithMany("Users")
                        .HasForeignKey("DepartmentsId_Departments");

                    b.HasOne("Bussiness_Logic.Models.Positions", null)
                        .WithMany("Users")
                        .HasForeignKey("PositionsId_Positions");

                    b.HasOne("Bussiness_Logic.Models.UsersType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId_UsersType");
                });
#pragma warning restore 612, 618
        }
    }
}
