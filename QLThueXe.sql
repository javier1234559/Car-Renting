USE [master]
GO
/****** Object:  Database [QLThueXe]    Script Date: 3/14/2023 1:42:02 PM ******/
CREATE DATABASE [QLThueXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLThueXe', FILENAME = N'C:\Users\pc\QLThueXe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLThueXe_log', FILENAME = N'C:\Users\pc\QLThueXe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLThueXe] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThueXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThueXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLThueXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLThueXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLThueXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLThueXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLThueXe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLThueXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLThueXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLThueXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLThueXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLThueXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLThueXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLThueXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLThueXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLThueXe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLThueXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLThueXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLThueXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLThueXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLThueXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLThueXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLThueXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLThueXe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLThueXe] SET  MULTI_USER 
GO
ALTER DATABASE [QLThueXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLThueXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLThueXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLThueXe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLThueXe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLThueXe] SET QUERY_STORE = OFF
GO
USE [QLThueXe]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [QLThueXe]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccID] [int] NOT NULL,
	[Email] [nvarchar](320) NULL,
	[Password] [nvarchar](100) NULL,
	[IdUser] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[BillId] [int] NOT NULL,
	[RentId] [int] NULL,
	[IdUser] [int] NULL,
	[TotalCost] [int] NULL,
	[CreateDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarId] [int] NOT NULL,
	[CarName] [nvarchar](255) NULL,
	[CategoryId] [int] NULL,
	[Brand] [nvarchar](255) NULL,
	[Seats] [int] NULL,
	[PricePerDay] [int] NULL,
	[Description] [nvarchar](500) NULL,
	[ImageCar] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoyCar]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoyCar](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Phone] [varchar](11) NULL,
	[CCCD] [varchar](30) NULL,
	[Email] [nvarchar](320) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingId] [int] NOT NULL,
	[RentId] [int] NULL,
	[RatingValue] [int] NULL,
	[FeedBack] [text] NULL,
	[ClientId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rents]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rents](
	[RentId] [int] NOT NULL,
	[CarId] [int] NULL,
	[ClientId] [int] NULL,
	[DateStart] [datetime] NULL,
	[DateEnd] [datetime] NULL,
	[State] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[RentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/14/2023 1:42:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IdUser] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[Phone] [varchar](11) NULL,
	[Address] [varchar](255) NULL,
	[TotalRevenue] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([IdUser])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([RentId])
REFERENCES [dbo].[Rents] ([RentId])
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([IdUser])
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[CategoyCar] ([CategoryId])
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([ClientId])
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD FOREIGN KEY([RentId])
REFERENCES [dbo].[Rents] ([RentId])
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD FOREIGN KEY([CarId])
REFERENCES [dbo].[Cars] ([CarId])
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([ClientId])
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [valid_email] CHECK  (([Email] like '%@%.%'))
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [valid_email]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [valid_email1] CHECK  (([Email] like '%@%.%'))
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [valid_email1]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [valid_phone1] CHECK  (([Phone] like '0%' AND isnumeric([Phone])=(1)))
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [valid_phone1]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [valid_phone] CHECK  (([Phone] like '0%' AND isnumeric([Phone])=(1)))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [valid_phone]
GO
USE [master]
GO
ALTER DATABASE [QLThueXe] SET  READ_WRITE 
GO
