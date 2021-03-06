USE [master]
GO
/****** Object:  Database [LifeHelper]    Script Date: 2018-05-04 00:22:07 ******/
CREATE DATABASE [LifeHelper]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Life Helper', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.PKSQL\MSSQL\DATA\Life Helper.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Life Helper_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.PKSQL\MSSQL\DATA\Life Helper_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LifeHelper] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LifeHelper].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LifeHelper] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LifeHelper] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LifeHelper] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LifeHelper] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LifeHelper] SET ARITHABORT OFF 
GO
ALTER DATABASE [LifeHelper] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LifeHelper] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LifeHelper] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LifeHelper] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LifeHelper] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LifeHelper] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LifeHelper] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LifeHelper] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LifeHelper] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LifeHelper] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LifeHelper] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LifeHelper] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LifeHelper] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LifeHelper] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LifeHelper] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LifeHelper] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LifeHelper] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LifeHelper] SET RECOVERY FULL 
GO
ALTER DATABASE [LifeHelper] SET  MULTI_USER 
GO
ALTER DATABASE [LifeHelper] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LifeHelper] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LifeHelper] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LifeHelper] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LifeHelper] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LifeHelper', N'ON'
GO
ALTER DATABASE [LifeHelper] SET QUERY_STORE = OFF
GO
USE [LifeHelper]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [LifeHelper]
GO
/****** Object:  Table [dbo].[Additional_activities]    Script Date: 2018-05-04 00:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Additional_activities](
	[Day of the week] [nvarchar](50) NULL,
	[Additional activity] [nvarchar](50) NULL,
	[Details] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calories]    Script Date: 2018-05-04 00:22:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calories](
	[Day of the week] [nvarchar](50) NULL,
	[Form of sport] [nvarchar](50) NULL,
	[Time of exercising [min]]] [int] NULL,
	[Calories burnt] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DutyDetails]    Script Date: 2018-05-04 00:22:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DutyDetails](
	[Subject] [nvarchar](50) NULL,
	[Duty] [nvarchar](50) NULL,
	[Details] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Imaginary_Friend]    Script Date: 2018-05-04 00:22:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imaginary_Friend](
	[Type of advice] [nvarchar](max) NULL,
	[Advices used] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[My_week]    Script Date: 2018-05-04 00:22:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[My_week](
	[Subject] [nvarchar](50) NULL,
	[Day of the week] [nvarchar](50) NULL,
	[Time] [time](7) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plan_of_action]    Script Date: 2018-05-04 00:22:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plan_of_action](
	[Subject] [nvarchar](50) NULL,
	[Duty] [nvarchar](50) NULL,
	[Deadline] [nvarchar](50) NULL,
	[How long will it take? [min]]] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[To_Watch]    Script Date: 2018-05-04 00:22:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[To_Watch](
	[Films/TV series to watch] [nvarchar](50) NULL,
	[Recommended by] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Monday', N'cinema', N'Avengers with Marta')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Wednesday', N'beer', N'18:00 ')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Thursday', N'C# course', N'19:00 - [never enough </3]')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Friday', N'meeting', N'sushi with girls at 19:00')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Saturday', N'Food Trucks', N'Asian food with Maczek')
