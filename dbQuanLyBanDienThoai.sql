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
('HSX008', N'Sony');
GO

INSERT INTO NhanVien VALUES
('NV001', N'Nguyễn Văn A', N'Quản trị', N'0909123456'),
('NV002', N'Trần Thị B', N'Nhân viên bán hàng', N'0909345678'),
('NV003', N'Lê Quốc Hùng', N'Nhân viên bán hàng', '0909123123'),
('NV004', N'Đỗ Khánh Ly', N'Thu ngân', '0909555666'),
('NV005', N'Nguyễn Minh Tâm', N'Bảo vệ', '0909777888'),
('NV006', N'Trần Nhật Quân', N'Kỹ thuật viên', '0911222333'),
('NV007', N'Phạm Thanh Hương', N'Tư vấn viên', '0933444555');
GO

INSERT INTO SanPham VALUES
('SP001', N'IPhone 15', 'HSX001', 25000000, 10, N'Điện thoại Apple mới nhất'),
('SP002', N'Samsung S24', 'HSX002', 21000000, 15, N'Flagship Samsung 2024'),
('SP003', N'Oppo Reno 11', 'HSX004', 13000000, 20, N'Điện thoại Oppo mới nhất'),
('SP004', N'Vivo V30', 'HSX005', 10500000, 18, N'Camera đỉnh cao'),
('SP005', N'Realme 12 Pro', 'HSX006', 9000000, 25, N'Cấu hình mạnh'),
('SP006', N'Nokia X20', 'HSX007', 7500000, 15, N'Độ bền cao'),
('SP007', N'Sony Xperia 5', 'HSX008', 18000000, 12, N'Màn hình đẹp');
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
('KH007', N'Trần Gia Huy', '0988111222');
INSERT INTO HoaDon VALUES
('HD001', 'KH001', 'NV002', '2025-11-10T10:30:00', 25000000),
('HD002', 'KH003', 'NV003', '2025-11-12T09:10:00', 13000000),
('HD003', 'KH004', 'NV004', '2025-11-12T10:05:00', 10500000),
('HD004', 'KH005', 'NV006', '2025-11-13T16:20:00', 9000000),
('HD005', 'KH006', 'NV002', '2025-11-14T11:45:00', 7500000),
('HD006', 'KH007', 'NV007', '2025-11-15T14:30:00', 18000000);
GO
INSERT INTO ChiTietHoaDon (MaCTHD, MaHD, MaSP, SoLuong, DonGia)
VALUES 
('CTHD002', 'HD002', 'SP003', 1, 13000000),
('CTHD003', 'HD003', 'SP004', 1, 10500000),
('CTHD004', 'HD004', 'SP005', 1, 9000000),
('CTHD005', 'HD005', 'SP006', 1, 7500000),
('CTHD006', 'HD006', 'SP007', 1, 18000000);
Go
INSERT INTO NhaCungCap VALUES
('NCC001', N'VietMobile Supplier', N'123 Lê Lợi, Quận 1', N'0901122233', N'supplier@vietmobile.com');
Go
INSERT INTO PhieuNhap VALUES
('PN001', 'NCC001', 'NV001', '2025-11-14T09:00:00', 40000000),
('PN002', 'NCC001', 'NV001', '2025-10-10T09:00:00', 26000000),
('PN003', 'NCC001', 'NV003', '2025-10-11T13:00:00', 21000000),
('PN004', 'NCC001', 'NV004', '2025-10-12T15:30:00', 25000000),
('PN005', 'NCC001', 'NV002', '2025-10-13T10:45:00', 30000000),
('PN006', 'NCC001', 'NV006', '2025-10-14T11:20:00', 18000000);
go
INSERT INTO ChiTietPhieuNhap (MaCTPN, MaPN, MaSP, SoLuong, DonGiaNhap)
VALUES 
('CTPN001', 'PN001', 'SP001', 2, 20000000),
('CTPN002', 'PN002', 'SP003', 2, 13000000),
('CTPN003', 'PN003', 'SP004', 2, 10500000),
('CTPN004', 'PN004', 'SP005', 3, 9000000),
('CTPN005', 'PN005', 'SP006', 2, 7500000),
('CTPN006', 'PN006', 'SP007', 1, 18000000);

