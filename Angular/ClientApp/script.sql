USE [S.O.D_BD]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssetsType]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssetsType](
	[Id_AssetsType] [int] IDENTITY(1,1) NOT NULL,
	[AssetsTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AssetsType] PRIMARY KEY CLUSTERED 
(
	[Id_AssetsType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CharacteristicsDevices]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CharacteristicsDevices](
	[Id_CharacteristicsDevices] [int] IDENTITY(1,1) NOT NULL,
	[Mark] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[SerialNumber] [nvarchar](50) NOT NULL,
	[Product_ID] [nvarchar](50) NOT NULL,
	[MAC] [nvarchar](50) NOT NULL,
	[IP] [nvarchar](50) NOT NULL,
	[SO] [nvarchar](100) NOT NULL,
	[RAM] [nvarchar](100) NOT NULL,
	[Processor] [nvarchar](100) NOT NULL,
	[Storage] [nvarchar](10) NOT NULL,
	[StorageType] [nvarchar](50) NOT NULL,
	[TarGraphicCard] [bit] NOT NULL,
	[Screen] [nvarchar](100) NOT NULL,
	[Observartions] [nvarchar](max) NULL,
 CONSTRAINT [PK_CharacteristicsDevices] PRIMARY KEY CLUSTERED 
(
	[Id_CharacteristicsDevices] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CV_Devices]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CV_Devices](
	[Id_CV_Devices] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Id_User] [int] NOT NULL,
	[UsersId_Users] [int] NULL,
	[Id_Departments] [int] NOT NULL,
	[DepartmentsId_Departments] [int] NULL,
	[Id_Positions] [int] NOT NULL,
	[PositionsId_Positions] [int] NULL,
	[Id_TypesDevices] [int] NOT NULL,
	[DevicesTypesId_DevicesTypes] [int] NULL,
	[NameDevice] [nvarchar](50) NOT NULL,
	[Id_Characteristics] [int] NOT NULL,
	[CharacteristicsDevicesId_CharacteristicsDevices] [int] NULL,
	[Id_DevicesAccessories] [int] NOT NULL,
	[Devices_AccessoriesId_CV_Devices] [int] NULL,
	[Id_DevicesMantenaince] [int] NOT NULL,
	[Devices_MantenainceId_DevicesMantenaince] [int] NULL,
	[Observartions] [nvarchar](max) NULL,
 CONSTRAINT [PK_CV_Devices] PRIMARY KEY CLUSTERED 
(
	[Id_CV_Devices] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id_Departments] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentsName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id_Departments] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devices_Accessories]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices_Accessories](
	[Id_CV_Devices] [int] IDENTITY(1,1) NOT NULL,
	[StatusDevices] [bit] NOT NULL,
 CONSTRAINT [PK_Devices_Accessories] PRIMARY KEY CLUSTERED 
(
	[Id_CV_Devices] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devices_Mantenaince]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices_Mantenaince](
	[Id_DevicesMantenaince] [int] IDENTITY(1,1) NOT NULL,
	[Description_Mantenaince] [nvarchar](max) NOT NULL,
	[Status_Mantenaince] [bit] NOT NULL,
	[Date_Mantenaince] [datetime2](7) NOT NULL,
	[Observartions_Mantenaince] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Devices_Mantenaince] PRIMARY KEY CLUSTERED 
