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





