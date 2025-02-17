USE [master]
GO
/****** Object:  Database [SQLQLTS]    Script Date: 1/30/2024 3:14:33 AM ******/
CREATE DATABASE [SQLQLTS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SQLQLTS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SQLQLTS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SQLQLTS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\SQLQLTS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SQLQLTS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SQLQLTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SQLQLTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SQLQLTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SQLQLTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SQLQLTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SQLQLTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SQLQLTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SQLQLTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SQLQLTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SQLQLTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SQLQLTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SQLQLTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SQLQLTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SQLQLTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SQLQLTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SQLQLTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SQLQLTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SQLQLTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SQLQLTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SQLQLTS] SET RECOVERY FULL 
GO
ALTER DATABASE [SQLQLTS] SET  MULTI_USER 
GO
ALTER DATABASE [SQLQLTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SQLQLTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SQLQLTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SQLQLTS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SQLQLTS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SQLQLTS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SQLQLTS] SET QUERY_STORE = OFF
GO
USE [SQLQLTS]
GO
/****** Object:  User [DB_A6CCC2_quanlytaisan_admin]    Script Date: 1/30/2024 3:14:33 AM ******/
CREATE USER [DB_A6CCC2_quanlytaisan_admin] FOR LOGIN [DB_A6CCC2_quanlytaisan_admin] WITH DEFAULT_SCHEMA=[db_accessadmin]
GO
ALTER ROLE [db_owner] ADD MEMBER [DB_A6CCC2_quanlytaisan_admin]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](128) NOT NULL,
	[DisplayName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDatPhong]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatPhong](
	[MaDatPhong] [varchar](20) NOT NULL,
	[MaNguoiDatPhong] [varchar](20) NULL,
	[MaPhong] [varchar](20) NULL,
	[NgayDatPhong] [varchar](50) NULL,
 CONSTRAINT [PK_ChiTietDatPhong] PRIMARY KEY CLUSTERED 
(
	[MaDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[MaDatPhong] [varchar](20) NOT NULL,
	[MaPhong] [varchar](20) NULL,
	[MaNhanVien] [varchar](20) NULL,
	[ThoiGianDatPhong] [varchar](20) NULL,
	[ThoiGianTraPhong] [varchar](20) NULL,
	[GhiChu] [nvarchar](150) NULL,
 CONSTRAINT [PK_DatPhong] PRIMARY KEY CLUSTERED 
(
	[MaDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDonViTinh] [varchar](20) NOT NULL,
	[TenDonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[MaDonViTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KiemKeTaiSan]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KiemKeTaiSan](
	[MaKiemKe] [varchar](20) NOT NULL,
	[MaTaiSan] [varchar](20) NULL,
	[NguyenGia] [int] NULL,
	[ThoiGianKKhauHau] [date] NULL,
	[MucKhauHau] [nvarchar](50) NULL,
	[NgayDuaVaoSuDung] [date] NULL,
	[ThoiGianSuDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_KIEMKETAISAN] PRIMARY KEY CLUSTERED 
(
	[MaKiemKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTaiSan]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiSan](
	[MaLoaiTaiSan] [varchar](20) NOT NULL,
	[TenLoaiTaiSan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LOAITAISAN] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [varchar](20) NOT NULL,
	[TenNhaCungCap] [nvarchar](150) NULL,
	[DiaChiNhaCungCap] [nvarchar](350) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](350) NULL,
	[SDT] [nchar](14) NULL,
	[ChucVu] [nvarchar](100) NULL,
	[MaPhongBan] [varchar](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThanhLy]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThanhLy](
	[MaThanhLy] [varchar](20) NOT NULL,
	[MaTaiSan] [varchar](20) NOT NULL,
	[SoLuongThanhLy] [int] NOT NULL,
	[GiaThanhLy] [int] NOT NULL,
	[NgayThanhLy] [varchar](100) NOT NULL,
	[NguoiThanhLy] [varchar](20) NOT NULL,
	[NguoiMua] [nvarchar](250) NULL,
 CONSTRAINT [PK_PHIEUTHANHLY] PRIMARY KEY CLUSTERED 
(
	[MaThanhLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](20) NOT NULL,
	[TenPhong] [nvarchar](150) NULL,
	[DienTich] [decimal](18, 0) NULL,
	[ViTri] [nvarchar](150) NULL,
	[TrangThai] [tinyint] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhong] [varchar](20) NOT NULL,
	[TenPhong] [nvarchar](150) NOT NULL,
	[SoPhong] [int] NOT NULL,
	[DienTich] [float] NULL,
	[ViTri] [nvarchar](150) NOT NULL,
	[TrangThaiPhong] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuaChuaTaiSan]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuaChuaTaiSan](
	[MaSuaChua] [varchar](20) NOT NULL,
	[MaTaiSan] [varchar](20) NULL,
	[NgaySuaChua] [datetime] NULL,
	[GiaSuaChua] [int] NULL,
	[NguoiSuaChua] [varchar](20) NULL,
	[HinhThucSuaChua] [nvarchar](150) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TrangThai] [varchar](10) NULL,
 CONSTRAINT [PK_SUACHUATAISAN] PRIMARY KEY CLUSTERED 
(
	[MaSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiSan]    Script Date: 1/30/2024 3:14:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiSan](
	[MaTaiSan] [varchar](20) NOT NULL,
	[TenTaiSan] [nvarchar](150) NULL,
	[Gia] [int] NULL,
	[MaLoaiTaiSan] [varchar](20) NULL,
	[MaDonViTinh] [varchar](20) NULL,
	[MaNhaCungCap] [varchar](20) NULL,
	[HinhMinhHoa] [nvarchar](250) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[NgayNhap] [datetime] NULL,
	[MaNguoiNhap] [varchar](20) NULL,
	[ThongSoKyThuat] [nvarchar](50) NULL,
	[ThoiGianTinhKhauHau] [datetime] NULL,
	[ThoiGianBaoHanh] [nchar](10) NULL,
	[MaPhong] [varchar](20) NULL,
 CONSTRAINT [PK_TAISAN] PRIMARY KEY CLUSTERED 
(
	[MaTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'Admin     ', N'827CCB0EEA8A706C4C34A16891F84E7B                                                                                                ', N'MinhUNETI')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'khanhpham ', N'827CCB0EEA8A706C4C34A16891F84E7B                                                                                                ', N'Khanh')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'user001   ', N'827CCB0EEA8A706C4C34A16891F84E7B                                                                                                ', N'Nhân Viên 001')
GO
INSERT [dbo].[ChiTietDatPhong] ([MaDatPhong], [MaNguoiDatPhong], [MaPhong], [NgayDatPhong]) VALUES (N'MDP_HJGCFOP', N'NV_WFMKWQB', N'PB_AGFSAHT', N'12/15/2020 10:03:17')
GO
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_AEEOBOA', N'P_AQVDRNJ', N'NV_DDEEAWA', N'1/29/2024 8:13:31 PM', N'2024-01-29 20:13:16', N'H?p cu?i nam')
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_NTTFNFV', N'P_AQVDRNJ', N'NV_DDEEAWA', N'1/29/2024 8:27:36 PM', N'2024-01-29 20:27:32', N'')
GO
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_ECORNPK', N'Chiếc')
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_NVLJHEA', N'Bộ')
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_OUFKSHX', N'Đôi')
GO
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_AKYGKOB', N'Bàn Ghế')
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_BTIVRMY', N'Thiết Bị')
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_HLLYUYS', N'Linh Kiện')
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_OFOTLLX', N'Đồ Tiện Nghi')
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_ADVJDYS', N'Điện Máy Xanh', N'Tam Trinh- Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_DSPQKRD', N'Panasonic', N'Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_EMQALXI', N'BaoChau ELEC', N'Phố Vọng-Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_JOJJAIC', N'Hà Nội Computer', N'Hai Bà Trưng - Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_SJFGYRO', N'Nội thất văn phòng Như Quỳnh', N'Đồng Kị-Bắc Ninh')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [SDT], [ChucVu], [MaPhongBan]) VALUES (N'NV_DDEEAWA', N'Phạm Khánh', N'Hà Nội', N'123456        ', N'0', N'PB_YINTMGY')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [SDT], [ChucVu], [MaPhongBan]) VALUES (N'NV_KLUXSVI', N'Nhan Vien 001', N'Khanh Hoa', N'0369962642    ', N'0', NULL)
GO
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_AESDDCH', N'TS_DSBTQPL', 1, 2000000, N'1/29/2024 8:15:25 PM', N'NV_DDEEAWA', N'Dương Minh')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_HJKAGMA', N'TS_WQPTQBM', 1, 10000, N'11/17/2020 14:24:31', N'NV_WFMKWQB', N'Nguyễn Văn A')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_RCEECBH', N'TS_WQPTQBM', 2, 10000, N'11/17/2020 15:52:34', N'NV_WFMKWQB', N'Bình')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_RVMSHIL', N'TS_YUPXNWO', 1, 1000, N'12/15/2020 10:42:13', N'NV_KLUXSVI', N'City A')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_SDKHAND', N'TS_WQPTQBM', 1, 10000, N'11/17/2020 15:51:55', N'NV_KLUXSVI', N'Nguyễn Văn B')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_SMLEOSD', N'TS_HLYFRBI', 2, 40000, N'11/17/2020 16:02:25', N'NV_TUFGQBX', N'Mai Thị Dõng')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_WBJSXYU', N'TS_WQPTQBM', 2, 10000, N'11/17/2020 15:51:27', N'NV_TUFGQBX', N'Mai Thị Dõng')
GO
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [DienTich], [ViTri], [TrangThai]) VALUES (N'P_AQVDRNJ', N'G03', CAST(34 AS Decimal(18, 0)), N'Khu A - Tầng 2', 1)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [DienTich], [ViTri], [TrangThai]) VALUES (N'P_GOWIWCX', N'G02', CAST(34 AS Decimal(18, 0)), N'Khu A - Tầng 3', 0)
GO
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_AGFSAHT', N'Phong Họp 1', 33, 100, N'Khu A', N'1')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_OUYLIFW', N'Phòng họp 2', 31, 38, N'Khu A', N'0')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_YINTMGY', N'Phòng lập trình', 100, 343, N'Khu B', N'1')
GO
INSERT [dbo].[SuaChuaTaiSan] ([MaSuaChua], [MaTaiSan], [NgaySuaChua], [GiaSuaChua], [NguoiSuaChua], [HinhThucSuaChua], [GhiChu], [TrangThai]) VALUES (N'SC_HYILQKH', N'TS_JRYVNWQ', CAST(N'2020-11-19T09:16:06.000' AS DateTime), 0, N'NV_TUFGQBX', N'', N'ok', N'1')
INSERT [dbo].[SuaChuaTaiSan] ([MaSuaChua], [MaTaiSan], [NgaySuaChua], [GiaSuaChua], [NguoiSuaChua], [HinhThucSuaChua], [GhiChu], [TrangThai]) VALUES (N'SC_RNVBGUB', N'TS_HLYFRBI', CAST(N'2020-11-19T09:42:30.000' AS DateTime), 1000, N'NV_KLUXSVI', N'Sửa Mất Tiền', N'ok', N'0')
INSERT [dbo].[SuaChuaTaiSan] ([MaSuaChua], [MaTaiSan], [NgaySuaChua], [GiaSuaChua], [NguoiSuaChua], [HinhThucSuaChua], [GhiChu], [TrangThai]) VALUES (N'SC_VTCBYUB', N'TS_DSBTQPL', CAST(N'2024-01-29T20:15:06.000' AS DateTime), 2000000, N'NV_DDEEAWA', N'Sửa Mất Tiền', N'Mốc lens', N'Ch? x? lý')
INSERT [dbo].[SuaChuaTaiSan] ([MaSuaChua], [MaTaiSan], [NgaySuaChua], [GiaSuaChua], [NguoiSuaChua], [HinhThucSuaChua], [GhiChu], [TrangThai]) VALUES (N'SC_XIUVHNT', N'TS_HLYFRBI', CAST(N'2020-11-19T09:15:28.000' AS DateTime), 100, N'NV_KLUXSVI', N'Sửa Mất Tiền', N'ok', N'Ðã s?a')
GO
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_DSBTQPL', N'Máy Chiếu', 2000000, N'LTS_BTIVRMY', N'DVT_ECORNPK', N'NCC_DSPQKRD', N'\Image\maychieu.jpg', N'Máy Chiếu panasonic', N'0', CAST(N'2023-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_AQVDRNJ')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_EPSCYES', N'Máy Fax', 5000000, N'LTS_AKYGKOB', N'DVT_ECORNPK', N'NCC_DSPQKRD', N'\Image\mayfax2.jpg', N'', N'1', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_GOWIWCX')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_HMDNXVK', N'Bàn ghế họp', 1000000, N'LTS_AKYGKOB', N'DVT_NVLJHEA', N'NCC_SJFGYRO', N'\Image\banghe.jpg', N'1 bàn+ 10 ghế', N'1', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_AQVDRNJ')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_KVSGTKJ', N'Máy Lọc Nước', 5000000, N'LTS_OFOTLLX', N'DVT_ECORNPK', N'NCC_ADVJDYS', N'\Image\maylocnuoc.jpg', N'Máy Lọc Nước Kangaroo', N'1', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_GOWIWCX')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_NDUTAKB', N'Máy Fax', 3000000, N'LTS_OFOTLLX', N'DVT_ECORNPK', N'NCC_ADVJDYS', N'\Image\mayfax.jpg', N'', N'1', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_AQVDRNJ')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_PDLYYKT', N'Máy Tính bàn', 30000000, N'LTS_BTIVRMY', N'DVT_ECORNPK', N'NCC_JOJJAIC', N'\Image\maytinh.jpg', N'PC phòng họp', N'1', CAST(N'2022-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_AQVDRNJ')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_PHQUQDQ', N'Dàn Loa', 40000000, N'LTS_AKYGKOB', N'DVT_NVLJHEA', N'NCC_EMQALXI', N'\Image\loadai.jpg', N'Loa + Âm ly+ Micro', N'1', CAST(N'2022-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_GOWIWCX')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_SQRXCMY', N'Máy Lọc Nước', 5000000, N'LTS_AKYGKOB', N'DVT_ECORNPK', N'NCC_ADVJDYS', N'\Image\maylocnuoc.jpg', N'Máy lọc nước Kangaroo', N'1', CAST(N'2023-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_AQVDRNJ')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_UMVXHTQ', N'Máy Chiếu ', 20000000, N'LTS_BTIVRMY', N'DVT_ECORNPK', N'NCC_DSPQKRD', N'\Image\maychieu.jpg', N'Panasonic', N'1', CAST(N'2023-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_GOWIWCX')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_UQWPXRG', N'Máy Tính Bàn', 3000000, N'LTS_BTIVRMY', N'DVT_ECORNPK', N'NCC_JOJJAIC', N'\Image\maytinh.jpg', N'Máy tính phòng họp', N'1', CAST(N'2022-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_GOWIWCX')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_VIQVGHM', N'Bàn ghế họp 2', 8000000, N'LTS_AKYGKOB', N'DVT_ECORNPK', N'NCC_SJFGYRO', N'\Image\banghe2.jpg', N'1 bàn + 10 ghế', N'1', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_GOWIWCX')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_WRNSGAM', N'Dàn Loa', 40000000, N'LTS_AKYGKOB', N'DVT_NVLJHEA', N'NCC_EMQALXI', N'\Image\loadai.jpg', N'Loa + Âm ly + Micro', N'1', CAST(N'2021-01-29T00:00:00.000' AS DateTime), N'NV_KLUXSVI', N'', CAST(N'2024-01-29T00:00:00.000' AS DateTime), N'2024-01-29', N'P_AQVDRNJ')
GO
ALTER TABLE [dbo].[SuaChuaTaiSan] ADD  CONSTRAINT [DF_SuaChuaTaiSan_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
/****** Object:  StoredProcedure [dbo].[HoaDonTimKiem]    Script Date: 1/30/2024 3:14:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[HoaDonTimKiem]
(
	@MaHD char(30),
	@MaKH char(30)
) 
as select * from HoaDon  where MaHD like '%'+@MaHD+'%' or HoaDon.MaKH like '%'+@MaKH+'%'
GO
/****** Object:  StoredProcedure [dbo].[KhachHangTimKiem]    Script Date: 1/30/2024 3:14:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[KhachHangTimKiem]
(
	@TenKH nvarchar(50),
	@MaKH char(30)
)
as select * from KhachHang where TenKH like N'%'+@TenKH+'%' or MaKH like '%'+@MaKH+'%' 
GO
/****** Object:  StoredProcedure [dbo].[NCCTimKiem]    Script Date: 1/30/2024 3:14:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NCCTimKiem]
(
	@MaCC char(30),  
	@TenCC Nvarchar(100)
)
as select * from NhaCC
where TenCC like N'%'+@TenCC+'%' or MaCC like '%'+@MaCC+'%'  
GO
/****** Object:  StoredProcedure [dbo].[NhapKhoTimKiem]    Script Date: 1/30/2024 3:14:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NhapKhoTimKiem]
(
		@MaNK nvarchar(50),
		@MaTB char(30)
)
as select * from NhapKho where MaNK like '%'+@MaNK+'%' or MaTB like '%'+@MaTB+'%'
GO
/****** Object:  StoredProcedure [dbo].[ThietBiTimKiem]    Script Date: 1/30/2024 3:14:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThietBiTimKiem]
(
	@MaTB char(30) ,
	@MaCC char(30) ,
	@TenTB Nvarchar(100) ,
	@LoaiTB Nvarchar(100)
)
as select * from ThietBi where MaTB like '%'+@MaTB+'%' or MaCC like '%'+@MaCC+'%' or TenTB like '%'+@TenTB+'%' or LoaiTB like '%'+@LoaiTB+'%'
GO
USE [master]
GO
ALTER DATABASE [SQLQLTS] SET  READ_WRITE 
GO
