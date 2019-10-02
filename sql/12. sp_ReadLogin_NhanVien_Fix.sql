Create PROC [dbo].[sp_ReadLogin_NhanVien_Fix]
@username nvarchar(50),
@pass nvarchar(50)
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM NhanVien WHERE Username = @username)
		BEGIN
			PRINT N'NOT EXISTS Username'
			ROLLBACK TRAN
			RETURN
		END
		IF NOT EXISTS(SELECT * FROM NhanVien WHERE Username = @username and Pass = @pass)
		BEGIN
			PRINT N'Error Password'
			ROLLBACK TRAN
			RETURN
		END

		--TEST
		WAITFOR DELAY '0:00:05'
		---------
		select ID, Ma, Ten, IDChiNhanh, IDChucVu 
		from NhanVien 
		where Username = @username and Pass = @pass

	END TRY
	BEGIN CATCH		
		PRINT N'Error'
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
Go

--sp_UpdateUsernamePass_NhanVien

