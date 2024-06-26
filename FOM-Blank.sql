USE [master]
GO
/****** Object:  Database [FOM]    Script Date: 6/7/2024 10:01:33 AM ******/
CREATE DATABASE [FOM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FOM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FOM.mdf' , SIZE = 335872KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FOM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FOM_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FOM] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FOM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FOM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FOM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FOM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FOM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FOM] SET ARITHABORT OFF 
GO
ALTER DATABASE [FOM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FOM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FOM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FOM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FOM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FOM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FOM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FOM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FOM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FOM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FOM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FOM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FOM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FOM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FOM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FOM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FOM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FOM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FOM] SET  MULTI_USER 
GO
ALTER DATABASE [FOM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FOM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FOM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FOM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FOM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FOM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FOM] SET QUERY_STORE = ON
GO
ALTER DATABASE [FOM] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FOM]
GO
/****** Object:  Table [dbo].[tblPosts]    Script Date: 6/7/2024 10:01:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPosts](
	[pid] [bigint] NOT NULL,
	[slug] [nvarchar](max) NULL,
	[likes] [bigint] NULL,
	[dislikes] [bigint] NULL,
	[views] [bigint] NULL,
	[category] [nvarchar](max) NULL,
	[tags] [nvarchar](max) NULL,
	[size] [nvarchar](max) NULL,
	[mcategory] [nvarchar](max) NULL,
	[title] [nvarchar](max) NULL,
	[body] [nvarchar](max) NULL,
	[img] [nvarchar](max) NULL,
	[tlink1] [nvarchar](max) NULL,
	[link1] [nvarchar](max) NULL,
	[tlink2] [nvarchar](max) NULL,
	[link2] [nvarchar](max) NULL,
	[tlink3] [nvarchar](max) NULL,
	[link3] [nvarchar](max) NULL,
	[tlink4] [nvarchar](max) NULL,
	[link4] [nvarchar](max) NULL,
	[tlink5] [nvarchar](max) NULL,
	[link5] [nvarchar](max) NULL,
	[year] [bigint] NULL,
	[meta] [nvarchar](max) NULL,
	[tlink6] [nvarchar](max) NULL,
	[link6] [nvarchar](max) NULL,
	[DateInserted] [smalldatetime] NOT NULL,
	[IMDBID] [nvarchar](max) NULL,
	[TMDBID] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwtags]    Script Date: 6/7/2024 10:01:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[vwtags] as 
Select * from (Select Replace(split,' ','') as Tags from  (Select value as split from string_split((Select STRING_AGG(tags,',') as tag from tblPosts),',')) as  mt) as mt2  group by Tags
GO
/****** Object:  View [dbo].[vwcategorys]    Script Date: 6/7/2024 10:01:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[vwcategorys] as 
Select * from (Select Replace(split,' ','') as Tags from  (Select value as split from string_split((Select STRING_AGG(category,',') as tags from tblPosts),',')) as  mt) as mt2  group by Tags
GO
/****** Object:  Table [dbo].[tblSeries]    Script Date: 6/7/2024 10:01:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSeries](
	[sid] [bigint] NOT NULL,
	[slug] [nvarchar](max) NULL,
	[dislikes] [nvarchar](max) NULL,
	[views] [nvarchar](max) NULL,
	[category] [nvarchar](max) NULL,
	[title] [nvarchar](max) NULL,
	[body] [nvarchar](max) NULL,
	[img] [nvarchar](max) NULL,
	[year] [nvarchar](max) NULL,
	[meta] [nvarchar](max) NULL,
	[DateInserted] [smalldatetime] NULL,
	[likes] [nvarchar](max) NULL,
	[episodes] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblViews]    Script Date: 6/7/2024 10:01:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblViews](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Website] [nvarchar](max) NULL,
	[page] [nvarchar](max) NULL,
	[userip] [nvarchar](max) NULL,
	[usersystem] [nvarchar](max) NULL,
	[userbrowser] [nvarchar](max) NULL,
	[DateInserted] [smalldatetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblPosts] ADD  CONSTRAINT [DF_tblPosts_DateInserted]  DEFAULT (getdate()) FOR [DateInserted]
GO
ALTER TABLE [dbo].[tblSeries] ADD  CONSTRAINT [DF_tblSeries_DateInserted]  DEFAULT (getdate()) FOR [DateInserted]
GO
ALTER TABLE [dbo].[tblViews] ADD  CONSTRAINT [DF_tblViews_DateInserted]  DEFAULT (getdate()) FOR [DateInserted]
GO
USE [master]
GO
ALTER DATABASE [FOM] SET  READ_WRITE 
GO
