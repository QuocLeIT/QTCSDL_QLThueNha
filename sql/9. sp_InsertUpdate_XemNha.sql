Alter proc [dbo].[sp_InsertUpdate_XemNha]
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
		
		set @result = -2; -- khach hang trung chu nha
	end
	else
	begin
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





