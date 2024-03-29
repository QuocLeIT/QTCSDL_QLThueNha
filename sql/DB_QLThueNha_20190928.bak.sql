USE [master]
GO
/****** Object:  Database [QLThueNha]    Script Date: 09/28/2019 11:36:45 AM ******/
If DB_ID ('QLThueNha') is not NULL
	Drop Database QLThueNha
CREATE DATABASE [QLThueNha]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThueNha].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThueNha] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLThueNha] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLThueNha] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLThueNha] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLThueNha] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLThueNha] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLThueNha] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLThueNha] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLThueNha] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLThueNha] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLThueNha] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLThueNha] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLThueNha] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLThueNha] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLThueNha] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLThueNha] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLThueNha] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLThueNha] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLThueNha] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLThueNha] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLThueNha] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLThueNha] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLThueNha] SET RECOVERY FULL 
GO
ALTER DATABASE [QLThueNha] SET  MULTI_USER 
GO
ALTER DATABASE [QLThueNha] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLThueNha] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLThueNha] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLThueNha] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLThueNha]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 09/28/2019 11:36:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [nvarchar](10) NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[KhuVuc] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
	[FAX] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HopDongThue]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDongThue](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDKH] [bigint] NULL,
	[IDNV] [bigint] NULL,
	[IDNhaThue] [bigint] NULL,
	[ThoiGianKyHopDong] [datetime] NULL,
	[GiaThueThang] [money] NULL,
	[ThoiGianThue] [int] NULL,
	[TongTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Ma] [nvarchar](10) NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](15) NULL,
	[ThongTinNhaMuonThue] [nvarchar](max) NULL,
	[KhaNangThue] [nvarchar](max) NULL,
	[IDChiNhanh] [int] NULL,
	[Username] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL,
	[isChoThueNha] [bit] NULL,
	[isThueNha] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNha]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNha](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [nvarchar](10) NULL,
	[Ten] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaChoThue]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaChoThue](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Ma] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[KhucVuc] [nvarchar](50) NULL,
	[IDLoaiNha] [int] NULL,
	[SoPhong] [int] NULL,
	[GiaThue] [money] NULL,
	[IDChuNha] [bigint] NULL,
	[IDChiNhanh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Ma] [nvarchar](10) NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [nvarchar](15) NULL,
	[GioiTinh] [bit] NULL,
	[NgaySinh] [datetime] NULL,
	[Luong] [money] NULL,
	[IDChiNhanh] [int] NULL,
	[IDChucVu] [int] NULL DEFAULT ((2)),
	[Username] [nvarchar](20) NULL,
	[Pass] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XemNha]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XemNha](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDKH] [bigint] NULL,
	[IDNV] [bigint] NULL,
	[IDNhaThue] [bigint] NULL,
	[ThoiGianXem] [datetime] NULL,
	[NhanSet] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChiNhanh] ON 

INSERT [dbo].[ChiNhanh] ([ID], [Ma], [Ten], [DiaChi], [KhuVuc], [SDT], [FAX]) VALUES (1, N'HN', N'TĐ.Hà Nội', N'Thủ Đô Hà Nội', N'Miền Bắc', N'', N'')
INSERT [dbo].[ChiNhanh] ([ID], [Ma], [Ten], [DiaChi], [KhuVuc], [SDT], [FAX]) VALUES (2, N'HCM', N'TP.Hồ Chí Minh', N'TP.Hồ Chí Minh', N'Miền Nam', N'', N'')
INSERT [dbo].[ChiNhanh] ([ID], [Ma], [Ten], [DiaChi], [KhuVuc], [SDT], [FAX]) VALUES (3, N'DN', N'TP.Đà Nẵng', N'TP.Đà Nẵng', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[ChiNhanh] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [Ma], [Ten], [DiaChi], [SDT], [ThongTinNhaMuonThue], [KhaNangThue], [IDChiNhanh], [Username], [Pass], [isChoThueNha], [isThueNha]) VALUES (1, N'KH1', N'KH1', N'', N'', N'', N'', 2, N'KH1', N'123456', 1, 1)
INSERT [dbo].[KhachHang] ([ID], [Ma], [Ten], [DiaChi], [SDT], [ThongTinNhaMuonThue], [KhaNangThue], [IDChiNhanh], [Username], [Pass], [isChoThueNha], [isThueNha]) VALUES (3, N'kh2', N'kh2', N'', N'', N'', N'', 2, N'kh2', N'123', 0, 1)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiNha] ON 

