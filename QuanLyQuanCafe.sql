USE [master]
GO
/****** Object:  Database [QuanLyQuanCafe]    Script Date: 5/26/2024 12:30:15 AM ******/
CREATE DATABASE [QuanLyQuanCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyQuanCafe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyQuanCafe]
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 5/26/2024 12:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenBan] [nvarchar](100) NOT NULL,
	[TrangThai] [int] NOT NULL,
	[KhuVuc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 5/26/2024 12:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/26/2024 12:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBanAn] [int] NOT NULL,
	[ThoiGian] [date] NOT NULL,
	[TrangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 5/26/2024 12:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](100) NOT NULL,
	[idDanhMuc] [int] NOT NULL,
	[Gia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/26/2024 12:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[TenHienThi] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
	[LoaiTaiKhoan] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinHoaDon]    Script Date: 5/26/2024 12:30:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinHoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idHoaDon] [int] NOT NULL,
	[idMonAn] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BanAn] ON 

INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (1, N'Bàn 1', 0, N'Khu vuc 1')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (2, N'Bàn 2', 0, N'Khu vuc 1')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (3, N'Bàn 3', 0, N'Khu vuc 1')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (4, N'Bàn 4', 0, N'Khu vuc 1')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (5, N'Bàn 5', 0, N'Khu vuc 1')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (6, N'Bàn 6', 1, N'Khu vuc 2')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (7, N'Bàn 7', 0, N'Khu vuc 2')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (8, N'Bàn 8', 0, N'Khu vuc 2')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (9, N'Bàn 9', 0, N'Khu vuc 2')
INSERT [dbo].[BanAn] ([id], [TenBan], [TrangThai], [KhuVuc]) VALUES (10, N'Bàn 10', 0, N'Khu vuc 3')
SET IDENTITY_INSERT [dbo].[BanAn] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([id], [TenDanhMuc]) VALUES (17, N'CÀ PHÊ PHIN')
INSERT [dbo].[DanhMuc] ([id], [TenDanhMuc]) VALUES (18, N'PHINDI')
INSERT [dbo].[DanhMuc] ([id], [TenDanhMuc]) VALUES (19, N'TRÀ')
INSERT [dbo].[DanhMuc] ([id], [TenDanhMuc]) VALUES (20, N'BÁNH')
INSERT [dbo].[DanhMuc] ([id], [TenDanhMuc]) VALUES (21, N'KEM')
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([id], [idBanAn], [ThoiGian], [TrangThai]) VALUES (96, 1, CAST(N'2024-05-26' AS Date), 1)
INSERT [dbo].[HoaDon] ([id], [idBanAn], [ThoiGian], [TrangThai]) VALUES (97, 2, CAST(N'2024-05-26' AS Date), 1)
INSERT [dbo].[HoaDon] ([id], [idBanAn], [ThoiGian], [TrangThai]) VALUES (98, 3, CAST(N'2024-05-26' AS Date), 1)
INSERT [dbo].[HoaDon] ([id], [idBanAn], [ThoiGian], [TrangThai]) VALUES (99, 4, CAST(N'2024-05-26' AS Date), 1)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[MonAn] ON 

INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (12, N'Cafe sữa đá', 17, 30000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (13, N'Cafe đen đá', 17, 25000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (14, N'Bạc xỉu', 17, 25000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (15, N'Cafe đen nóng', 17, 30000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (16, N'Cafe nguyên chất', 17, 35000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (17, N'Cafe nâu đá', 17, 30000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (18, N'Phindi hạnh nhân', 18, 25000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (19, N'Phindi kem sữa', 18, 40000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (20, N'Phindi choco', 18, 38000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (21, N'Phindi dâu tây', 18, 35000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (22, N'Trà xanh kemchee', 19, 45000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (23, N'Trà nhài', 19, 30000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (24, N'Trà hoa cúc', 19, 32000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (25, N'Trà đào cam xả', 19, 25000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (26, N'Trà thạch vải', 19, 30000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (27, N'Trà sen vàng', 19, 34000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (28, N'Bánh chuối', 20, 25000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (29, N'Bánh phomai chanh dây', 20, 32000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (30, N'Bánh sukem', 20, 36000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (31, N'Bánh sữa chua phomai', 20, 42000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (32, N'Bánh mì que', 20, 15000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (33, N'Kem dâu tây', 21, 25000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (34, N'Kem ốc quế', 21, 18000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (35, N'Kem sữa chua', 21, 16000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (36, N'Sữa chua dẻo', 21, 20000)
INSERT [dbo].[MonAn] ([id], [TenMonAn], [idDanhMuc], [Gia]) VALUES (37, N'Kem cuộn', 21, 15000)
SET IDENTITY_INSERT [dbo].[MonAn] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'admin', N'Thầy Tân', N'123', 0)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'tien', N'Tiến', N'1', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [TenHienThi], [MatKhau], [LoaiTaiKhoan]) VALUES (N'trang', N'Trang', N'1', 1)
GO
SET IDENTITY_INSERT [dbo].[ThongTinHoaDon] ON 

INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (149, 96, 18, 1)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (150, 96, 23, 4)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (151, 97, 24, 3)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (152, 97, 36, 2)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (153, 97, 13, 1)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (154, 98, 20, 1)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (155, 98, 21, 1)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (156, 98, 35, 1)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (157, 99, 23, 1)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (158, 99, 27, 1)
INSERT [dbo].[ThongTinHoaDon] ([id], [idHoaDon], [idMonAn], [SoLuong]) VALUES (159, 99, 25, 1)
SET IDENTITY_INSERT [dbo].[ThongTinHoaDon] OFF
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[MonAn] ADD  DEFAULT ((0)) FOR [Gia]
GO
ALTER TABLE [dbo].[ThongTinHoaDon] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idBanAn])
REFERENCES [dbo].[BanAn] ([id])
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD FOREIGN KEY([idDanhMuc])
REFERENCES [dbo].[DanhMuc] ([id])
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD FOREIGN KEY([idHoaDon])
REFERENCES [dbo].[HoaDon] ([id])
GO
ALTER TABLE [dbo].[ThongTinHoaDon]  WITH CHECK ADD FOREIGN KEY([idMonAn])
REFERENCES [dbo].[MonAn] ([id])
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanCafe] SET  READ_WRITE 
GO