(
	[Id_DevicesMantenaince] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DevicesTypes]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DevicesTypes](
	[Id_DevicesTypes] [int] IDENTITY(1,1) NOT NULL,
	[DevicesTypesName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DevicesTypes] PRIMARY KEY CLUSTERED 
(
	[Id_DevicesTypes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipments]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipments](
	[Id_Equipment] [int] IDENTITY(1,1) NOT NULL,
	[Equipement_Internal_Code] [nvarchar](30) NOT NULL,
	[Equipment_Name] [nvarchar](50) NOT NULL,
	[Equipment_TradeMark] [nvarchar](50) NOT NULL,
	[Equipment_Model] [nvarchar](20) NOT NULL,
	[Equipment_SN] [nvarchar](30) NOT NULL,
	[Equipment_Observations] [nvarchar](max) NOT NULL,
	[Equipment_Status] [bit] NOT NULL,
	[Equipment_Warranty] [nvarchar](max) NOT NULL,
	[EquipmentTypeId_EquipmentType] [int] NULL,
	[Id_EquipmentsType] [int] NOT NULL,
 CONSTRAINT [PK_Equipments] PRIMARY KEY CLUSTERED 
(
	[Id_Equipment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentTypes]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipmentTypes](
	[Id_EquipmentType] [int] IDENTITY(1,1) NOT NULL,
	[EquipmentTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EquipmentTypes] PRIMARY KEY CLUSTERED 
(
	[Id_EquipmentType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fixed_Assets]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fixed_Assets](
	[Id_Fixed_Assests] [int] IDENTITY(1,1) NOT NULL,
	[FixedAssetsName] [nvarchar](50) NOT NULL,
	[AssetsCharacteristicsMark] [nvarchar](50) NOT NULL,
	[AssetsCharacteristicsModel] [nvarchar](50) NULL,
	[AssetsCharacteristicsSerialNumber] [nvarchar](50) NULL,
	[AssetsCharacteristicsProductId] [nvarchar](50) NULL,
	[AssetsCharacteristicsMemoryRam] [nvarchar](50) NULL,
	[AssetsCharacteristicsStorage] [nvarchar](50) NULL,
	[AssetsCharacteristicsStorageType] [nvarchar](50) NULL,
	[AssetsCharacteristics_Others] [nvarchar](max) NOT NULL,
	[Id_AssestsType] [int] NOT NULL,
	[AssetsTypeId_AssetsType] [int] NULL,
 CONSTRAINT [PK_Fixed_Assets] PRIMARY KEY CLUSTERED 
(
	[Id_Fixed_Assests] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lendings]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lendings](
	[Id_Lending] [int] IDENTITY(1,1) NOT NULL,
	[DateLending] [datetime2](7) NOT NULL,
	[CodeEquipment] [nvarchar](20) NOT NULL,
	[DescriptionMantenaince] [nvarchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[EquipmentId] [int] NOT NULL,
	[UbicationId] [int] NOT NULL,
	[UsersId_Users] [int] NULL,
 CONSTRAINT [PK_Lendings] PRIMARY KEY CLUSTERED 
(
	[Id_Lending] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id_Logs] [int] IDENTITY(1,1) NOT NULL,
	[LogDescription] [nvarchar](max) NOT NULL,
	[UsersId_Users] [int] NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[Id_Logs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenainces]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenainces](
	[Id_Mantenaince] [int] IDENTITY(1,1) NOT NULL,
	[DateMantenaince] [datetime2](7) NOT NULL,
	[StratusMantenaince] [bit] NOT NULL,
	[CodeEquipment] [nvarchar](20) NOT NULL,
	[DescriptionMantenaince] [nvarchar](max) NOT NULL,
	[UsersId] [int] NOT NULL,
	[EquipmentId] [int] NOT NULL,
 CONSTRAINT [PK_Mantenainces] PRIMARY KEY CLUSTERED 
(
	[Id_Mantenaince] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id_Positions] [int] IDENTITY(1,1) NOT NULL,
	[UPositionsTypeName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Id_Positions] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[Id_Providers] [int] IDENTITY(1,1) NOT NULL,
	[Identification] [nvarchar](12) NOT NULL,
	[TypeIdentification] [nvarchar](3) NOT NULL,
	[ProviderName] [nvarchar](50) NOT NULL,
	[ProviderTypeId_ProviderType] [int] NULL,
	[Id_ProvidersType] [int] NOT NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[Id_Providers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProvidersType]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProvidersType](
	[Id_ProviderType] [int] IDENTITY(1,1) NOT NULL,
	[ProviderTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProvidersType] PRIMARY KEY CLUSTERED 
(
	[Id_ProviderType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases](
	[Id_Purchase] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseEvidence] [nvarchar](max) NOT NULL,
	[NumberInvoice] [nvarchar](50) NOT NULL,
	[PurchaseDescription] [nvarchar](max) NOT NULL,
	[EquipmentId] [int] NOT NULL,
	[ProvidersId] [int] NOT NULL,
 CONSTRAINT [PK_Purchases] PRIMARY KEY CLUSTERED 
(
	[Id_Purchase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ubications]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubications](
	[Id_Ubication] [int] IDENTITY(1,1) NOT NULL,
	[UbicationName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Ubications] PRIMARY KEY CLUSTERED 
(
	[Id_Ubication] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id_Users] [int] IDENTITY(1,1) NOT NULL,
	[N_Identification] [nvarchar](10) NOT NULL,
	[TypeDocument] [nvarchar](5) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](10) NULL,
	[UserPassword] [nvarchar](18) NULL,
	[Status] [bit] NOT NULL,
	[Id_UsersType] [int] NOT NULL,
	[UserTypeId_UsersType] [int] NULL,
	[DepartmentsId_Departments] [int] NULL,
	[PositionsId_Positions] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id_Users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersType]    Script Date: 08/08/2020 1:26:50 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersType](
	[Id_UsersType] [int] IDENTITY(1,1) NOT NULL,
	[UsersTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UsersType] PRIMARY KEY CLUSTERED 
(
	[Id_UsersType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Equipments] ADD  DEFAULT ((0)) FOR [Id_EquipmentsType]
GO
ALTER TABLE [dbo].[Providers] ADD  DEFAULT ((0)) FOR [Id_ProvidersType]
GO
ALTER TABLE [dbo].[CV_Devices]  WITH CHECK ADD  CONSTRAINT [FK_CV_Devices_CharacteristicsDevices_CharacteristicsDevicesId_CharacteristicsDevices] FOREIGN KEY([CharacteristicsDevicesId_CharacteristicsDevices])
REFERENCES [dbo].[CharacteristicsDevices] ([Id_CharacteristicsDevices])
GO
ALTER TABLE [dbo].[CV_Devices] CHECK CONSTRAINT [FK_CV_Devices_CharacteristicsDevices_CharacteristicsDevicesId_CharacteristicsDevices]
GO
ALTER TABLE [dbo].[CV_Devices]  WITH CHECK ADD  CONSTRAINT [FK_CV_Devices_Departments_DepartmentsId_Departments] FOREIGN KEY([DepartmentsId_Departments])
REFERENCES [dbo].[Departments] ([Id_Departments])
GO
ALTER TABLE [dbo].[CV_Devices] CHECK CONSTRAINT [FK_CV_Devices_Departments_DepartmentsId_Departments]
GO
ALTER TABLE [dbo].[CV_Devices]  WITH CHECK ADD  CONSTRAINT [FK_CV_Devices_Devices_Accessories_Devices_AccessoriesId_CV_Devices] FOREIGN KEY([Devices_AccessoriesId_CV_Devices])
REFERENCES [dbo].[Devices_Accessories] ([Id_CV_Devices])
GO
ALTER TABLE [dbo].[CV_Devices] CHECK CONSTRAINT [FK_CV_Devices_Devices_Accessories_Devices_AccessoriesId_CV_Devices]
GO
ALTER TABLE [dbo].[CV_Devices]  WITH CHECK ADD  CONSTRAINT [FK_CV_Devices_Devices_Mantenaince_Devices_MantenainceId_DevicesMantenaince] FOREIGN KEY([Devices_MantenainceId_DevicesMantenaince])
REFERENCES [dbo].[Devices_Mantenaince] ([Id_DevicesMantenaince])
GO
ALTER TABLE [dbo].[CV_Devices] CHECK CONSTRAINT [FK_CV_Devices_Devices_Mantenaince_Devices_MantenainceId_DevicesMantenaince]
GO
ALTER TABLE [dbo].[CV_Devices]  WITH CHECK ADD  CONSTRAINT [FK_CV_Devices_DevicesTypes_DevicesTypesId_DevicesTypes] FOREIGN KEY([DevicesTypesId_DevicesTypes])
REFERENCES [dbo].[DevicesTypes] ([Id_DevicesTypes])
GO
ALTER TABLE [dbo].[CV_Devices] CHECK CONSTRAINT [FK_CV_Devices_DevicesTypes_DevicesTypesId_DevicesTypes]
GO
ALTER TABLE [dbo].[CV_Devices]  WITH CHECK ADD  CONSTRAINT [FK_CV_Devices_Positions_PositionsId_Positions] FOREIGN KEY([PositionsId_Positions])
REFERENCES [dbo].[Positions] ([Id_Positions])
GO
ALTER TABLE [dbo].[CV_Devices] CHECK CONSTRAINT [FK_CV_Devices_Positions_PositionsId_Positions]
GO
ALTER TABLE [dbo].[CV_Devices]  WITH CHECK ADD  CONSTRAINT [FK_CV_Devices_Users_UsersId_Users] FOREIGN KEY([UsersId_Users])
REFERENCES [dbo].[Users] ([Id_Users])
GO
ALTER TABLE [dbo].[CV_Devices] CHECK CONSTRAINT [FK_CV_Devices_Users_UsersId_Users]
GO
ALTER TABLE [dbo].[Equipments]  WITH CHECK ADD  CONSTRAINT [FK_Equipments_EquipmentTypes_EquipmentTypeId_EquipmentType] FOREIGN KEY([EquipmentTypeId_EquipmentType])
REFERENCES [dbo].[EquipmentTypes] ([Id_EquipmentType])
GO
ALTER TABLE [dbo].[Equipments] CHECK CONSTRAINT [FK_Equipments_EquipmentTypes_EquipmentTypeId_EquipmentType]
GO
ALTER TABLE [dbo].[Fixed_Assets]  WITH CHECK ADD  CONSTRAINT [FK_Fixed_Assets_AssetsType_AssetsTypeId_AssetsType] FOREIGN KEY([AssetsTypeId_AssetsType])
REFERENCES [dbo].[AssetsType] ([Id_AssetsType])
GO
ALTER TABLE [dbo].[Fixed_Assets] CHECK CONSTRAINT [FK_Fixed_Assets_AssetsType_AssetsTypeId_AssetsType]
GO
ALTER TABLE [dbo].[Lendings]  WITH CHECK ADD  CONSTRAINT [FK_Lendings_Equipments_EquipmentId] FOREIGN KEY([EquipmentId])
REFERENCES [dbo].[Equipments] ([Id_Equipment])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lendings] CHECK CONSTRAINT [FK_Lendings_Equipments_EquipmentId]
GO
ALTER TABLE [dbo].[Lendings]  WITH CHECK ADD  CONSTRAINT [FK_Lendings_Ubications_UbicationId] FOREIGN KEY([UbicationId])
REFERENCES [dbo].[Ubications] ([Id_Ubication])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lendings] CHECK CONSTRAINT [FK_Lendings_Ubications_UbicationId]
GO
ALTER TABLE [dbo].[Lendings]  WITH CHECK ADD  CONSTRAINT [FK_Lendings_Users_UsersId_Users] FOREIGN KEY([UsersId_Users])
REFERENCES [dbo].[Users] ([Id_Users])
GO
ALTER TABLE [dbo].[Lendings] CHECK CONSTRAINT [FK_Lendings_Users_UsersId_Users]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Users_UsersId_Users] FOREIGN KEY([UsersId_Users])
REFERENCES [dbo].[Users] ([Id_Users])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Users_UsersId_Users]
GO
ALTER TABLE [dbo].[Mantenainces]  WITH CHECK ADD  CONSTRAINT [FK_Mantenainces_Equipments_EquipmentId] FOREIGN KEY([EquipmentId])
REFERENCES [dbo].[Equipments] ([Id_Equipment])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mantenainces] CHECK CONSTRAINT [FK_Mantenainces_Equipments_EquipmentId]
GO
ALTER TABLE [dbo].[Mantenainces]  WITH CHECK ADD  CONSTRAINT [FK_Mantenainces_Users_UsersId] FOREIGN KEY([UsersId])
REFERENCES [dbo].[Users] ([Id_Users])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mantenainces] CHECK CONSTRAINT [FK_Mantenainces_Users_UsersId]
GO
ALTER TABLE [dbo].[Providers]  WITH CHECK ADD  CONSTRAINT [FK_Providers_ProvidersType_ProviderTypeId_ProviderType] FOREIGN KEY([ProviderTypeId_ProviderType])
REFERENCES [dbo].[ProvidersType] ([Id_ProviderType])
GO
ALTER TABLE [dbo].[Providers] CHECK CONSTRAINT [FK_Providers_ProvidersType_ProviderTypeId_ProviderType]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Equipments_EquipmentId] FOREIGN KEY([EquipmentId])
REFERENCES [dbo].[Equipments] ([Id_Equipment])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Equipments_EquipmentId]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Providers_ProvidersId] FOREIGN KEY([ProvidersId])
REFERENCES [dbo].[Providers] ([Id_Providers])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Providers_ProvidersId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Departments_DepartmentsId_Departments] FOREIGN KEY([DepartmentsId_Departments])
REFERENCES [dbo].[Departments] ([Id_Departments])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Departments_DepartmentsId_Departments]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Positions_PositionsId_Positions] FOREIGN KEY([PositionsId_Positions])
REFERENCES [dbo].[Positions] ([Id_Positions])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Positions_PositionsId_Positions]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersType_UserTypeId_UsersType] FOREIGN KEY([UserTypeId_UsersType])
REFERENCES [dbo].[UsersType] ([Id_UsersType])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UsersType_UserTypeId_UsersType]
GO