INSERT [dbo].[LoaiNha] ([ID], [Ma], [Ten]) VALUES (2, N'N2', N'Nhà 2 phòng ngủ, 1 tolet')
SET IDENTITY_INSERT [dbo].[LoaiNha] OFF
SET IDENTITY_INSERT [dbo].[NhaChoThue] ON 

INSERT [dbo].[NhaChoThue] ([ID], [Ma], [DiaChi], [KhucVuc], [IDLoaiNha], [SoPhong], [GiaThue], [IDChuNha], [IDChiNhanh]) VALUES (1, N'n1', N'tphcm', N'mien nam', 2, 2, 100000.0000, 1, 2)
SET IDENTITY_INSERT [dbo].[NhaChoThue] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [Ma], [Ten], [DiaChi], [SDT], [GioiTinh], [NgaySinh], [Luong], [IDChiNhanh], [IDChucVu], [Username], [Pass]) VALUES (1, N'Admin', N'Admin', NULL, NULL, NULL, NULL, NULL, 1, 1, N'admin', N'123')
INSERT [dbo].[NhanVien] ([ID], [Ma], [Ten], [DiaChi], [SDT], [GioiTinh], [NgaySinh], [Luong], [IDChiNhanh], [IDChucVu], [Username], [Pass]) VALUES (2, N'ABCT36', N'ABCT36', N'', N'0123', 1, CAST(N'2000-09-25 22:39:40.000' AS DateTime), 1.0000, 2, 2, N'ABCT36', N'123')
INSERT [dbo].[NhanVien] ([ID], [Ma], [Ten], [DiaChi], [SDT], [GioiTinh], [NgaySinh], [Luong], [IDChiNhanh], [IDChucVu], [Username], [Pass]) VALUES (5, N'NV1', N'NV1', N'', N'0123', 1, CAST(N'2000-09-25 22:39:40.000' AS DateTime), 2.0000, 3, 2, N'NV2', N'123')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
ALTER TABLE [dbo].[HopDongThue]  WITH CHECK ADD  CONSTRAINT [fk_HopDongThue_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [fk_HopDongThue_KhachHang]
GO
ALTER TABLE [dbo].[HopDongThue]  WITH CHECK ADD  CONSTRAINT [fk_HopDongThue_NhaChoThue] FOREIGN KEY([IDNhaThue])
REFERENCES [dbo].[NhaChoThue] ([ID])
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [fk_HopDongThue_NhaChoThue]
GO
ALTER TABLE [dbo].[HopDongThue]  WITH CHECK ADD  CONSTRAINT [fk_HopDongThue_NhanVien] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HopDongThue] CHECK CONSTRAINT [fk_HopDongThue_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [fk_KhachHang_ChiNhanh] FOREIGN KEY([IDChiNhanh])
REFERENCES [dbo].[ChiNhanh] ([ID])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [fk_KhachHang_ChiNhanh]
GO
ALTER TABLE [dbo].[NhaChoThue]  WITH CHECK ADD  CONSTRAINT [fk_NhaChoThue_ChiNhanh] FOREIGN KEY([IDChiNhanh])
REFERENCES [dbo].[ChiNhanh] ([ID])
GO
ALTER TABLE [dbo].[NhaChoThue] CHECK CONSTRAINT [fk_NhaChoThue_ChiNhanh]
GO
ALTER TABLE [dbo].[NhaChoThue]  WITH CHECK ADD  CONSTRAINT [fk_NhanVien_KhachHang] FOREIGN KEY([IDChuNha])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[NhaChoThue] CHECK CONSTRAINT [fk_NhanVien_KhachHang]
GO
ALTER TABLE [dbo].[NhaChoThue]  WITH CHECK ADD  CONSTRAINT [fk_NhanVien_LoaiNha] FOREIGN KEY([IDLoaiNha])
REFERENCES [dbo].[LoaiNha] ([ID])
GO
ALTER TABLE [dbo].[NhaChoThue] CHECK CONSTRAINT [fk_NhanVien_LoaiNha]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_NhanVien_ChiNhanh] FOREIGN KEY([IDChiNhanh])
REFERENCES [dbo].[ChiNhanh] ([ID])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[XemNha]  WITH CHECK ADD  CONSTRAINT [fk_XemNha_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([ID])
GO
ALTER TABLE [dbo].[XemNha] CHECK CONSTRAINT [fk_XemNha_KhachHang]
GO
ALTER TABLE [dbo].[XemNha]  WITH CHECK ADD  CONSTRAINT [fk_XemNha_NhaChoThue] FOREIGN KEY([IDNhaThue])
REFERENCES [dbo].[NhaChoThue] ([ID])
GO
ALTER TABLE [dbo].[XemNha] CHECK CONSTRAINT [fk_XemNha_NhaChoThue]
GO
ALTER TABLE [dbo].[XemNha]  WITH CHECK ADD  CONSTRAINT [fk_XemNha_NhanVien] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[XemNha] CHECK CONSTRAINT [fk_XemNha_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdate_KhachHang]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_InsertUpdate_KhachHang]
@ID int,
@Ma nvarchar(10),
@Ten nvarchar(100),
@SDT nvarchar(15),
@DiaChi nvarchar(max),
@isChoThueNha bit,
@isThueNha bit,
@ThongTin nvarchar(max),
@KhaNang nvarchar(max),
@idChiNhanh int

