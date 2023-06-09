USE [master]
GO
/****** Object:  Database [Ucak rezervasyonSon]    Script Date: 12.05.2023 23:32:13 ******/
CREATE DATABASE [Ucak rezervasyonSon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ucak rezervasyonSon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ucak rezervasyonSon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ucak rezervasyonSon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ucak rezervasyonSon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ucak rezervasyonSon] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ucak rezervasyonSon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ucak rezervasyonSon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET  MULTI_USER 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ucak rezervasyonSon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ucak rezervasyonSon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ucak rezervasyonSon] SET QUERY_STORE = OFF
GO
USE [Ucak rezervasyonSon]
GO
/****** Object:  User [sa]    Script Date: 12.05.2023 23:32:14 ******/
CREATE USER [sa] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [kullanıcı]    Script Date: 12.05.2023 23:32:14 ******/
CREATE USER [kullanıcı] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[kullanıcı]
GO
ALTER ROLE [db_owner] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_datareader] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [kullanıcı]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [kullanıcı]
GO
/****** Object:  Schema [kullanıcı]    Script Date: 12.05.2023 23:32:14 ******/
CREATE SCHEMA [kullanıcı]
GO
/****** Object:  Table [dbo].[U_BİLET]    Script Date: 12.05.2023 23:32:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[U_BİLET](
	[Bilet_Id] [int] IDENTITY(1,1) NOT NULL,
	[Yolcu_Id] [int] NULL,
	[Sefer_Id] [int] NULL,
	[Koltuk_No] [nvarchar](50) NULL,
 CONSTRAINT [PK_U_BİLET] PRIMARY KEY CLUSTERED 
(
	[Bilet_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[U_SEFERLER]    Script Date: 12.05.2023 23:32:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[U_SEFERLER](
	[Sefer_Id] [int] IDENTITY(1,1) NOT NULL,
	[Kalkış_Yer] [nvarchar](50) NULL,
	[Varış_Yer] [nvarchar](50) NULL,
	[Kalkış_Tarih] [nvarchar](50) NULL,
	[Varıs_Tarih] [nvarchar](50) NULL,
	[Ucak_Id] [int] NULL,
	[Ücret] [nvarchar](50) NULL,
	[Sefer_Ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_U_Seferler] PRIMARY KEY CLUSTERED 
(
	[Sefer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[U_Ucak]    Script Date: 12.05.2023 23:32:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[U_Ucak](
	[Ucak_Id] [int] IDENTITY(1,1) NOT NULL,
	[Ucak_Ad] [nchar](10) NULL,
	[Koltuk_Sayısı] [int] NULL,
 CONSTRAINT [PK_U_Ucak] PRIMARY KEY CLUSTERED 
(
	[Ucak_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[U_YOLCU]    Script Date: 12.05.2023 23:32:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[U_YOLCU](
	[Yolcu_Id] [int] IDENTITY(1,1) NOT NULL,
	[İsim] [nvarchar](50) NULL,
	[Yas] [nvarchar](3) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[Yaşlı_Mı] [nvarchar](50) NULL,
	[Engelli_Mi] [nvarchar](50) NULL,
	[Koltuk_No] [nvarchar](50) NULL,
 CONSTRAINT [PK_U_Yolcu] PRIMARY KEY CLUSTERED 
(
	[Yolcu_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[U_BİLET] ON 

INSERT [dbo].[U_BİLET] ([Bilet_Id], [Yolcu_Id], [Sefer_Id], [Koltuk_No]) VALUES (1, 1, 1, N'1')
SET IDENTITY_INSERT [dbo].[U_BİLET] OFF
GO
SET IDENTITY_INSERT [dbo].[U_SEFERLER] ON 

INSERT [dbo].[U_SEFERLER] ([Sefer_Id], [Kalkış_Yer], [Varış_Yer], [Kalkış_Tarih], [Varıs_Tarih], [Ucak_Id], [Ücret], [Sefer_Ad]) VALUES (1, N'Adana', N' Ankara', N'20 Ocak 2023 Cuma', N'21 Ocak 2023 Cumartesi', 1, N'2000', N'Mardin seferi')
INSERT [dbo].[U_SEFERLER] ([Sefer_Id], [Kalkış_Yer], [Varış_Yer], [Kalkış_Tarih], [Varıs_Tarih], [Ucak_Id], [Ücret], [Sefer_Ad]) VALUES (2, N'Adana', N' Ankara', N'20 Ocak 2023 Cuma', N'21 Ocak 2023 Cumartesi', 1, N'2000', N'Mardin seferi')
SET IDENTITY_INSERT [dbo].[U_SEFERLER] OFF
GO
SET IDENTITY_INSERT [dbo].[U_Ucak] ON 

INSERT [dbo].[U_Ucak] ([Ucak_Id], [Ucak_Ad], [Koltuk_Sayısı]) VALUES (1, N'Abus-110  ', 50)
INSERT [dbo].[U_Ucak] ([Ucak_Id], [Ucak_Ad], [Koltuk_Sayısı]) VALUES (2, N'Abus-230  ', 60)
SET IDENTITY_INSERT [dbo].[U_Ucak] OFF
GO
SET IDENTITY_INSERT [dbo].[U_YOLCU] ON 

INSERT [dbo].[U_YOLCU] ([Yolcu_Id], [İsim], [Yas], [Cinsiyet], [Yaşlı_Mı], [Engelli_Mi], [Koltuk_No]) VALUES (1, N'burak', N'22', N'1', N'0', N'0', N'A1')
SET IDENTITY_INSERT [dbo].[U_YOLCU] OFF
GO
ALTER TABLE [dbo].[U_BİLET]  WITH CHECK ADD  CONSTRAINT [FK_U_BİLET_U_SEFERLER] FOREIGN KEY([Sefer_Id])
REFERENCES [dbo].[U_SEFERLER] ([Sefer_Id])
GO
ALTER TABLE [dbo].[U_BİLET] CHECK CONSTRAINT [FK_U_BİLET_U_SEFERLER]
GO
ALTER TABLE [dbo].[U_BİLET]  WITH CHECK ADD  CONSTRAINT [FK_U_BİLET_U_YOLCU] FOREIGN KEY([Yolcu_Id])
REFERENCES [dbo].[U_YOLCU] ([Yolcu_Id])
GO
ALTER TABLE [dbo].[U_BİLET] CHECK CONSTRAINT [FK_U_BİLET_U_YOLCU]
GO
ALTER TABLE [dbo].[U_SEFERLER]  WITH CHECK ADD  CONSTRAINT [FK_U_SEFERLER_U_Ucak] FOREIGN KEY([Ucak_Id])
REFERENCES [dbo].[U_Ucak] ([Ucak_Id])
GO
ALTER TABLE [dbo].[U_SEFERLER] CHECK CONSTRAINT [FK_U_SEFERLER_U_Ucak]
GO
USE [master]
GO
ALTER DATABASE [Ucak rezervasyonSon] SET  READ_WRITE 
GO
