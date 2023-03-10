USE [master]
GO
/****** Object:  Database [ProductDb]    Script Date: 18.02.2023 13:20:11 ******/
CREATE DATABASE [ProductDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProductDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProductDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProductDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ProductDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProductDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProductDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductDb] SET RECOVERY FULL 
GO
ALTER DATABASE [ProductDb] SET  MULTI_USER 
GO
ALTER DATABASE [ProductDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProductDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProductDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProductDb', N'ON'
GO
ALTER DATABASE [ProductDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProductDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ProductDb]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 18.02.2023 13:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 18.02.2023 13:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Quantity] [int] NULL,
	[Rating] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 18.02.2023 13:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Rating] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Telephone')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Car')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Fruit')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'CPU')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (5, N'Laptop')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (1, N'Ford', CAST(88000 AS Decimal(18, 0)), 2, 75, CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (2, N'Mercedes-Benz', CAST(26600 AS Decimal(18, 0)), 2, 46, CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (3, N'Iphone 14', CAST(999 AS Decimal(18, 0)), 1, 82, CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (4, N'Macbook Pro', CAST(1099 AS Decimal(18, 0)), 5, 83, CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (5, N'Macbook Air', CAST(1299 AS Decimal(18, 0)), 5, 1, CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (6, N'Nokia 3310', CAST(20 AS Decimal(18, 0)), 1, 93, CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (7, N'Apple', CAST(58 AS Decimal(18, 0)), 3, 1, CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (8, N'Banana', CAST(131 AS Decimal(18, 0)), 3, 2, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (9, N'Ryzen 5 5600x', CAST(229 AS Decimal(18, 0)), 4, 3, CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (10, N'Intel I7 10700K', CAST(249 AS Decimal(18, 0)), 4, 62, CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[Product] ([Id], [Name], [Price], [CategoryId], [Quantity], [Rating]) VALUES (11, N'Test', CAST(120 AS Decimal(18, 0)), 2, 12, CAST(4 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [CK_Rating_Rating] CHECK  (([Rating]>=(0) AND [Rating]<=(5)))
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [CK_Rating_Rating]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddProduct]    Script Date: 18.02.2023 13:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_AddProduct]
@pName nvarchar(20),
@pQuantity int,
@pPrice decimal(18,0),
@pRating decimal(18,0),
@pCategoryId int
AS
INSERT INTO Product (Name, Quantity, Price, Rating, CategoryId) VALUES (@pName,@pQuantity,@pPrice,@pRating,@pCategoryId);
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteProduct]    Script Date: 18.02.2023 13:20:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteProduct]
@pId int
AS

DELETE FROM Product WHERE Product.Id = @pId
RETURN 0
GO
USE [master]
GO
ALTER DATABASE [ProductDb] SET  READ_WRITE 
GO