as
declare @result int

begin tran
	BEGIN TRY

	if @ID < 1 --insert
	begin
		if Exists(select ID from KhachHang where Ma = @Ma)
		begin
			return -2;
		end
		
		insert into KhachHang(Ma, Ten, SDT, DiaChi, isChoThueNha, isThueNha, ThongTinNhaMuonThue, KhaNangThue, IDChiNhanh)
		values(@Ma, @Ten, @SDT, @DiaChi, @isChoThueNha, @isThueNha, @ThongTin, @KhaNang, @IDChiNhanh)

		set @result =(select @@identity)
	end
	else -- update
	begin
		if Exists(select ID from KhachHang where Ma = @Ma and ID <> @ID)
		begin
			return -2; --trung ma
		end
		
		update KhachHang set Ma = @Ma, Ten = @Ten, SDT = @SDT, DiaChi = @DiaChi, 
			isChoThueNha = @isChoThueNha, isThueNha = @isThueNha, ThongTinNhaMuonThue = @ThongTin, KhaNangThue = @KhaNang, IDChiNhanh = @IDChiNhanh
		where ID = @ID

		set @result = @ID
	end

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result






GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdate_NhaChiThue]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_InsertUpdate_NhaChiThue]
@ID int,
@Ma nvarchar(10),
@DiaChi nvarchar(max),
@KhuVuc nvarchar(max),
@SoPhong int,
@Gia money,
@idLoaiNha int,
@idChiNhanh int,
@idChuNha int
as
declare @result int

begin tran
	BEGIN TRY

	if @ID < 1 --insert
	begin
		if Exists(select ID from NhaChoThue where Ma = @Ma)
		begin
			return -2;
		end
		
		insert into NhaChoThue(Ma, DiaChi, KhucVuc, SoPhong, GiaThue, IDLoaiNha, IDChiNhanh, IDChuNha)
		values(@Ma, @DiaChi, @KhuVuc, @SoPhong, @Gia, @idLoaiNha, @idChiNhanh, @idChuNha)

		set @result =(select @@identity)
	end
	else -- update
	begin
		if Exists(select ID from NhaChoThue where Ma = @Ma and ID <> @ID)
		begin
			return -2; --trung ma
		end
				
		update NhaChoThue set Ma = @Ma, DiaChi = @DiaChi, KhucVuc = @KhuVuc, SoPhong = @SoPhong, GiaThue = @Gia, IDLoaiNha = @idLoaiNha, IDChiNhanh = @idChiNhanh, IDChuNha = @idChuNha
		where ID = @ID

		set @result = @ID
	end

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result






GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdate_XemNha]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_InsertUpdate_XemNha]
@ID int,
@idKhachHang int,
@idNhanVien int,
@thoiGian datetime,
@idNhaXem int,
@nhanXet nvarchar(max)
as
declare @result int

