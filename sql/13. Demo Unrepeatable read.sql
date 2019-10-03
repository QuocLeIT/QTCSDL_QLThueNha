select * from NhanVien

--1: Read Login username NV1
exec sp_ReadLogin_NhanVien N'NV1', N'123'
exec sp_ReadLogin_NhanVien_Fix N'NV1', N'123'

--2: Write Reset pass NV1: 123 => 456
declare @result int
exec @result= sp_UpdateUsernamePass_NhanVien 5, N'NV1', N'123'
if @result > 0
begin
	print N'Thanh cong'
end
if @result = -3
begin
	print N'Username, ID khong dung'
end
if @result = -1 
begin
	print N'Loi'
end