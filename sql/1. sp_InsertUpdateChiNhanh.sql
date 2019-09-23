Alter proc [dbo].[sp_InsertUpdateChiNhanh]
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





