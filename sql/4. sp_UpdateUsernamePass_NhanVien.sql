Create proc [dbo].[sp_UpdateUsernamePass_NhanVien]
@ID int,
@Username nvarchar(50),
@Password nvarchar(50)
as
declare @result int

begin tran
	BEGIN TRY

	if Exists(select ID from NhanVien where Username = @Username and ID <> @ID)
	begin
		return -3;
	end
		
		update NhanVien set Username = @Username, Pass = @Password where ID = @ID
		set @result =@ID

	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result





