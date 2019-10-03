--select * from ChiNhanh
--select * from XemNha
--exec sp_InsertUpdate_XemNha 0,3, 2, '2019-10-04 13:00:00.000', 3, N''

--1: doc bao cao
exec sp_Read_BaoCaoXemNha '2019-09-28', '2019-09-28', 2
exec sp_Read_BaoCaoXemNha_Fix '2019-09-28', '2019-09-28', 2

--2: deltete lich xem nha
declare @result int
exec @result= sp_DeleteXemNha 1
if @result > 0
begin
	print N'Thanh cong'
end
if @result = -3
begin
	print N'Khong ton tai'
end
if @result = -1 
begin
	print N'Loi'
end
