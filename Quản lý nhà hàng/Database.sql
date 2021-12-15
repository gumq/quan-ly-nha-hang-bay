CREATE DATABASE [QL_NhaHang]
GO
USE [QL_NhaHang]
GO
CREATE TABLE [dbo].[LOAITAIKHOAN]
(
ID [INT] IDENTITY(0,1) PRIMARY KEY,
TenLoai NVARCHAR(100) NOT NULL,
)
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
	[ID] INT NOT NULL
	CONSTRAINT fk_TK FOREIGN KEY (ID) REFERENCES LOAITAIKHOAN(ID)
)
GO
CREATE TABLE [dbo].[LUUTAIKHOAN](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
)
GO
CREATE TABLE [dbo].[KHUVUC](
	[ID] [INT] IDENTITY(0,1) PRIMARY KEY,
	[TenKhuVuc] [nvarchar](100) NOT NULL,
)
GO
CREATE TABLE [dbo].[BAN](
	[STT] [int] IDENTITY(1,1) PRIMARY KEY,
	[TenBan] [nvarchar](100) NOT NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
	[TongCong] [float] NOT NULL,
	[ID] [INT] NOT NULL,
	CONSTRAINT fk_KV FOREIGN KEY (ID) REFERENCES KHUVUC(ID)
)
GO
CREATE TABLE [dbo].[HOADON](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](100) NOT NULL,
	[SoLuong][int] NOT NULL,
	[DonGia] [float] not null,
	[ThanhTien] [FLOAT] NOT NULL,
	[STT] int not null
	CONSTRAINT fk_HD FOREIGN KEY (STT) REFERENCES BAN(STT)
)
GO
CREATE TABLE [dbo].[DANHMUC](
	[ID] [int] IDENTITY(0,1) PRIMARY KEY,
	[TenDanhMuc] [nvarchar](100) NOT NULL
)
GO
CREATE TABLE [dbo].[THUCDON](
	[TenMonAn] [nvarchar](500) NOT NULL,
	[DonGia] [Float] NOT NULL,
	[DonVi] [nvarchar](100) not null,
	[ID] [INT] not null,
	CONSTRAINT fk_DM FOREIGN KEY (ID) REFERENCES DANHMUC(ID)
)
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [VARCHAR](100) NOT NULL,
	[HoNV] [NVARCHAR](100) NOT NULL,
	[TenNV] [NVARCHAR](100) NOT NULL,
	[GioiTinh][NVARCHAR](5) NOT NULL,
	[NGAYSINH] DATE NOT NULL,
	[SDT] [VARCHAR](20) NOT NULL,
	[DiaChi][NVARCHAR](200) not null
)
GO
CREATE TABLE [dbo].[LICHSU]
(
KhuVuc nvarchar(100) not null,
TenBan nvarchar(100) not null,
Ngay date not null,
ThoiGian time not null,
TongCong float not null,
NguoiThanhToan nvarchar(100) not null,
GhiChu nvarchar(1000)
)
GO
BEGIN --Khu Vực
INSERT [dbo].[KHUVUC](TenKhuVuc) VALUES (N'Tất cả')
INSERT [dbo].[KHUVUC](TenKhuVuc) VALUES (N'Khu G')
INSERT [dbo].[KHUVUC](TenKhuVuc) VALUES (N'Khu A')
INSERT [dbo].[KHUVUC](TenKhuVuc) VALUES (N'Khu B')
INSERT [dbo].[KHUVUC](TenKhuVuc) VALUES (N'Khu VIP')
END

