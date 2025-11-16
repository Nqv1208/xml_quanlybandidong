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
('HSX003', N'Xiaomi');
GO

INSERT INTO NhanVien VALUES
('NV001', N'Nguyễn Văn A', N'Quản trị', N'0909123456'),
('NV002', N'Trần Thị B', N'Nhân viên bán hàng', N'0909345678');
GO

INSERT INTO TaiKhoan VALUES
('TK001', N'admin', N'admin', N'Admin', 'NV001'),
('TK002', N'nhanvien', N'123456', N'NhanVien', 'NV002');
GO