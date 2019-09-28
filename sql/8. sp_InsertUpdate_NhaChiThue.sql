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





