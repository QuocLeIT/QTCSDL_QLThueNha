Alter PROC [dbo].[sp_Read_BaoCaoXemNha]
@tuNgay datetime,
@denNgay datetime,
@idChiNhanh int
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS(SELECT ID FROM ChiNhanh WHERE ID = @idChiNhanh)
		BEGIN
			PRINT N'NOT EXISTS ChiNhanh'
			ROLLBACK TRAN
			RETURN
		END
		IF NOT EXISTS(
			SELECT ID FROM XemNha 
			WHERE CONVERT(date, ThoiGianXem)  >= @tuNgay and CONVERT(date, ThoiGianXem) <= @denNgay
			)	
		BEGIN
			PRINT N'Khong co du lieu'
			ROLLBACK TRAN
			RETURN
		END

		--TEST
		WAITFOR DELAY '0:00:05'
		---------
		select xn.ID, kh.Ten as KhachHang, nv.Ten as NhanVien, nct.DiaChi, xn.ThoiGianXem, xn.NhanSet, cn.Ten as ChiNhanh, 
			xn.IDKH as IDKhachHang, xn.IDNV as IDNhanVien, xn.IDNhaThue, nct.IDChiNhanh 
		from XemNha as xn 
		inner join KhachHang as kh on xn.IDKH = kh.ID 
		inner join NhanVien as nv on xn.IDNV = nv.ID 
		inner join NhaChoThue as nct on xn.IDNhaThue = nct.ID 
		inner join ChiNhanh as cn on nct.IDChiNhanh = cn.ID 
		where CONVERT(date, xn.ThoiGianXem)  >= @tuNgay and CONVERT(date, xn.ThoiGianXem)  <= @denNgay  
			and cn.ID = @idChiNhanh
		order by xn.ID

	END TRY
	BEGIN CATCH		
		PRINT N'Error'
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
Go

--sp_InsertUpdate_XemNha, or delete