GO
BEGIN --Bàn
INSERT [dbo].[BAN] VALUES (N'Bàn 01', N'TRỐNG', 0,1)
INSERT [dbo].[BAN] VALUES (N'Bàn 02', N'TRỐNG', 0,1)
INSERT [dbo].[BAN] VALUES (N'Bàn 03', N'TRỐNG', 0,1)
INSERT [dbo].[BAN] VALUES (N'Bàn 04', N'TRỐNG', 0,1)
INSERT [dbo].[BAN] VALUES (N'Bàn 05', N'TRỐNG', 0,1)
INSERT [dbo].[BAN] VALUES (N'Bàn 06', N'TRỐNG', 0,1)
INSERT [dbo].[BAN] VALUES (N'Bàn 07', N'TRỐNG', 0,1)
INSERT [dbo].[BAN] VALUES (N'Bàn 08', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 09', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 10', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 11', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 12', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 13', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 14', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 15', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 16', N'TRỐNG', 0,2)
INSERT [dbo].[BAN] VALUES (N'Bàn 17', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn 18', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn 19', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn 20', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn 21', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn 22', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn 23', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn 24', N'TRỐNG', 0,3)
INSERT [dbo].[BAN] VALUES (N'Bàn VIP 1', N'TRỐNG',0,4)
INSERT [dbo].[BAN] VALUES (N'Bàn VIP 2', N'TRỐNG',0,4)
INSERT [dbo].[BAN] VALUES (N'Bàn VIP 3', N'TRỐNG',0,4)
INSERT [dbo].[BAN] VALUES (N'Bàn VIP 4', N'TRỐNG',0,4)
END


GO
begin--danh mục
INSERT [dbo].[DANHMUC](TenDanhMuc) VALUES (N'Tất cả')
INSERT [dbo].[DANHMUC](TenDanhMuc) VALUES (N'BBQ')
INSERT [dbo].[DANHMUC](TenDanhMuc) VALUES (N'Vegetables')
INSERT [dbo].[DANHMUC](TenDanhMuc) VALUES (N'Drink')
INSERT [dbo].[DANHMUC](TenDanhMuc) VALUES (N'Deserts')
end
go
begin --Nhân viên--
INSERT [dbo].[NHANVIEN] VALUES ('NV0001',N'Trần Lê',N'Q',N'Nam','2000/04/14','09090909',N'QN')
INSERT [dbo].[NHANVIEN] VALUES ('NV0001',N'Nguyễn Văn',N'A',N'Nam','2000/04/14','096466722',N'SG')
INSERT [dbo].[NHANVIEN] VALUES ('NV0001',N'Nguyễn Văn',N'B',N'Nam','2000/04/14','0966764622',N'SG')
INSERT [dbo].[NHANVIEN] VALUES ('NV0001',N'Nguyễn Văn',N'C',N'Nam','2000/04/14','0964587622',N'SG')
INSERT [dbo].[NHANVIEN] VALUES ('NV0001',N'Nguyễn Văn',N'D',N'Nam','2000/04/14','096478522',N'SG')

end
go
begin--thực đơn
INSERT [dbo].[THUCDON] VALUES (N'Combo hải sản sốt tiêu đen',200000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Combo hải sản sốt rượu vang',200000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Gà nướng bóng đêm',150000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Ba rọi sả ớt',99000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Combo bò nướng phomai, nướng tỏi',290000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Sườn cừu nướng',390000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Hàu nướng mỡ hành',190000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Cua sốt bơ tỏi',300000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Lẩu thái',200000,N'Nồi',1)
INSERT [dbo].[THUCDON] VALUES (N'Lẩu hải sản',200000,N'Nồi',1)
INSERT [dbo].[THUCDON] VALUES (N'Lẩu tomyum',220000,N'Nồi',1)
INSERT [dbo].[THUCDON] VALUES (N'Tôm muối ớt',15000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Bạch tuột sa tế',95000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Ba chỉ sốt BBQ',85000,N'Đĩa',1)
INSERT [dbo].[THUCDON] VALUES (N'Đậu bắp',10000,N'Đĩa',2)
INSERT [dbo].[THUCDON] VALUES (N'Rau củ kho quẹt',55000,N'Đĩa',2)
INSERT [dbo].[THUCDON] VALUES (N'Kimchi',10000,N'Đĩa',2)
INSERT [dbo].[THUCDON] VALUES (N'Rau bí xào tỏi',40000,N'Đĩa',2)
INSERT [dbo].[THUCDON] VALUES (N'Pepsi',20000,N'Chai',3)
INSERT [dbo].[THUCDON] VALUES (N'Cocacola',20000,N'Lon',3)
INSERT [dbo].[THUCDON] VALUES (N'Trà tắc',55000,N'Cốc',3)
INSERT [dbo].[THUCDON] VALUES (N'Trà chanh',55000,N'Cốc',3)
INSERT [dbo].[THUCDON] VALUES (N'Tiger',23000,N'Chai',3)
INSERT [dbo].[THUCDON] VALUES (N'Heineiken',23000,N'Chai',3)
INSERT [dbo].[THUCDON] VALUES (N'Sài Gòn xanh',23000,N'Chai',3)
INSERT [dbo].[THUCDON] VALUES (N'Tháp bia',300000,N'Tháp',3)
INSERT [dbo].[THUCDON] VALUES (N'Chocola cake',25000,N'Cái',4)
INSERT [dbo].[THUCDON] VALUES (N'Tỉamisu',20000,N'Cái',4)
INSERT [dbo].[THUCDON] VALUES (N'Lemon mousse',35000,N'Cái',4)
INSERT [dbo].[THUCDON] VALUES (N'Rau câu dưa',8000,N'Cái',4)
INSERT [dbo].[THUCDON] VALUES (N'Ice cream',19000,N'Cái',4)
end
GO
BEGIN --Loại tài khoản
INSERT [dbo].[LOAITAIKHOAN](TenLoai) VALUES (N'Quản lý')
INSERT [dbo].[LOAITAIKHOAN](TenLoai) VALUES (N'Nhân Viên')
END
GO
BEGIN --tài khoản
INSERT [dbo].[TAIKHOAN] VALUES ('admin',N'Trần Lê Quyền','admin',1)
INSERT [dbo].[LUUTAIKHOAN] VALUES ('admin','admin')
INSERT [dbo].[TAIKHOAN] VALUES ('nv',N'Thanh','nv',0)
INSERT [dbo].[LUUTAIKHOAN] VALUES ('nv','nv')
END
GO
--Thủ tục--
CREATE PROC sp_InsertNhanVien
	@MaNV VARCHAR(100),
	@HoNV NVARCHAR(100),
	@TenNV NVARCHAR(100),
	@GioiTinh NVARCHAR(5),
	@NGAYSINH DATE,
	@SDT VARCHAR(20),
	@DiaChi NVARCHAR(200)
AS
BEGIN
	INSERT [dbo].[NHANVIEN]
	VALUES (@MaNV,@HoNV,@TenNV,@GioiTinh,@NGAYSINH,@SDT,@DiaChi)
END
GO
CREATE PROCEDURE sp_XoaNhanVien
@MaNV nvarchar(100)
AS
BEGIN
	DELETE FROM NHANVIEN 
	WHERE MaNV LIKE @MaNV
END
GO
CREATE PROC sp_ThemHoaDon
	@TenMonAn [nvarchar](100),
	@SoLuong INT,
	@DonGia float,
	@ThanhTien FLOAT,
	@STT int
AS
BEGIN
	INSERT [dbo].[HOADON] (TenMonAn,SoLuong,DonGia,ThanhTien,STT)
	VALUES (@TenMonAn,@SoLuong,@DonGia,@ThanhTien,@STT)
END
go
CREATE PROCEDURE sp_CapNhatTrangThaiBan
@TrangThai nvarchar(20),
@TongCong float,
@TenBan nvarchar(100)
AS
BEGIN
	UPDATE [dbo].[BAN] 
	SET TrangThai = @TrangThai,TongCong=@TongCong
	WHERE TenBan = @TenBan
END
GO
CREATE PROCEDURE sp_UpdateHoaDon
@TenMonAn nvarchar(100),
@STT int,
@SoLuong INT,
@ThanhTien float
AS
BEGIN
	UPDATE HOADON
	SET SoLuong = @SoLuong,ThanhTien=@ThanhTien
	WHERE TenMonAn = @TenMonAn AND STT = @STT
END
GO
CREATE PROCEDURE sp_XoaHoaDon
@STT INT
AS
BEGIN
	DELETE FROM [HOADON] WHERE STT like @STT
END
GO
CREATE PROCEDURE sp_XoaHoaDonTheoTen
@TenMonAn nvarchar(100),
@STT INT
AS
BEGIN
	DELETE FROM [HOADON] 
	WHERE STT like @STT and TenMonAn like @TenMonAn
END
GO
create PROC sp_TimKiemMonAn
@TenMonAn nvarchar(500)
AS
BEGIN
	select DISTINCT TenMonAn,DonGia,DonVi
	From [THUCDON]
	where TenMonAn LIKE '%'+@TenMonAn+'%'
END	
GO
CREATE PROC sp_ThemLichSu
	@KhuVuc nvarchar(100),
	@TenBan nvarchar(100),
	@Ngay date,
	@ThoiGian time,
	@TongCong float,
	@NguoiThanhToan nvarchar(100),
	@GhiChu nvarchar(1000)
AS
BEGIN
	INSERT INTO [LICHSU]
	VALUES(@KhuVuc,@TenBan,@Ngay,@ThoiGian,@TongCong,@NguoiThanhToan,@GhiChu)
END
go
CREATE PROC sp_UpdateNhanVien
	@MaNV VARCHAR(100),
	@HoNV NVARCHAR(100),
	@TenNV NVARCHAR(100),
	@GioiTinh NVARCHAR(5),
	@NGAYSINH DATE,
	@SDT VARCHAR(20),
	@DiaChi NVARCHAR(200),
	@DieuKien NVARCHAR(100)
AS
BEGIN
	update [dbo].[NHANVIEN]
	set MaNV=@MaNV,HoNV=@HoNV,TenNV=@TenNV,GioiTinh=@GioiTinh,NGAYSINH=@NGAYSINH,SDT=@SDT,DiaChi=@DiaChi
	where MaNV = @DieuKien
END
GO
create PROC sp_TimKiemTheoMaNV
@MaNV varchar(100)
AS
BEGIN
	select DISTINCT *
	From [NHANVIEN]
	where MaNV LIKE '%'+@MaNV+'%'
END	
GO
create PROC sp_TimKiemTheoTenNV
@TenNV nvarchar(100)
AS
BEGIN
	select DISTINCT *
	From [NHANVIEN]
	where TenNV LIKE '%'+@TenNV+'%'
END	
GO
CREATE PROC sp_ThemKhuVuc
@TenKhuVuc nvarchar(100)
AS
BEGIN
	INSERT INTO [KHUVUC](TenKhuVuc)
	VALUES (@TenKhuVuc)
END
GO
CREATE PROC sp_UpdateKhuVuc
@TenKhuVuc nvarchar(100),
@ID INT
AS
BEGIN
	UPDATE [KHUVUC]
	SET TenKhuVuc=@TenKhuVuc
	WHERE ID = @ID
END
GO
CREATE PROC sp_XoaKhuVuc
@ID INT
AS
BEGIN
	Delete from [KHUVUC]
	WHERE ID = @ID
END
GO
CREATE PROC sp_ThemBan
@TenBan nvarchar(100),
@ID INT
AS
BEGIN
	INSERT INTO [BAN]
	VALUES (@TenBan,N'TRỐNG',0,@ID)
END
GO
CREATE PROC sp_UpdateBan
@TenBan nvarchar(100),
@DieuKien nvarchar(100)
AS
BEGIN
	UPDATE [BAN]
	SET TenBan = @TenBan
	WHERE TenBan = @DieuKien
END
GO
CREATE PROC sp_XoaBan
@TenBan nvarchar(100)
AS
BEGIN
	Delete from [BAN]
	WHERE TenBan = @TenBan
END
GO
--Thực đơn
CREATE PROC sp_ThemDanhMuc
@TenDanhMuc nvarchar(100)
AS
BEGIN
	INSERT INTO [DANHMUC](TenDanhMuc)
	VALUES (@TenDanhMuc)
END
GO
CREATE PROC sp_UpdateDanhMuc
@TenDanhMuc nvarchar(100),
@ID INT
AS
BEGIN
	UPDATE [DANHMUC]
	SET TenDanhMuc=@TenDanhMuc
	WHERE ID = @ID
END
GO
CREATE PROC sp_XoaDanhMuc
@ID INT
AS
BEGIN
	Delete from [DANHMUC]
	WHERE ID = @ID
END
GO
CREATE PROC sp_ThemThucDon
@TenMonAn nvarchar(500),
@DonGia float,
@DonVi nvarchar(100),
@ID INT
AS
BEGIN
	INSERT INTO [THUCDON]
	VALUES (@TenMonAn,@DonGia,@DonVi,@ID)
END
GO
CREATE PROC sp_UpdateThucDon
@TenMonAn nvarchar(500),
@DonGia float,
@DonVi nvarchar(100),
@DieuKien nvarchar(500)
AS
BEGIN
	UPDATE [THUCDON]
	SET TenMonAn = @TenMonAn,DonGia=@DonGia,DonVi=@DonVi
	WHERE TenMonAn = @DieuKien
END
GO
CREATE PROC sp_XoaThucDon
@TenMonAn nvarchar(500),
@ID int
AS
BEGIN
	Delete from [THUCDON]
	WHERE TenMonAn = @TenMonAn and ID = @ID
END
GO
CREATE PROC sp_ThongKeTheoNgay
@Ngay date
AS
BEGIN
	SELECT DISTINCT * FROM LICHSU
	WHERE Ngay LIKE @Ngay
END
GO
CREATE PROC sp_ThongKeTheoThang
@Thang varchar(10),
@Nam varchar(10)
AS
BEGIN
	SELECT DISTINCT * FROM LICHSU
	WHERE MONTH(Ngay) = @Thang AND YEAR(Ngay) = @Nam
END
GO
CREATE PROC sp_ThongKeTheoKhoangNgay
@TuNgay date,
@DenNgay date
AS
BEGIN
	SELECT DISTINCT * FROM LICHSU
	WHERE Ngay >= @TuNgay AND Ngay <= @DenNgay
END
GO

Create  trigger TR_KiemTraNDONGIA
	on THUCDON
	For Insert 
	As
		if exists (Select TenMonAn,DonGia,DonVi From THUCDON Where DonGia < 0  )
		begin
		rollback tran
			print N'Du lieu nhap vao ko hop le! Xin moi nhap lai'   
		end	
		else 
			print N'Nhap Du Lieu Thanh Cong'
go
Create  trigger TR_KiemTraDONGIA_HOADON
	on HOADON
	For Insert 
	As
		if exists (Select TenMonAn,SoLuong,DonGia,ThanhTien From HOADON Where DonGia < 0  )
		begin
		rollback tran
			print N'Du lieu nhap vao ko hop le!'   
		end	
		else 
			print N'Nhap Du Lieu Thanh Cong'
go
Create  trigger TR_KiemTraSOLUONG_HOADON
	on HOADON
	For Insert 
	As
		if exists (Select TenMonAn,SoLuong,DonGia,ThanhTien From HOADON Where SoLuong < 0  )
		begin
		rollback tran
			print N'Du lieu nhap vao ko hop le! Xin moi nhap lai'   
		end	
		else 
			print N'Nhap Du Lieu Thanh Cong'
go
