Create proc [dbo].[sp_InsertUpdate_HopDongThue]
@ID int,
@idKhachHang int,
@idNhanVien int,
@idNhaThue int,
@thoiGianKyHD datetime,
@giaThueThang money,
@thoigGianThue int,
@tongTien money
as
declare @result int

begin tran
	BEGIN TRY

	if (isnull((select IDChuNha from NhaChoThue where ID = @idNhaThue), 0) = @idKhachHang)
	begin
		set @result = -2; -- khach hang trung chu nha
	end
	else
	begin
		if @ID < 1 --insert
		begin
			insert into HopDongThue(IDKH, IDNV, IDNhaThue, ThoiGianKyHopDong, GiaThueThang, ThoiGianThue, TongTien)
			values(@idKhachHang, @idNhanVien, @idNhaThue, @thoiGianKyHD, @giaThueThang, @thoigGianThue, @tongTien)

			set @result =(select @@identity)
		end
		else -- update
		begin
			update  HopDongThue set IDKH = @idKhachHang, IDNV = @idNhanVien, IDNhaThue = @idNhaThue, ThoiGianKyHopDong = @thoiGianKyHD
				, GiaThueThang = @giaThueThang, ThoiGianThue = @thoigGianThue, TongTien = @tongTien
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