begin tran
	BEGIN TRY

	if (isnull((select IDChuNha from NhaChoThue where ID = @idNhaXem), 0) = @idKhachHang)
	begin
		return -2; -- khach hang trung chu nha
	end

	if @ID < 1 --insert
	begin
		insert into XemNha(IDKH, IDNV, ThoiGianXem, IDNhaThue, NhanSet)
		values(@idKhachHang, @idNhanVien, @thoiGian, @idNhaXem, @nhanXet)

		set @result =(select @@identity)
	end
	else -- update
	begin
		update XemNha set IDKH = @idKhachHang, IDNV = @idNhanVien, ThoiGianXem = @thoiGian, IDNhaThue = @idNhaXem, NhanSet = @nhanXet
		where ID = @ID

		set @result = @ID
	end

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result






GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateChiNhanh]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_InsertUpdateChiNhanh]
@ID int,
@Ma nvarchar(10),
@Ten nvarchar(100),
@SDT nvarchar(15),
@FAX nvarchar(20),
@DiaChi nvarchar(max),
@KhuVuc nvarchar(50)
as
declare @result int

begin tran
	BEGIN TRY

	if @ID < 1 --insert
	begin
		if Exists(select ID from ChiNhanh where Ma = @Ma)
		begin
			set @result = -2; --trung ma
		end
		else
		begin
			insert into ChiNhanh(Ma, Ten, SDT, FAX, DiaChi, KhuVuc)
			values(@Ma, @Ten, @SDT, @FAX, @DiaChi, @KhuVuc)

			set @result =(select @@identity)
		end
		
	end
	else -- update
	begin
		if Exists(select ID from ChiNhanh where Ma = @Ma and ID <> @ID)
		begin
			set @result = -2; --trung ma
		end
		else
		begin
			update ChiNhanh set Ma = @Ma, Ten = @Ten, SDT = @SDT, FAX = @FAX, DiaChi = @DiaChi, KhuVuc = @KhuVuc
			where ID = @ID

			set @result = @ID
		end
	end

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result






GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateNhanVien]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_InsertUpdateNhanVien]
@ID int,
@Ma nvarchar(10),
@Ten nvarchar(100),
@DiaChi nvarchar(max),
@SDT nvarchar(15),
@GioiTinh bit,
@NgaySinh datetime,
@Luong money,
@IDChiNhanh int
--@Username nvarchar(50),
--@Password nvarchar(50)
as
declare @result int

begin tran
	BEGIN TRY

	if @ID < 1 --insert
	begin
		if Exists(select ID from NhanVien where Ma = @Ma)
		begin
			return -2;
		end
		
		insert into NhanVien(Ma, Ten, DiaChi, SDT, GioiTinh, NgaySinh, Luong, IDChiNhanh)
		values(@Ma, @Ten, @DiaChi, @SDT, @GioiTinh, @NgaySinh, @Luong, @IDChiNhanh)

		set @result =(select @@identity)
	end
	else -- update
	begin
		if Exists(select ID from NhanVien where Ma = @Ma and ID <> @ID)
		begin
			return -2; --trung ma
		end
				
		update NhanVien set Ma = @Ma, Ten = @Ten, DiaChi = @DiaChi, SDT = @SDT, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, Luong = @Luong, IDChiNhanh =@IDChiNhanh
		where ID = @ID

		set @result = @ID
	end

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result






GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUsernamePass_KhachHang]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_UpdateUsernamePass_KhachHang]
@ID int,
@Username nvarchar(50),
@Password nvarchar(50)
as
declare @result int

begin tran
	BEGIN TRY

	if Exists(select ID from KhachHang where Username = @Username and ID <> @ID)
	begin
		return -3;
	end
		
		update KhachHang set Username = @Username, Pass = @Password where ID = @ID

		set @result =@ID

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result






GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUsernamePass_NhanVien]    Script Date: 09/28/2019 11:36:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_UpdateUsernamePass_NhanVien]
@ID int,
@Username nvarchar(50),
@Password nvarchar(50)
as
declare @result int

begin tran
	BEGIN TRY

	if Exists(select ID from NhanVien where Username = @Username and ID <> @ID)
	begin
		return -3;
	end
		
		update NhanVien set Username = @Username, Pass = @Password where ID = @ID

		set @result =@ID

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result






GO
USE [master]
GO
ALTER DATABASE [QLThueNha] SET  READ_WRITE 
GO
