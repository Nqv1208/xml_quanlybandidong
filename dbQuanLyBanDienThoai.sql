	DROP DATABASE IF EXISTS QuanLyBanDienThoaiDb;
	GO
	CREATE DATABASE QuanLyBanDienThoaiDb;
	GO
	USE QuanLyBanDienThoaiDb;
	GO
	/****** BẢNG HÃNG SẢN XUẤT ******/
	CREATE TABLE HangSanXuat (
		MaHang VARCHAR(10) PRIMARY KEY,     -- HSX001
		TenHang NVARCHAR(50) NOT NULL
	);
	GO
	/****** BẢNG SẢN PHẨM ******/
	CREATE TABLE SanPham (
		MaSP VARCHAR(10) PRIMARY KEY,       -- SP001
		TenSP NVARCHAR(100) NOT NULL,
		MaHang VARCHAR(10),
		GiaBan DECIMAL(15,2),
		SoLuongTon INT DEFAULT 0,
		MoTa NVARCHAR(MAX),
		FOREIGN KEY (MaHang) REFERENCES HangSanXuat(MaHang)
	);
	GO
	/****** BẢNG NHÂN VIÊN ******/
	CREATE TABLE NhanVien (
		MaNV VARCHAR(10) PRIMARY KEY,       -- NV001
		TenNV NVARCHAR(100) NOT NULL,
		ChucVu NVARCHAR(50),
		SoDienThoai NVARCHAR(15)
	);
	GO
	/****** BẢNG TÀI KHOẢN ******/
	CREATE TABLE TaiKhoan (
		MaTK VARCHAR(10) PRIMARY KEY,       -- TK001
		TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
		MatKhau NVARCHAR(100) NOT NULL,
		Quyen NVARCHAR(20) CHECK (Quyen IN ('Admin', 'NhanVien')) NOT NULL,
		MaNV VARCHAR(10) NULL,
		FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	);
	GO
	/****** BẢNG KHÁCH HÀNG ******/
	CREATE TABLE KhachHang (
		MaKH VARCHAR(10) PRIMARY KEY,       -- KH001
		TenKH NVARCHAR(100) NOT NULL,
		SoDienThoai NVARCHAR(15)
	);
	GO
	/****** BẢNG HÓA ĐƠN ******/
	CREATE TABLE HoaDon (
		MaHD VARCHAR(10) PRIMARY KEY,       -- HD001
		MaKH VARCHAR(10),
		MaNV VARCHAR(10),
		NgayLap DATETIME DEFAULT GETDATE(),
		TongTien DECIMAL(15,2),
		FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
		FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	);
	GO
	/****** BẢNG CHI TIẾT HÓA ĐƠN ******/
	CREATE TABLE ChiTietHoaDon (
		MaCTHD VARCHAR(10) PRIMARY KEY,     -- CTHD001
		MaHD VARCHAR(10),
		MaSP VARCHAR(10),
		SoLuong INT,
		DonGia DECIMAL(15,2),
		ThanhTien AS (SoLuong * DonGia) PERSISTED,
		FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
		FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
	);
	GO
	/****** BẢNG NHÀ CUNG CẤP ******/
	CREATE TABLE NhaCungCap (
		MaNCC VARCHAR(10) PRIMARY KEY,      -- NCC001
		TenNCC NVARCHAR(100) NOT NULL,
		DiaChi NVARCHAR(255),
		SoDienThoai NVARCHAR(15),
		Email NVARCHAR(100)
	);
	GO
	/****** BẢNG PHIẾU NHẬP ******/
	CREATE TABLE PhieuNhap (
		MaPN VARCHAR(10) PRIMARY KEY,       -- PN001
		MaNCC VARCHAR(10),
		MaNV VARCHAR(10),
		NgayNhap DATETIME DEFAULT GETDATE(),
		TongTien DECIMAL(15,2),
		FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC),
		FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	);
	GO


	/****** BẢNG CHI TIẾT PHIẾU NHẬP ******/
	CREATE TABLE ChiTietPhieuNhap (
		MaCTPN VARCHAR(10) PRIMARY KEY,     -- CTPN001
		MaPN VARCHAR(10),
		MaSP VARCHAR(10),
		SoLuong INT,
		DonGiaNhap DECIMAL(15,2),
		ThanhTien AS (SoLuong * DonGiaNhap) PERSISTED,
		FOREIGN KEY (MaPN) REFERENCES PhieuNhap(MaPN),
		FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
	);
	GO
	INSERT INTO HangSanXuat VALUES
	('HSX001', N'Apple'),
	('HSX002', N'Samsung'),
	('HSX003', N'Xiaomi'),
	('HSX004', N'Oppo'),
	('HSX005', N'Vivo'),
	('HSX006', N'Realme'),
	('HSX007', N'Nokia'),
	('HSX008', N'Sony'),
	('HSX009', N'Huawei'),
	('HSX010', N'Google'),
	('HSX011', N'OnePlus'),
	('HSX012', N'Asus'),
	('HSX013', N'Motorola'),
	('HSX014', N'LG'),
	('HSX015', N'Poco');
	GO

	INSERT INTO NhanVien VALUES
	('NV001', N'Nguyễn Văn A', N'Quản trị', N'0909123456'),
	('NV002', N'Trần Thị B', N'Nhân viên bán hàng', N'0909345678'),
	('NV003', N'Lê Quốc Hùng', N'Nhân viên bán hàng', '0909123123'),
	('NV004', N'Đỗ Khánh Ly', N'Thu ngân', '0909555666'),
	('NV005', N'Nguyễn Minh Tâm', N'Bảo vệ', '0909777888'),
	('NV006', N'Trần Nhật Quân', N'Kỹ thuật viên', '0911222333'),
	('NV007', N'Phạm Thanh Hương', N'Tư vấn viên', '0933444555'),
	('NV008', N'Nguyễn Thị Lan', N'Nhân viên bán hàng', '0912345678'),
	('NV009', N'Phạm Văn Minh', N'Nhân viên kho', '0923456789'),
	('NV010', N'Huỳnh Thị Mai', N'Thu ngân', '0934567890'),
	('NV011', N'Võ Văn Khánh', N'Nhân viên bán hàng', '0945678901'),
	('NV012', N'Lý Thị Ngọc Ánh', N'Tư vấn viên', '0956789012'),
	('NV013', N'Trần Văn Hoàng', N'Kỹ thuật viên', '0967890123'),
	('NV014', N'Đặng Thị Thu', N'Nhân viên kho', '0978901234'),
	('NV015', N'Bùi Văn Hậu', N'Nhân viên bán hàng', '0989012345');
	GO

	INSERT INTO SanPham VALUES
	('SP001', N'IPhone 15', 'HSX001', 25000000, 10, N'Điện thoại Apple mới nhất'),
	('SP002', N'Samsung S24', 'HSX002', 21000000, 15, N'Flagship Samsung 2024'),
	('SP003', N'Oppo Reno 11', 'HSX004', 13000000, 20, N'Điện thoại Oppo mới nhất'),
	('SP004', N'Vivo V30', 'HSX005', 10500000, 18, N'Camera đỉnh cao'),
	('SP005', N'Realme 12 Pro', 'HSX006', 9000000, 25, N'Cấu hình mạnh'),
	('SP006', N'Nokia X20', 'HSX007', 7500000, 15, N'Độ bền cao'),
	('SP007', N'Sony Xperia 5', 'HSX008', 18000000, 12, N'Màn hình đẹp'),
	('SP008', N'iPhone 14 Pro', 'HSX001', 22000000, 8, N'iPhone cũ cao cấp'),
	('SP009', N'Samsung Galaxy Z Fold 6', 'HSX002', 45000000, 5, N'Điện thoại gập'),
	('SP010', N'Xiaomi 14', 'HSX003', 15000000, 20, N'Flagship giá tốt'),
	('SP011', N'Oppo Find X7', 'HSX004', 20000000, 12, N'Camera Hasselblad'),
	('SP012', N'Vivo X100', 'HSX005', 18000000, 15, N'Chip Dimensity mạnh'),
	('SP013', N'Realme GT 6', 'HSX006', 12000000, 18, N'Gaming phone'),
	('SP014', N'Nokia G60', 'HSX007', 6500000, 25, N'Pin trâu'),
	('SP015', N'Sony Xperia 1 VI', 'HSX008', 28000000, 6, N'Màn hình 4K'),
	('SP016', N'Huawei P60 Pro', 'HSX009', 19000000, 10, N'Camera XMAGE'),
	('SP017', N'Google Pixel 9', 'HSX010', 21000000, 12, N'Android thuần'),
	('SP018', N'OnePlus 12', 'HSX011', 17000000, 14, N'Sạc nhanh 100W'),
	('SP019', N'Asus ROG Phone 8', 'HSX012', 25000000, 8, N'Dành cho game thủ'),
	('SP020', N'Poco F6', 'HSX015', 9500000, 30, N'Hiệu năng cao giá rẻ');
	GO
	INSERT INTO TaiKhoan VALUES
	('TK001', N'admin', N'admin', N'Admin', 'NV001'),
	('TK002', N'nhanvien', N'123456', N'NhanVien', 'NV002');
	GO
	INSERT INTO KhachHang VALUES
	('KH001', N'Phạm Minh Tuấn', N'0912345678'),
	('KH002', N'Võ Thị Hoa', N'0988777666'),
	('KH003', N'Nguyễn Hoàng Nam', '0905666777'),
	('KH004', N'Lê Thị Ngọc', '0908444555'),
	('KH005', N'Võ Văn Phúc', '0933666888'),
	('KH006', N'Huỳnh Ngọc Bích', '0911999000'),
	('KH007', N'Trần Gia Huy', '0988111222'),
	('KH008', N'Nguyễn Văn Long', '0901234567'),
	('KH009', N'Trần Thị Kim', '0912345679'),
	('KH010', N'Lê Văn Hùng', '0923456780'),
	('KH011', N'Phạm Thị Huyền', '0934567891'),
	('KH012', N'Võ Văn Tuấn', '0945678902'),
	('KH013', N'Huỳnh Thị Lan', '0956789013'),
	('KH014', N'Đỗ Văn Khôi', '0967890124'),
	('KH015', N'Ngô Thị Mỹ', '0978901235'),
	('KH016', N'Bùi Văn Đức', '0989012346'),
	('KH017', N'Lương Thị Hồng', '0990123456'),
	('KH018', N'Hoàng Văn Nam', '0901122334'),
	('KH019', N'Đinh Thị Thảo', '0912233445'),
	('KH020', N'Chu Văn Bình', '0923344556');
	INSERT INTO HoaDon VALUES
	('HD001', 'KH001', 'NV002', '2025-11-10T10:30:00', 25000000),
	('HD002', 'KH003', 'NV003', '2025-11-12T09:10:00', 13000000),
	('HD003', 'KH004', 'NV004', '2025-11-12T10:05:00', 10500000),
	('HD004', 'KH005', 'NV006', '2025-11-13T16:20:00', 9000000),
	('HD005', 'KH006', 'NV002', '2025-11-14T11:45:00', 7500000),
	('HD006', 'KH007', 'NV007', '2025-11-15T14:30:00', 18000000),
	('HD007', 'KH008', 'NV008', '2025-12-01 14:20:00', 52000000),  
	('HD008', 'KH009', 'NV011', '2025-12-02 10:15:00', 73500000),  
	('HD009', 'KH010', 'NV002', '2025-12-03 16:45:00', 44000000), 
	('HD010', 'KH011', 'NV015', '2025-12-04 11:30:00', 49000000), 
	('HD011', 'KH012', 'NV008', '2025-12-05 09:00:00', 59000000),
	('HD012', 'KH013', 'NV010', '2025-12-06 13:20:00', 67000000),  
	('HD013', 'KH014', 'NV011', '2025-12-07 15:50:00', 69500000),  
	('HD014', 'KH015', 'NV002', '2025-12-08 12:10:00', 55000000),  
	('HD015', 'KH016', 'NV015', '2025-12-09 17:30:00', 102500000);
	GO
	INSERT INTO ChiTietHoaDon (MaCTHD, MaHD, MaSP, SoLuong, DonGia)
	VALUES 
	('CTHD001', 'HD001', 'SP001', 1, 25000000),
	('CTHD002', 'HD002', 'SP003', 1, 13000000),
	('CTHD003', 'HD003', 'SP004', 1, 10500000),
	('CTHD004', 'HD004', 'SP005', 1, 9000000),
	('CTHD005', 'HD005', 'SP006', 1, 7500000),
	('CTHD006', 'HD006', 'SP007', 1, 18000000),
	('CTHD007', 'HD007', 'SP008', 1, 22000000),
	('CTHD008', 'HD007', 'SP010', 2, 15000000),
	('CTHD009', 'HD008', 'SP009', 1, 45000000),
	('CTHD010', 'HD008', 'SP020', 3, 9500000),
	('CTHD011', 'HD009', 'SP011', 1, 20000000),
	('CTHD012', 'HD009', 'SP013', 2, 12000000),
	('CTHD013', 'HD010', 'SP015', 1, 28000000),
	('CTHD014', 'HD010', 'SP017', 1, 21000000),
	('CTHD015', 'HD011', 'SP018', 2, 17000000);

	Go
	INSERT INTO NhaCungCap VALUES
	('NCC001', N'VietMobile Supplier', N'123 Lê Lợi, Quận 1', N'0901122233', N'supplier@vietmobile.com'),
	('NCC002', N'FPT Shop Supplier', N'456 Nguyễn Trãi, Quận 5', '0281234567', N'fpt@supplier.com'),
	('NCC003', N'Thế Giới Di Động Corp', N'789 Võ Văn Ngân, Thủ Đức', '0289876543', N'tgdd@supplier.vn'),
	('NCC004', N'CellphoneS Distributor', N'321 Lê Văn Việt, Quận 9', '0288765432', N'contact@cellphones.com.vn'),
	('NCC005', N'Vietel Store Supply', N'654 Quang Trung, Gò Vấp', '0287654321', N'supply@viettel.com.vn');
	Go
	INSERT INTO PhieuNhap VALUES
	('PN001', 'NCC001', 'NV001', '2025-11-14 09:00:00', 40000000),
	('PN002', 'NCC001', 'NV001', '2025-10-10 09:00:00', 26000000),
	('PN003', 'NCC001', 'NV003', '2025-10-11 13:00:00', 21000000),
	('PN004', 'NCC001', 'NV004', '2025-10-12 15:30:00', 27000000),
	('PN005', 'NCC001', 'NV002', '2025-10-13 10:45:00', 15000000),
	('PN006', 'NCC001', 'NV006', '2025-10-14 11:20:00', 18000000),
	('PN007', 'NCC001', 'NV006', '2025-11-13 10:30:00', 117000000),
	('PN008', 'NCC001', 'NV002', '2025-12-03 14:20:00', 148000000),
	('PN009', 'NCC001', 'NV003', '2025-10-09 09:45:00', 165000000),
	('PN010', 'NCC001', 'NV007', '2025-12-02 11:15:00', 164000000),
	('PN011', 'NCC001', 'NV003', '2025-10-01 08:00:00', 84000000),
	('PN012', 'NCC001', 'NV003', '2025-11-28 16:00:00', 112000000),
	('PN013', 'NCC001', 'NV006', '2025-12-11 13:30:00', 71000000),
	('PN014', 'NCC001', 'NV002', '2025-11-10 10:00:00', 95000000),
	('PN015', 'NCC001', 'NV007', '2025-10-17 15:45:00', 68500000);
GO
	INSERT INTO ChiTietPhieuNhap (MaCTPN, MaPN, MaSP, SoLuong, DonGiaNhap)
	VALUES 
	('CTPN001', 'PN001', 'SP001', 2, 20000000),
	('CTPN002', 'PN002', 'SP003', 2, 13000000),
	('CTPN003', 'PN003', 'SP004', 2, 10500000),
	('CTPN004', 'PN004', 'SP005', 3, 9000000),
	('CTPN005', 'PN005', 'SP006', 2, 7500000),
	('CTPN006', 'PN006', 'SP007', 1, 18000000),
	('CTPN007', 'PN007', 'SP008', 3, 19000000),
	('CTPN008', 'PN007', 'SP010', 5, 12000000),
	('CTPN009', 'PN008', 'SP009', 2, 40000000),
	('CTPN010', 'PN008', 'SP011', 4, 17000000),
	('CTPN011', 'PN009', 'SP012', 6, 15000000),
	('CTPN012', 'PN009', 'SP015', 3, 25000000),
	('CTPN013', 'PN010', 'SP016', 4, 16000000),
	('CTPN014', 'PN010', 'SP017', 5, 18000000),
	('CTPN015', 'PN011', 'SP018', 6, 14000000);

