--Create Database QLThueNha
--Use QLThueNha
--Go

CREATE TABLE KhachHang(
   ID bigint IDENTITY(1,1),
   Ma nvarchar(10),
   Ten nvarchar(100) not null,
   DiaChi nvarchar(max),
   SDT nvarchar(15),
   ThongTinNhaMuonThue nvarchar(max), -- phần này không biết là để mô tả hay là loại nhà muốn thuê
   KhaNangThue nvarchar(max), -- này k biết có phải là khả năng thuê nhà khoảng bao nhiêu tiền k nữa
   IDChiNhanh int,
   Username nvarchar(20),
   Pass nvarchar(20),
   PRIMARY KEY(ID)
);

CREATE TABLE XemNha(
   ID bigint IDENTITY(1,1),
   IDKH bigint,
   IDNV bigint,
   IDNhaThue bigint,
   ThoiGianXem datetime,
   NhanSet nvarchar(max)
   PRIMARY KEY(ID)
);

CREATE TABLE HopDongThue(
   ID bigint IDENTITY(1,1),
   IDKH bigint,
   IDNV bigint,
   IDNhaThue bigint,
   ThoiGianKyHopDong datetime,
   GiaThueThang money,
   ThoiGianThue int, --tháng
   TongTien money
   PRIMARY KEY(ID)
);

select nv.Ma as MaNV, nv.Ten as TenNV, sum(hd.TongTien) as TongTien
from (select IDNV, TongTien, ThoiGianKyHopDong from HopDongThue where ThoiGianKyHopDong >= @tuNgay and ThoiGianKyHopDong <= @denNgay) as hd
inner join (select ID, Ma, Ten from NhanVien) as nv on hd.IDNV = nv.ID
group by nv.Ma, nv.Ten 

CREATE TABLE NhaChoThue(
   ID bigint IDENTITY(1,1),
   Ma nvarchar(10),
   DiaChi nvarchar(max),
   KhucVuc nvarchar(50),
   IDLoaiNha int,
   SoPhong int,
   GiaThue money,
   IDChuNha bigint,
   IDChiNhanh int
   PRIMARY KEY(ID)
);
update NhaChoThue set GiaThue = @giathue where Ma = @manha
select Ma, DiaChi, KhuVuc, SoPhong, GiaThue from NhaChoThue

--CREATE TABLE ChuNha(
--   ID bigint IDENTITY(1,1),
--   Ma nvarchar(10),
--   Ten nvarchar(100) not null,
--   DiaChi nvarchar(max),
--   SDT nvarchar(15),
--   PRIMARY KEY(ID)
--);
--

CREATE TABLE LoaiNha(
   ID int IDENTITY(1,1),
   Ma nvarchar(10),
   Ten nvarchar(100) not null,
   PRIMARY KEY(ID)
);

CREATE TABLE NhanVien(
   ID bigint IDENTITY(1,1),
   Ma nvarchar(10),
   Ten nvarchar(100) not null,
   DiaChi nvarchar(max),
   SDT nvarchar(15),
   GioiTinh bit, --1: nam, 0: nu
   NgaySinh datetime,
   Luong money,
   IDChiNhanh int
   PRIMARY KEY(ID)
);

CREATE TABLE ChiNhanh(
   ID int IDENTITY(1,1),
   Ma nvarchar(10),
   Ten nvarchar(100),
   DiaChi nvarchar(max),
   KhuVuc nvarchar(50),
   SDT nvarchar(15),
   FAX nvarchar(20),
   PRIMARY KEY(ID)
);

ALTER TABLE KhachHang ADD CONSTRAINT fk_KhachHang_ChiNhanh
FOREIGN KEY(IDChiNhanh) REFERENCES ChiNhanh(ID);

ALTER TABLE NhanVien ADD CONSTRAINT fk_NhanVien_ChiNhanh
FOREIGN KEY(IDChiNhanh) REFERENCES ChiNhanh(ID);

--NhaChoThue
ALTER TABLE NhaChoThue ADD CONSTRAINT fk_NhanVien_LoaiNha
FOREIGN KEY(IDLoaiNha) REFERENCES LoaiNha(ID);

--ALTER TABLE NhaChoThue ADD CONSTRAINT fk_NhanVien_ChuNha
--FOREIGN KEY(IDChuNha) REFERENCES ChuNha(ID);


ALTER TABLE NhaChoThue ADD CONSTRAINT fk_NhaChoThue_ChiNhanh
FOREIGN KEY(IDChiNhanh) REFERENCES ChiNhanh(ID);

--XemNha
ALTER TABLE XemNha ADD CONSTRAINT fk_XemNha_KhachHang
FOREIGN KEY(IDKH) REFERENCES KhachHang(ID);

ALTER TABLE XemNha ADD CONSTRAINT fk_XemNha_NhanVien
FOREIGN KEY(IDNV) REFERENCES NhanVien(ID);

ALTER TABLE XemNha ADD CONSTRAINT fk_XemNha_NhaChoThue
FOREIGN KEY(IDNhaThue) REFERENCES NhaChoThue(ID);

--HopDongThue
ALTER TABLE HopDongThue ADD CONSTRAINT fk_HopDongThue_KhachHang
FOREIGN KEY(IDKH) REFERENCES KhachHang(ID);

ALTER TABLE HopDongThue ADD CONSTRAINT fk_HopDongThue_NhanVien
FOREIGN KEY(IDNV) REFERENCES NhanVien(ID);

ALTER TABLE HopDongThue ADD CONSTRAINT fk_HopDongThue_NhaChoThue
FOREIGN KEY(IDNhaThue) REFERENCES NhaChoThue(ID);

--add 19-09-2019
ALTER TABLE NhaChoThue DROP CONSTRAINT fk_NhanVien_ChuNha;
DROP TABLE ChuNha;

Alter table KhachHang Add Username nvarchar(20);
Alter table KhachHang Add Pass nvarchar(20);

ALTER TABLE NhaChoThue ADD CONSTRAINT fk_NhanVien_KhachHang
FOREIGN KEY(IDChuNha) REFERENCES KhachHang(ID);

Alter table NhanVien Add IDChucVu int default 2; -- 1: admin, 2: nhanvien
--insert into NhanVien(Ma, Ten, Username, Pass, IDChucVu)