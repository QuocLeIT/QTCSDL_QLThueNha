Alter proc [dbo].[sp_DeleteXemNha]
@ID int
as
declare @result int
begin tran
	BEGIN TRY
	if not Exists(select ID from XemNha where ID =  @ID)
	begin
		ROLLBACK TRAN
		return -3;
	end	
		delete from XemNha where ID = @ID
		set @result = 1
	end try	
	begin catch
		set @result =-1--(SELECT ERROR_NUMBER() AS ErrorNumber)
		ROLLBACK TRAN
	end catch
	IF @@TRANCOUNT >0					
		commit tran
return @result

return @result





