using System.Data;
using QuanLyBanDienThoai.DAL;

namespace QuanLyBanDienThoai.Data;

/// <summary>
/// Thực hiện kéo dữ liệu từ database xuống XML khi file chưa tồn tại.
/// </summary>
public static class XmlSeeder
{
    /// <summary>
    /// Gọi một lần lúc khởi động để đảm bảo các file XML tối thiểu đã được tạo.
    /// </summary>
    public static void SeedFromDatabase()
    {
        SeedOne("Taikhoan.xml", "TaiKhoan",
            "SELECT MaTk, TenDangNhap, MatKhau, Quyen, MaNV FROM TaiKhoan");

        SeedOne("Nhanvien.xml", "NhanVien",
            "SELECT MaNV, TenNV, ChucVu, SoDienThoai FROM NhanVien");

        SeedOne("Hangsanxuat.xml", "HangSanXuat",
            "SELECT MaHang, TenHang FROM HangSanXuat");

        SeedOne("Sanpham.xml", "SanPham",
            "SELECT MaSP, TenSP, MaHang, GiaBan, SoLuongTon, MoTa FROM SanPham");

        SeedOne("Nhacungcap.xml", "NhaCungCap",
            "SELECT MaNCC, TenNCC, DiaChi, SoDienThoai, Email FROM NhaCungCap");

        SeedOne("Phieunhap.xml", "PhieuNhap",
            "SELECT MaPN, MaNCC, MaNV, NgayNhap, TongTien FROM PhieuNhap");

        SeedOne("Chitietphieunhap.xml", "ChiTietPhieuNhap",
            "SELECT MaCTPN, MaPN, MaSP, SoLuong, DonGiaNhap, (SoLuong * DonGiaNhap) AS ThanhTien FROM ChiTietPhieuNhap");

        SeedOne("Khachhang.xml", "KhachHang",
            "SELECT MaKH, TenKH, SoDienThoai FROM KhachHang");

        SeedOne("HoaDon.xml", "HoaDon",
            "SELECT MaHD, MaKH, MaNV, NgayLap, TongTien FROM HoaDon");

        SeedOne("Chitiethoadon.xml", "ChiTietHoaDon",
            "SELECT MaCTHD, MaHD, MaSP, SoLuong, DonGia, ThanhTien FROM ChiTietHoaDon");
    }

    private static void SeedOne(string fileName, string tableName, string sql)
    {
        var path = Path.Combine(AppContext.BaseDirectory, "Data", fileName);
        if (File.Exists(path))
        {
            // Đã có file -> bỏ qua
            return;
        }

        DataTable dt = DatabaseHelper.ExecuteQuery(sql);
        XmlDataService.SaveTable(dt, fileName, tableName);
    }
}

