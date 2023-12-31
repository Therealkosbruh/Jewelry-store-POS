USE [master]
GO
/****** Object:  Database [zaytsev-isp401]    Script Date: 10.12.2023 17:13:56 ******/
CREATE DATABASE [zaytsev-isp401]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'zaytsev-isp401', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\zaytsev-isp401.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'zaytsev-isp401_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\zaytsev-isp401_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [zaytsev-isp401] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [zaytsev-isp401].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [zaytsev-isp401] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET ARITHABORT OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [zaytsev-isp401] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [zaytsev-isp401] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET  DISABLE_BROKER 
GO
ALTER DATABASE [zaytsev-isp401] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [zaytsev-isp401] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET RECOVERY FULL 
GO
ALTER DATABASE [zaytsev-isp401] SET  MULTI_USER 
GO
ALTER DATABASE [zaytsev-isp401] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [zaytsev-isp401] SET DB_CHAINING OFF 
GO
ALTER DATABASE [zaytsev-isp401] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [zaytsev-isp401] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [zaytsev-isp401] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [zaytsev-isp401] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'zaytsev-isp401', N'ON'
GO
ALTER DATABASE [zaytsev-isp401] SET QUERY_STORE = ON
GO
ALTER DATABASE [zaytsev-isp401] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [zaytsev-isp401]
GO
/****** Object:  Table [dbo].[order_prod]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_prod](
	[article] [varchar](50) NULL,
	[quantity] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_number] [int] IDENTITY(1,1) NOT NULL,
	[date_of_order] [datetime] NULL,
	[date_of_delivery] [datetime] NULL,
	[Place_of_delivery] [int] NULL,
	[client_id] [int] NULL,
	[code] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[order_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[place_of_delivery]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[place_of_delivery](
	[addr_id] [int] IDENTITY(1,1) NOT NULL,
	[Index] [int] NULL,
	[City] [varchar](50) NULL,
	[Street] [varchar](50) NULL,
	[Street_number] [int] NULL,
 CONSTRAINT [PK_place_of_delivery] PRIMARY KEY CLUSTERED 
(
	[addr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[article] [nvarchar](255) NULL,
	[prod_name] [nvarchar](255) NULL,
	[units_of_measurement] [nvarchar](255) NULL,
	[price] [decimal](18, 0) NULL,
	[max_sale] [int] NULL,
	[manufacter] [varchar](50) NULL,
	[supplier] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[current_sale] [int] NULL,
	[qty_on_stock] [int] NULL,
	[descr] [varchar](255) NULL,
	[img] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[ProductArticleNumber] [varchar](50) NULL,
	[ProductName] [varchar](50) NULL,
	[Units_of_measurement] [varchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
	[Max_sale] [int] NULL,
	[ProductManufacturer] [varchar](50) NULL,
	[Supplier] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[Current_sale] [int] NULL,
	[ProductQuantityInStock] [int] NULL,
	[Descr] [varchar](255) NULL,
	[IMG] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [varchar](10) NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[usr_id] [int] IDENTITY(1,1) NOT NULL,
	[Last_name] [varchar](25) NULL,
	[Name] [varchar](25) NULL,
	[Patronymic] [varchar](20) NULL,
	[Login] [varchar](20) NULL,
	[Password] [varchar](50) NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[usr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'K478R4', 10)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'S563T4', 2)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'K083T5', 11)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'B037T5', 1)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'R922T5', 7)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'V783T5', 1)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'H937R3', 1)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'F903T5', 4)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'R836R5', 1)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'D832R2', 5)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'F933T5', 5)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' D034T5', 6)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' D826T5', 11)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' D832R2', 5)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' D044T5', 5)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' F933T5', 5)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' S039T5', 3)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' F937R4', 3)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' D826T5', 2)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N' D044T5', 2)
INSERT [dbo].[order_prod] ([article], [quantity]) VALUES (N'K478R4', 30)
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (1, CAST(N'2022-05-01T00:00:00.000' AS DateTime), CAST(N'2022-05-07T00:00:00.000' AS DateTime), 2, 51, 111, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (2, CAST(N'2022-05-02T00:00:00.000' AS DateTime), CAST(N'2022-05-08T00:00:00.000' AS DateTime), 8, NULL, 112, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (3, CAST(N'2022-05-03T00:00:00.000' AS DateTime), CAST(N'2022-05-09T00:00:00.000' AS DateTime), 10, NULL, 113, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (4, CAST(N'2022-05-04T00:00:00.000' AS DateTime), CAST(N'2022-05-10T00:00:00.000' AS DateTime), 12, NULL, 114, 1)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (5, CAST(N'2022-05-05T00:00:00.000' AS DateTime), CAST(N'2022-05-11T00:00:00.000' AS DateTime), 15, NULL, 115, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (6, CAST(N'2022-05-06T00:00:00.000' AS DateTime), CAST(N'2022-05-12T00:00:00.000' AS DateTime), 18, 52, 116, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (7, CAST(N'2022-05-07T00:00:00.000' AS DateTime), CAST(N'2022-05-13T00:00:00.000' AS DateTime), 20, NULL, 117, 1)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (8, CAST(N'2022-05-08T00:00:00.000' AS DateTime), CAST(N'2022-05-14T00:00:00.000' AS DateTime), 25, NULL, 118, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (9, CAST(N'2022-05-09T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime), 30, NULL, 119, 1)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (10, CAST(N'2022-05-10T00:00:00.000' AS DateTime), CAST(N'2022-05-16T00:00:00.000' AS DateTime), 36, 53, 120, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (11, CAST(N'2023-12-09T19:01:58.240' AS DateTime), CAST(N'2023-12-14T19:01:58.240' AS DateTime), 1, 1, 121, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (13, CAST(N'2023-12-09T22:41:49.470' AS DateTime), CAST(N'2023-12-14T22:41:49.470' AS DateTime), 4, 1, 122, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (14, CAST(N'2023-12-09T22:41:56.340' AS DateTime), CAST(N'2023-12-14T22:41:56.340' AS DateTime), 4, 1, 122, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (15, CAST(N'2023-12-10T03:31:42.067' AS DateTime), CAST(N'2023-12-15T03:31:42.067' AS DateTime), 4, 1, 123, 2)
INSERT [dbo].[orders] ([order_number], [date_of_order], [date_of_delivery], [Place_of_delivery], [client_id], [code], [status]) VALUES (16, CAST(N'2023-12-10T16:59:29.440' AS DateTime), CAST(N'2023-12-15T16:59:29.440' AS DateTime), 8, 1, 124, 2)
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[place_of_delivery] ON 

INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (1, 344288, N' г. Ковров', N' ул. Чехова', 1)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (2, 614164, N' г.Ковров', N' ул. Степная', 30)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (3, 394242, N' г. Ковров', N' ул. Коммунистическая', 43)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (4, 660540, N' г. Ковров', N' ул. Солнечная', 25)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (5, 125837, N' г. Ковров', N' ул. Шоссейная', 40)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (6, 125703, N' г. Ковров', N' ул. Партизанская', 49)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (7, 625283, N' г. Ковров', N' ул. Победы', 46)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (8, 614611, N' г. Ковров', N' ул. Молодежная', 50)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (9, 454311, N' г.Ковров', N' ул. Новая', 19)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (10, 660007, N' г.Ковров', N' ул. Октябрьская', 19)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (11, 603036, N' г. Ковров', N' ул. Садовая', 4)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (12, 450983, N' г.Ковров', N' ул. Комсомольская', 26)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (13, 394782, N' г. Ковров', N' ул. Чехова', 3)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (14, 603002, N' г. Ковров', N' ул. Дзержинского', 28)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (15, 450558, N' г. Ковров', N' ул. Набережная', 30)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (16, 394060, N' г.Ковров', N' ул. Фрунзе', 43)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (17, 410661, N' г. Ковров', N' ул. Школьная', 50)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (18, 625590, N' г. Ковров', N' ул. Коммунистическая', 20)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (19, 625683, N' г. Ковров', N' ул. 8 Марта', NULL)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (20, 400562, N' г. Ковров', N' ул. Зеленая', 32)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (21, 614510, N' г. Ковров', N' ул. Маяковского', 47)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (22, 410542, N' г. Ковров', N' ул. Светлая', 46)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (23, 620839, N' г. Ковров', N' ул. Цветочная', 8)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (24, 443890, N' г. Ковров', N' ул. Коммунистическая', 1)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (25, 603379, N' г. Ковров', N' ул. Спортивная', 46)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (26, 603721, N' г. Ковров', N' ул. Гоголя', 41)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (27, 410172, N' г. Ковров', N' ул. Северная', 13)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (28, 420151, N' г. Ковров', N' ул. Вишневая', 32)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (29, 125061, N' г. Ковров', N' ул. Подгорная', 8)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (30, 630370, N' г. Ковров', N' ул. Шоссейная', 24)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (31, 614753, N' г. Ковров', N' ул. Полевая', 35)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (32, 426030, N' г. Ковров', N' ул. Маяковского', 44)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (33, 450375, N' г. Ковров ', N'ул.Клубная', 44)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (34, 625560, N' г. Ковров', N' ул. Некрасова', 12)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (35, 630201, N' г. Ковров', N' ул. Комсомольская', 17)
INSERT [dbo].[place_of_delivery] ([addr_id], [Index], [City], [Street], [Street_number]) VALUES (36, 190949, N' г. Ковров', N' ул. Мичурина', 26)
SET IDENTITY_INSERT [dbo].[place_of_delivery] OFF
GO
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'K478R4', N'Аромат', N'шт.', CAST(3500 AS Decimal(18, 0)), 30, N'Esteban', N'Стокманн', N'Ароматы для дома', 4, 4, N'Аромат для декобукета Esteban', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'V783T5', N'Ваза', N'шт.', CAST(1300 AS Decimal(18, 0)), 25, N'Home Philosophy', N'Стокманн', N'Вазы', 2, 13, N'Ваза из керамики Betty', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'V483R7', N'Ваза', N'шт.', CAST(100 AS Decimal(18, 0)), 15, N'Весна', N'Hoff', N'Вазы', 3, 7, N'Ваза «Весна» 18 см стекло, цвет прозрачный', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'S563T4', N'Свеча', N'шт.', CAST(1000 AS Decimal(18, 0)), 20, N'True Scents', N'Hoff', N'Свечи', 3, 12, N'Свеча в стакане True Scents', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'P927R2', N'Подставка', N'шт.', CAST(4000 AS Decimal(18, 0)), 15, N'Valley', N'Стокманн', N'Горшки и подставки', 2, 4, N'Подставка для цветочных горшков Valley', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'F933T5', N'Кашпо', N'шт.', CAST(1400 AS Decimal(18, 0)), 20, N'Cube Color', N'Hoff', N'Горшки и подставки', 4, 23, N'Настольное кашпо с автополивом Cube Color', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'H023R8', N'Часы', N'шт.', CAST(5600 AS Decimal(18, 0)), 15, N'Umbra', N'Стокманн', N'Часы', 2, 6, N'Часы настенные Ribbon 30,5 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'H937R3', N'Часы', N'шт.', CAST(999 AS Decimal(18, 0)), 10, N'Umbra', N'Hoff', N'Часы', 3, 4, N'Часы настенные 6500 30,2 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'D034T5', N'Диффузор', N'шт.', CAST(800 AS Decimal(18, 0)), 20, N'Miksdo', N'Hoff', N'Ароматы для дома', 2, 15, N'Диффузор Mikado intense Апельсин с корицей', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'P936E4', N'Подставка', N'шт.', CAST(3590 AS Decimal(18, 0)), 15, N'Umbra', N'Стокманн', N'Горшки и подставки', 4, 9, N'Подставка для газет и журналов Zina', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'K937T4', N'Аромат', N'шт.', CAST(7900 AS Decimal(18, 0)), 25, N'Esteban', N'Стокманн', N'Ароматы для дома', 2, 17, N'Деко-букет Кедр 250 мл', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'P846R4', N'Подставка', N'шт.', CAST(1400 AS Decimal(18, 0)), 15, N'Valley', N'Стокманн', N'Горшки и подставки', 3, 12, N'Подставка для цветочных горшков 55x25x35 см Valley', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'S039T5', N'Свеча', N'шт.', CAST(250 AS Decimal(18, 0)), 10, N'True Scents', N'Hoff', N'Свечи', 2, 18, N'Свеча True Moods Feel happy', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'D947R5', N'Диффузор', N'шт.', CAST(500 AS Decimal(18, 0)), 5, N'Aroma', N'Hoff', N'Ароматы для дома', 4, 6, N'Диффузор Aroma Harmony Lavender', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'F903T5', N'Фоторамка', N'шт.', CAST(600 AS Decimal(18, 0)), 15, N'Gallery', N'Hoff', N'Картины и фоторамки', 2, 3, N'Фоторамка Gallery 20х30 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'S937T5', N'Подсвечник', N'шт.', CAST(2600 AS Decimal(18, 0)), 10, N'Kersten', N'Стокманн', N'Ароматы для дома', 3, 23, N'Подсвечник 37 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'R836R5', N'Шкатулка', N'шт.', CAST(8000 AS Decimal(18, 0)), 30, N'Umbra', N'Стокманн', N'Шкатулки и подставки', 5, 3, N'Шкатулка для украшений из дерева Stowit', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'F837T5', N'Фоторамка', N'шт.', CAST(999 AS Decimal(18, 0)), 5, N'Gallery', N'Hoff', N'Картины и фоторамки', 2, 15, N'Шкатулка для украшений из дерева Stowit', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'V432R6', N'Ваза', N'шт.', CAST(1990 AS Decimal(18, 0)), 10, N'Kersten', N'Стокманн', N'Вазы', 3, 30, N'Ваза из фаянса 28,00 x 9,50 x 9,50 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'F928T5', N'Фоторамка', N'шт.', CAST(1590 AS Decimal(18, 0)), 25, N'Umbra', N'Стокманн', N'Картины и фоторамки', 2, 13, N'Фоторамка Prisma 10х10 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'F937R4', N'Фоторамка', N'шт.', CAST(359 AS Decimal(18, 0)), 15, N'Gallery', N'Hoff', N'Картины и фоторамки', 4, 17, N'Фоторамка 10х15 см Gallery серый с патиной/золотой', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'K083T5', N'Аромат', N'шт.', CAST(2790 AS Decimal(18, 0)), 20, N'Esteban', N'Стокманн', N'Ароматы для дома', 2, 6, N'Сменный аромат Figue noire 250 мл', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'V937E4', N'Ваза', N'шт.', CAST(1999 AS Decimal(18, 0)), 15, N'Kersten', N'Hoff', N'Вазы', 3, 21, N'Ваза 18H2535S 30,5 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'R922T5', N'Шкатулка', N'шт.', CAST(690 AS Decimal(18, 0)), 10, N'Home Philosophy', N'Стокманн', N'Шкатулки и подставки', 2, 4, N'Шкатулка из керамики Lana 6х7 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'B025Y5', N'Блюдо', N'шт.', CAST(1890 AS Decimal(18, 0)), 5, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 3, 8, N'Блюдо декоративное flower 35 см Home Philosophy', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'D826T5', N'Диффузор', N'шт.', CAST(600 AS Decimal(18, 0)), 5, N'True Scents', N'Hoff', N'Ароматы для дома', 2, 13, N'Диффузор True Scents 45 мл манго', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'S936Y5', N'Свеча', N'шт.', CAST(299 AS Decimal(18, 0)), 15, N'True Scents', N'Hoff', N'Ароматы для дома', 3, 4, N'Свеча в стакане True Scents', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'B037T5', N'Блюдо', N'шт.', CAST(690 AS Decimal(18, 0)), 5, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 2, 14, N'Блюдо декоративное Flower 35 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'D832R2', N'Растение', N'шт.', CAST(1000 AS Decimal(18, 0)), 10, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 3, 15, N'Декоративное растение 102 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (N'D044T5', N'Декор настенный', N'шт.', CAST(1790 AS Decimal(18, 0)), 5, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 3, 7, N'Декор настенный Фантазия 45х45х1 см', NULL)
INSERT [dbo].[Product] ([article], [prod_name], [units_of_measurement], [price], [max_sale], [manufacter], [supplier], [category], [current_sale], [qty_on_stock], [descr], [img]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'K478R4', N'Аромат', N'шт.', CAST(3500.00 AS Decimal(18, 2)), 30, N'Esteban', N'Стокманн', N'Ароматы для дома', 4, 4, N'Аромат для декобукета Esteban', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'V783T5', N'Ваза', N'шт.', CAST(1300.00 AS Decimal(18, 2)), 25, N'Home Philosophy', N'Стокманн', N'Вазы', 2, 13, N'Ваза из керамики Betty', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'V483R7', N'Ваза', N'шт.', CAST(100.00 AS Decimal(18, 2)), 15, N'Весна', N'Hoff', N'Вазы', 3, 7, N'Ваза «Весна» 18 см стекло, цвет прозрачный', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'S563T4', N'Свеча', N'шт.', CAST(1000.00 AS Decimal(18, 2)), 20, N'True Scents', N'Hoff', N'Свечи', 3, 12, N'Свеча в стакане True Scents', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'P927R2', N'Подставка', N'шт.', CAST(4000.00 AS Decimal(18, 2)), 15, N'Valley', N'Стокманн', N'Горшки и подставки', 2, 4, N'Подставка для цветочных горшков Valley', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'F933T5', N'Кашпо', N'шт.', CAST(1400.00 AS Decimal(18, 2)), 20, N'Cube Color', N'Hoff', N'Горшки и подставки', 4, 23, N'Настольное кашпо с автополивом Cube Color', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'H023R8', N'Часы', N'шт.', CAST(5600.00 AS Decimal(18, 2)), 15, N'Umbra', N'Стокманн', N'Часы', 2, 6, N'Часы настенные Ribbon 30,5 см', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'H937R3', N'Часы', N'шт.', CAST(999.00 AS Decimal(18, 2)), 10, N'Umbra', N'Hoff', N'Часы', 3, 4, N'Часы настенные 6500 30,2 см', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'D034T5', N'Диффузор', N'шт.', CAST(800.00 AS Decimal(18, 2)), 20, N'Miksdo', N'Hoff', N'Ароматы для дома', 2, 15, N'Диффузор Mikado intense Апельсин с корицей', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'P936E4', N'Подставка', N'шт.', CAST(3590.00 AS Decimal(18, 2)), 15, N'Umbra', N'Стокманн', N'Горшки и подставки', 4, 9, N'Подставка для газет и журналов Zina', N'#VALUE!')
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'K937T4', N'Аромат', N'шт.', CAST(7900.00 AS Decimal(18, 2)), 25, N'Esteban', N'Стокманн', N'Ароматы для дома', 2, 17, N'Деко-букет Кедр 250 мл', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'P846R4', N'Подставка', N'шт.', CAST(1400.00 AS Decimal(18, 2)), 15, N'Valley', N'Стокманн', N'Горшки и подставки', 3, 12, N'Подставка для цветочных горшков 55x25x35 см Valley', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'S039T5', N'Свеча', N'шт.', CAST(250.00 AS Decimal(18, 2)), 10, N'True Scents', N'Hoff', N'Свечи', 2, 18, N'Свеча True Moods Feel happy', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'D947R5', N'Диффузор', N'шт.', CAST(500.00 AS Decimal(18, 2)), 5, N'Aroma', N'Hoff', N'Ароматы для дома', 4, 6, N'Диффузор Aroma Harmony Lavender', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'F903T5', N'Фоторамка', N'шт.', CAST(600.00 AS Decimal(18, 2)), 15, N'Gallery', N'Hoff', N'Картины и фоторамки', 2, 3, N'Фоторамка Gallery 20х30 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'S937T5', N'Подсвечник', N'шт.', CAST(2600.00 AS Decimal(18, 2)), 10, N'Kersten', N'Стокманн', N'Ароматы для дома', 3, 23, N'Подсвечник 37 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'R836R5', N'Шкатулка', N'шт.', CAST(8000.00 AS Decimal(18, 2)), 30, N'Umbra', N'Стокманн', N'Шкатулки и подставки', 5, 3, N'Шкатулка для украшений из дерева Stowit', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'F837T5', N'Фоторамка', N'шт.', CAST(999.00 AS Decimal(18, 2)), 5, N'Gallery', N'Hoff', N'Картины и фоторамки', 2, 15, N'Шкатулка для украшений из дерева Stowit', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'V432R6', N'Ваза', N'шт.', CAST(1990.00 AS Decimal(18, 2)), 10, N'Kersten', N'Стокманн', N'Вазы', 3, 30, N'Ваза из фаянса 28,00 x 9,50 x 9,50 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'F928T5', N'Фоторамка', N'шт.', CAST(1590.00 AS Decimal(18, 2)), 25, N'Umbra', N'Стокманн', N'Картины и фоторамки', 2, 13, N'Фоторамка Prisma 10х10 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'F937R4', N'Фоторамка', N'шт.', CAST(359.00 AS Decimal(18, 2)), 15, N'Gallery', N'Hoff', N'Картины и фоторамки', 4, 17, N'Фоторамка 10х15 см Gallery серый с патиной/золотой', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'K083T5', N'Аромат', N'шт.', CAST(2790.00 AS Decimal(18, 2)), 20, N'Esteban', N'Стокманн', N'Ароматы для дома', 2, 6, N'Сменный аромат Figue noire 250 мл', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'V937E4', N'Ваза', N'шт.', CAST(1999.00 AS Decimal(18, 2)), 15, N'Kersten', N'Hoff', N'Вазы', 3, 21, N'Ваза 18H2535S 30,5 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'R922T5', N'Шкатулка', N'шт.', CAST(690.00 AS Decimal(18, 2)), 10, N'Home Philosophy', N'Стокманн', N'Шкатулки и подставки', 2, 4, N'Шкатулка из керамики Lana 6х7 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'B025Y5', N'Блюдо', N'шт.', CAST(1890.00 AS Decimal(18, 2)), 5, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 3, 8, N'Блюдо декоративное flower 35 см Home Philosophy', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'D826T5', N'Диффузор', N'шт.', CAST(600.00 AS Decimal(18, 2)), 5, N'True Scents', N'Hoff', N'Ароматы для дома', 2, 13, N'Диффузор True Scents 45 мл манго', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'S936Y5', N'Свеча', N'шт.', CAST(299.00 AS Decimal(18, 2)), 15, N'True Scents', N'Hoff', N'Ароматы для дома', 3, 4, N'Свеча в стакане True Scents', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'B037T5', N'Блюдо', N'шт.', CAST(690.00 AS Decimal(18, 2)), 5, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 2, 14, N'Блюдо декоративное Flower 35 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'D832R2', N'Растение', N'шт.', CAST(1000.00 AS Decimal(18, 2)), 10, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 3, 15, N'Декоративное растение 102 см', NULL)
INSERT [dbo].[products] ([ProductArticleNumber], [ProductName], [Units_of_measurement], [Price], [Max_sale], [ProductManufacturer], [Supplier], [Category], [Current_sale], [ProductQuantityInStock], [Descr], [IMG]) VALUES (N'D044T5', N'Декор настенный', N'шт.', CAST(1790.00 AS Decimal(18, 2)), 5, N'Home Philosophy', N'Стокманн', N'Интерьерные аксессуары', 3, 7, N'Декор настенный Фантазия 45х45х1 см', NULL)
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Клиент')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Менеджер')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (3, N'Администратор')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[status] ON 

INSERT [dbo].[status] ([status_id], [status_name]) VALUES (1, N'Завершен')
INSERT [dbo].[status] ([status_id], [status_name]) VALUES (2, N'Новый')
SET IDENTITY_INSERT [dbo].[status] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (1, N'Алексеев ', N'Владислав', N'Аркадьевич', N'loginDEbct2018', N'Qg3gff', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (2, N'Савельева ', N'Евфросиния', N'Арсеньевна', N'loginDEvtg2018', N'ETMNzL', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (3, N'Никонов ', N'Мэлс', N'Лукьевич', N'loginDEuro2018', N'a1MIcO', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (4, N'Горшкова ', N'Агафья', N'Онисимовна', N'loginDEpst2018', N'0CyGnX', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (5, N'Горбачёв ', N'Пантелеймон', N'Германович', N'loginDEpsu2018', N'Vx9cQ{', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (6, N'Ершова ', N'Иванна', N'Максимовна', N'loginDEzqs2018', N'qM9p7i', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (7, N'Туров ', N'Денис', N'Геласьевич', N'loginDEioe2018', N'yMPu&2', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (8, N'Носова ', N'Наина', N'Эдуардовна', N'loginDEcmk2018', N'3f+b0+', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (9, N'Куликов ', N'Андрей', N'Святославович', N'loginDEfsp2018', N'&dtlI+', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (10, N'Нестеров ', N'Агафон', N'Георгьевич', N'loginDExcd2018', N'SZXZNL', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (11, N'Козлов ', N'Геласий', N'Христофорович', N'loginDEvlf2018', N'O5mXc2', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (12, N'Борисова ', N'Анжелика', N'Анатольевна', N'loginDEanv2018', N'Xiq}M3', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (13, N'Суханов ', N'Станислав', N'Фролович', N'loginDEzde2018', N'tlO3x&', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (14, N'Тетерина ', N'Феврония', N'Эдуардовна', N'loginDEriv2018', N'GJ2mHL', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (15, N'Муравьёва ', N'Александра', N'Ростиславовна', N'loginDEhcp2018', N'n2nfRl', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (16, N'Новикова ', N'Лукия', N'Ярославовна', N'loginDEwjv2018', N'ZfseKA', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (17, N'Агафонова ', N'Лариса', N'Михаиловна', N'loginDEiry2018', N'5zu7+}', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (18, N'Сергеева ', N'Агата', N'Юрьевна', N'loginDEgbr2018', N'}+Ex1*', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (19, N'Колобова ', N'Елена', N'Евгеньевна', N'loginDExxv2018', N'+daE|T', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (20, N'Ситников ', N'Николай', N'Филатович', N'loginDEbto2018', N'b1iYMI', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (21, N'Белов ', N'Роман', N'Иринеевич', N'loginDEfbs2018', N'v90Rep', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (22, N'Волкова ', N'Алла', N'Лукьевна', N'loginDEple2018', N'WlW+l8', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (23, N'Кудрявцева ', N'Таисия', N'Игоревна', N'loginDEhhx2018', N'hmCHeQ', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (24, N'Семёнова ', N'Октябрина', N'Христофоровна', N'loginDEayn2018', N'Ka2Fok', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (25, N'Смирнов ', N'Сергей', N'Яковович', N'loginDEwld2018', N'y9HStF', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (26, N'Брагина ', N'Алина', N'Валерьевна', N'loginDEhuu2018', N'X31OEf', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (27, N'Евсеев ', N'Игорь', N'Донатович', N'loginDEmjb2018', N'5mm{ch', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (28, N'Суворов ', N'Илья', N'Евсеевич', N'loginDEdgp2018', N'1WfJjo', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (29, N'Котов ', N'Денис', N'Мартынович', N'loginDEgyi2018', N'|7nYPc', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (30, N'Бобылёва ', N'Юлия', N'Егоровна', N'loginDEmvn2018', N'Mrr9e0', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (31, N'Брагин ', N'Бронислав', N'Георгьевич', N'loginDEfoj2018', N'nhGc+D', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (32, N'Александров ', N'Владимир', N'Дамирович', N'loginDEuuo2018', N'42XmH1', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (33, N'Фокин ', N'Ириней', N'Ростиславович', N'loginDEhsj2018', N's+jrMW', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (34, N'Воронов ', N'Митрофан', N'Антонович', N'loginDEvht2018', N'zMyS8Z', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (35, N'Маслов ', N'Мстислав', N'Антонинович', N'loginDEeqo2018', N'l5CBqA', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (36, N'Щербаков ', N'Георгий', N'Богданович', N'loginDExrf2018', N'mhpRIT', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (37, N'Кириллова ', N'Эмилия', N'Федосеевна', N'loginDEfku2018', N'a1m+8c', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (38, N'Васильев ', N'Серапион', N'Макарович', N'loginDExix2018', N'hzxtnn', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (39, N'Галкина ', N'Олимпиада', N'Владленовна', N'loginDEqrf2018', N'mI8n58', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (40, N'Яковлева ', N'Ксения', N'Онисимовна', N'loginDEhlk2018', N'g0jSed', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (41, N'Калашникова ', N'Александра', N'Владимировна', N'loginDEwoe2018', N'yOtw2F', 3)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (42, N'Медведьева ', N'Таисия', N'Тихоновна', N'loginDExyu2018', N'7Fg}9p', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (43, N'Карпова ', N'Ольга', N'Лукьевна', N'loginDEcor2018', N'2cIrC8', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (44, N'Герасимов ', N'Мстислав', N'Дамирович', N'loginDEqon2018', N'YeFbh6', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (45, N'Тимофеева ', N'Ксения', N'Валерьевна', N'loginDEyfd2018', N'8aKdb0', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (46, N'Горбунов ', N'Вячеслав', N'Станиславович', N'loginDEtto2018', N'qXYDuu', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (47, N'Кошелева ', N'Кира', N'Владиславовна', N'loginDEdal2018', N'cJWXL0', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (48, N'Панфилова ', N'Марина', N'Борисовна', N'loginDEbjs2018', N'Xap2ct', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (49, N'Кудрявцев ', N'Матвей', N'Игоревич', N'loginDEdof2018', N'kD|LRU', 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (50, N'Зуев ', N'Эдуард', N'Пантелеймонович', N'loginDEsnh2018', NULL, 2)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (51, N'Архипова', N'Оливия', N'Дмитриевна', N'qweqweqwe', N'801293ojdoqnqwe', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (52, N'Никонова', N'Татьяна', N'Захаровна', N'qqweqweqwe', N'1801293ojdoqnqwe', 1)
INSERT [dbo].[users] ([usr_id], [Last_name], [Name], [Patronymic], [Login], [Password], [Role]) VALUES (53, N'Рябова', N'Диана', N'Павловна', N'qqqweqweqwe', N'21801293ojdoqnqwe', 1)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[orders] ADD  CONSTRAINT [DF_orders_date_of_order]  DEFAULT (getdate()) FOR [date_of_order]
GO
ALTER TABLE [dbo].[orders] ADD  CONSTRAINT [DF_orders_date_of_delivery]  DEFAULT (dateadd(day,(5),getdate())) FOR [date_of_delivery]
GO
ALTER TABLE [dbo].[products] ADD  CONSTRAINT [DF_products_Units_of_measurement]  DEFAULT ('шт') FOR [Units_of_measurement]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_orders] FOREIGN KEY([order_number])
REFERENCES [dbo].[orders] ([order_number])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_orders]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_orders1] FOREIGN KEY([order_number])
REFERENCES [dbo].[orders] ([order_number])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_orders1]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_place_of_delivery] FOREIGN KEY([Place_of_delivery])
REFERENCES [dbo].[place_of_delivery] ([addr_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_place_of_delivery]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_status] FOREIGN KEY([status])
REFERENCES [dbo].[status] ([status_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_status]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_users] FOREIGN KEY([client_id])
REFERENCES [dbo].[users] ([usr_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_users]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_Role] FOREIGN KEY([Role])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_Role]
GO
/****** Object:  StoredProcedure [dbo].[delProd]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[delProd]
@article varchar(50)
AS
BEGIN
	DELETE FROM Product where article=@article
	
END
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Login]

	@Login varchar(20),
	@Password varchar(50)
AS
BEGIN	
	SET NOCOUNT ON;
		SELECT * FROM users
		WHERE Login=@Login and Password=@Password

END
GO
/****** Object:  StoredProcedure [dbo].[newProd]    Script Date: 10.12.2023 17:13:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[newProd]
@ProductArticleNumber varchar(50),
@ProductName varchar(50),
@Price decimal(18,2),
@Max_sale int,
@ProductManufacturer varchar(50),
@Supplier varchar(50),
@Category varchar(50),
@Current_sale int,
@ProductQuantityInStock int,
@Descr varchar(255),
@IMG varchar(55)
AS
BEGIN

	insert into products(ProductArticleNumber,ProductName,Price,Max_sale,ProductManufacturer,Supplier,Category,Current_sale,ProductQuantityInStock,Descr,IMG)
	values(@ProductArticleNumber,@ProductName,@Price,@Max_sale,@ProductManufacturer,@Supplier,@Category,@Current_sale,@ProductQuantityInStock,@Descr,@IMG)


END
GO
USE [master]
GO
ALTER DATABASE [zaytsev-isp401] SET  READ_WRITE 
GO
