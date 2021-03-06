USE [PetMan_BD]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05/05/2020 4:15:54 p. m. ******/
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
/****** Object:  Table [dbo].[Equipments]    Script Date: 05/05/2020 4:15:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipments](
	[Id_Equipment] [int] IDENTITY(1,1) NOT NULL,
	[Equipment_Code] [nvarchar](100) NOT NULL,
	[Equipement_Internal_Code] [nvarchar](100) NOT NULL,
	[Equipment_Name] [nvarchar](100) NOT NULL,
	[Equipment_TradeMark] [nvarchar](100) NOT NULL,
	[Equipment_SN] [nvarchar](50) NOT NULL,
	[Equipment_Type] [nvarchar](max) NOT NULL,
	[Equipment_Observations] [nvarchar](max) NULL,
	[Equipment_Warranty] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Equipments] PRIMARY KEY CLUSTERED 
(
	[Id_Equipment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 05/05/2020 4:15:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[Id_Providers] [int] IDENTITY(1,1) NOT NULL,
	[Identification] [nvarchar](10) NOT NULL,
	[TypeIdentification] [nvarchar](5) NOT NULL,
	[ProviderName] [nvarchar](50) NOT NULL,
	[PType] [int] NOT NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[Id_Providers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05/05/2020 4:15:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id_Users] [int] IDENTITY(1,1) NOT NULL,
	[N_Identification] [nvarchar](10) NOT NULL,
	[TypeDocument] [nvarchar](3) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[UserEmail] [nvarchar](max) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[UserPassword] [nvarchar](max) NOT NULL,
	[Status] [int] NOT NULL,
	[UserType] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id_Users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
