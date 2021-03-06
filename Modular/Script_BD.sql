USE [S.O.D_BD]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21/05/2020 2:22:32 p. m. ******/
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
/****** Object:  Table [dbo].[Equipments]    Script Date: 21/05/2020 2:22:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipments](
	[Id_Equipment] [int] IDENTITY(1,1) NOT NULL,
	[Equipement_Internal_Code] [nvarchar](20) NOT NULL,
	[Equipment_Name] [nvarchar](50) NOT NULL,
	[Equipment_TradeMark] [nvarchar](50) NOT NULL,
	[Equipment_Model] [nvarchar](20) NOT NULL,
	[Equipment_SN] [nvarchar](30) NOT NULL,
	[Equipment_Observations] [nvarchar](max) NOT NULL,
	[Equipment_Status] [bit] NOT NULL,
	[Equipment_Warranty] [nvarchar](max) NOT NULL,
	[EquipmentTypeId_EquipmentType] [int] NULL,
 CONSTRAINT [PK_Equipments] PRIMARY KEY CLUSTERED 
(
	[Id_Equipment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipmentTypes]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
/****** Object:  Table [dbo].[Lendings]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
/****** Object:  Table [dbo].[Logs]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
/****** Object:  Table [dbo].[Mantenainces]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
/****** Object:  Table [dbo].[Providers]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[Id_Providers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProvidersType]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
/****** Object:  Table [dbo].[Purchases]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
/****** Object:  Table [dbo].[Ubications]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
	[UserTypeId_UsersType] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id_Users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersType]    Script Date: 21/05/2020 2:22:33 p. m. ******/
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
ALTER TABLE [dbo].[Equipments]  WITH CHECK ADD  CONSTRAINT [FK_Equipments_EquipmentTypes_EquipmentTypeId_EquipmentType] FOREIGN KEY([EquipmentTypeId_EquipmentType])
REFERENCES [dbo].[EquipmentTypes] ([Id_EquipmentType])
GO
ALTER TABLE [dbo].[Equipments] CHECK CONSTRAINT [FK_Equipments_EquipmentTypes_EquipmentTypeId_EquipmentType]
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
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UsersType_UserTypeId_UsersType] FOREIGN KEY([UserTypeId_UsersType])
REFERENCES [dbo].[UsersType] ([Id_UsersType])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UsersType_UserTypeId_UsersType]
GO
