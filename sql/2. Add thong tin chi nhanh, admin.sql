USE [QLThueNha]
GO
delete from ChiNhanh

SET IDENTITY_INSERT [dbo].[ChiNhanh] ON 

INSERT [dbo].[ChiNhanh] ([ID], [Ma], [Ten], [DiaChi], [KhuVuc], [SDT], [FAX]) VALUES (1, N'HN', N'TĐ.Hà Nội', N'Thủ Đô Hà Nội', N'Miền Bắc', N'', N'')
INSERT [dbo].[ChiNhanh] ([ID], [Ma], [Ten], [DiaChi], [KhuVuc], [SDT], [FAX]) VALUES (2, N'HCM', N'TP.Hồ Chí Minh', N'TP.Hồ Chí Minh', N'Miền Nam', N'', N'')
INSERT [dbo].[ChiNhanh] ([ID], [Ma], [Ten], [DiaChi], [KhuVuc], [SDT], [FAX]) VALUES (3, N'DN', N'TP.Đà Nẵng', N'TP.Đà Nẵng', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[ChiNhanh] OFF

insert into NhanVien (Ma, Ten, IDChucVu, IDChiNhanh, Username, Pass)values(N'Admin', N'Admin', 2, 1, N'admin', N'123')