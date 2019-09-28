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





