using System.Data;
using QuanLyBanDienThoai.DAL;
using Microsoft.Data.SqlClient;

namespace QuanLyBanDienThoai.DAL;

/// <summary>
/// Đồng bộ dữ liệu từ các file XML lên database bằng MERGE/INSERT.
/// </summary>
public static class XmlSynchronizer
{
    /// <summary>
    /// Đồng bộ tất cả dữ liệu từ XML lên database.
    /// Thứ tự đảm bảo ràng buộc khóa ngoại.
    /// </summary>
    public static void SyncAllToDatabase()
    {
        try
        {
            SyncHangSanXuat();
            SyncNhanVien();
            SyncTaiKhoan();
            SyncKhachHang();
            SyncNhaCungCap();
            SyncSanPham();
            SyncPhieuNhap();
            SyncChiTietPhieuNhap();
            SyncHoaDon();
            SyncChiTietHoaDon();
        }
        catch (Exception ex)
        {
            throw new Exception($"Lỗi khi đồng bộ dữ liệu từ XML lên database: {ex.Message}", ex);
        }
    }

    private static void SyncHangSanXuat()
    {
        DataTable dt = XmlDataService.LoadTable("Hangsanxuat.xml", "HangSanXuat");
        string sql = @"
            MERGE HangSanXuat AS target
            USING (SELECT @MaHang AS MaHang, @TenHang AS TenHang) AS source
            ON target.MaHang = source.MaHang
            WHEN MATCHED THEN UPDATE SET TenHang = source.TenHang
            WHEN NOT MATCHED THEN INSERT (MaHang, TenHang) VALUES (source.MaHang, source.TenHang);";

        foreach (DataRow row in dt.Rows)
        {
            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaHang", row["MaHang"]?.ToString() ?? ""),
                new SqlParameter("@TenHang", row["TenHang"]?.ToString() ?? ""));
        }
    }

    private static void SyncNhanVien()
    {
        DataTable dt = XmlDataService.LoadTable("Nhanvien.xml", "NhanVien");
        string sql = @"
            MERGE NhanVien AS target
            USING (SELECT @MaNV AS MaNV, @TenNV AS TenNV, @ChucVu AS ChucVu, @SoDienThoai AS SoDienThoai) AS source
            ON target.MaNV = source.MaNV
            WHEN MATCHED THEN UPDATE SET TenNV = source.TenNV, ChucVu = source.ChucVu, SoDienThoai = source.SoDienThoai
            WHEN NOT MATCHED THEN INSERT (MaNV, TenNV, ChucVu, SoDienThoai) VALUES (source.MaNV, source.TenNV, source.ChucVu, source.SoDienThoai);";

        foreach (DataRow row in dt.Rows)
        {
            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaNV", row["MaNV"]?.ToString() ?? ""),
                new SqlParameter("@TenNV", row["TenNV"]?.ToString() ?? ""),
                new SqlParameter("@ChucVu", (object?)(row["ChucVu"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@SoDienThoai", (object?)(row["SoDienThoai"]?.ToString()) ?? DBNull.Value));
        }
    }

    private static void SyncTaiKhoan()
    {
        DataTable dt = XmlDataService.LoadTable("Taikhoan.xml", "TaiKhoan");
        string sql = @"
            MERGE TaiKhoan AS target
            USING (SELECT @MaTK AS MaTK, @TenDangNhap AS TenDangNhap, @MatKhau AS MatKhau, @Quyen AS Quyen, @MaNV AS MaNV) AS source
            ON target.MaTK = source.MaTK
            WHEN MATCHED THEN UPDATE SET TenDangNhap = source.TenDangNhap, MatKhau = source.MatKhau, Quyen = source.Quyen, MaNV = source.MaNV
            WHEN NOT MATCHED THEN INSERT (MaTK, TenDangNhap, MatKhau, Quyen, MaNV) VALUES (source.MaTK, source.TenDangNhap, source.MatKhau, source.Quyen, source.MaNV);";

        foreach (DataRow row in dt.Rows)
        {
            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaTK", row["MaTK"]?.ToString() ?? ""),
                new SqlParameter("@TenDangNhap", row["TenDangNhap"]?.ToString() ?? ""),
                new SqlParameter("@MatKhau", row["MatKhau"]?.ToString() ?? ""),
                new SqlParameter("@Quyen", row["Quyen"]?.ToString() ?? ""),
                new SqlParameter("@MaNV", (object?)(row["MaNV"]?.ToString()) ?? DBNull.Value));
        }
    }

    private static void SyncKhachHang()
    {
        DataTable dt = XmlDataService.LoadTable("Khachhang.xml", "KhachHang");
        string sql = @"
            MERGE KhachHang AS target
            USING (SELECT @MaKH AS MaKH, @TenKH AS TenKH, @SoDienThoai AS SoDienThoai) AS source
            ON target.MaKH = source.MaKH
            WHEN MATCHED THEN UPDATE SET TenKH = source.TenKH, SoDienThoai = source.SoDienThoai
            WHEN NOT MATCHED THEN INSERT (MaKH, TenKH, SoDienThoai) VALUES (source.MaKH, source.TenKH, source.SoDienThoai);";

        foreach (DataRow row in dt.Rows)
        {
            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaKH", row["MaKH"]?.ToString() ?? ""),
                new SqlParameter("@TenKH", row["TenKH"]?.ToString() ?? ""),
                new SqlParameter("@SoDienThoai", (object?)(row["SoDienThoai"]?.ToString()) ?? DBNull.Value));
        }
    }

    private static void SyncNhaCungCap()
    {
        DataTable dt = XmlDataService.LoadTable("Nhacungcap.xml", "NhaCungCap");
        string sql = @"
            MERGE NhaCungCap AS target
            USING (SELECT @MaNCC AS MaNCC, @TenNCC AS TenNCC, @DiaChi AS DiaChi, @SoDienThoai AS SoDienThoai, @Email AS Email) AS source
            ON target.MaNCC = source.MaNCC
            WHEN MATCHED THEN UPDATE SET TenNCC = source.TenNCC, DiaChi = source.DiaChi, SoDienThoai = source.SoDienThoai, Email = source.Email
            WHEN NOT MATCHED THEN INSERT (MaNCC, TenNCC, DiaChi, SoDienThoai, Email) VALUES (source.MaNCC, source.TenNCC, source.DiaChi, source.SoDienThoai, source.Email);";

        foreach (DataRow row in dt.Rows)
        {
            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaNCC", row["MaNCC"]?.ToString() ?? ""),
                new SqlParameter("@TenNCC", row["TenNCC"]?.ToString() ?? ""),
                new SqlParameter("@DiaChi", (object?)(row["DiaChi"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@SoDienThoai", (object?)(row["SoDienThoai"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@Email", (object?)(row["Email"]?.ToString()) ?? DBNull.Value));
        }
    }

    private static void SyncSanPham()
    {
        DataTable dt = XmlDataService.LoadTable("Sanpham.xml", "SanPham");
        string sql = @"
            MERGE SanPham AS target
            USING (SELECT @MaSP AS MaSP, @TenSP AS TenSP, @MaHang AS MaHang, @GiaBan AS GiaBan, @SoLuongTon AS SoLuongTon, @MoTa AS MoTa) AS source
            ON target.MaSP = source.MaSP
            WHEN MATCHED THEN UPDATE SET TenSP = source.TenSP, MaHang = source.MaHang, GiaBan = source.GiaBan, SoLuongTon = source.SoLuongTon, MoTa = source.MoTa
            WHEN NOT MATCHED THEN INSERT (MaSP, TenSP, MaHang, GiaBan, SoLuongTon, MoTa) VALUES (source.MaSP, source.TenSP, source.MaHang, source.GiaBan, source.SoLuongTon, source.MoTa);";

        foreach (DataRow row in dt.Rows)
        {
            decimal.TryParse(row["GiaBan"]?.ToString(), out decimal giaBan);
            int.TryParse(row["SoLuongTon"]?.ToString(), out int soLuongTon);

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaSP", row["MaSP"]?.ToString() ?? ""),
                new SqlParameter("@TenSP", row["TenSP"]?.ToString() ?? ""),
                new SqlParameter("@MaHang", (object?)(row["MaHang"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@GiaBan", giaBan),
                new SqlParameter("@SoLuongTon", soLuongTon),
                new SqlParameter("@MoTa", (object?)(row["MoTa"]?.ToString()) ?? DBNull.Value));
        }
    }

    private static void SyncPhieuNhap()
    {
        DataTable dt = XmlDataService.LoadTable("Phieunhap.xml", "PhieuNhap");
        string sql = @"
            MERGE PhieuNhap AS target
            USING (SELECT @MaPN AS MaPN, @MaNCC AS MaNCC, @MaNV AS MaNV, @NgayNhap AS NgayNhap, @TongTien AS TongTien) AS source
            ON target.MaPN = source.MaPN
            WHEN MATCHED THEN UPDATE SET MaNCC = source.MaNCC, MaNV = source.MaNV, NgayNhap = source.NgayNhap, TongTien = source.TongTien
            WHEN NOT MATCHED THEN INSERT (MaPN, MaNCC, MaNV, NgayNhap, TongTien) VALUES (source.MaPN, source.MaNCC, source.MaNV, source.NgayNhap, source.TongTien);";

        foreach (DataRow row in dt.Rows)
        {
            DateTime.TryParse(row["NgayNhap"]?.ToString(), out DateTime ngayNhap);
            decimal.TryParse(row["TongTien"]?.ToString(), out decimal tongTien);

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaPN", row["MaPN"]?.ToString() ?? ""),
                new SqlParameter("@MaNCC", (object?)(row["MaNCC"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@MaNV", (object?)(row["MaNV"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@NgayNhap", ngayNhap),
                new SqlParameter("@TongTien", tongTien));
        }
    }

    private static void SyncChiTietPhieuNhap()
    {
        DataTable dt = XmlDataService.LoadTable("Chitietphieunhap.xml", "ChiTietPhieuNhap");
        // Xóa toàn bộ để tránh trùng lặp
        DatabaseHelper.ExecuteNonQuery("DELETE FROM ChiTietPhieuNhap");

        string sql = @"
            INSERT INTO ChiTietPhieuNhap (MaCTPN, MaPN, MaSP, SoLuong, DonGiaNhap)
            VALUES (@MaCTPN, @MaPN, @MaSP, @SoLuong, @DonGiaNhap);";

        foreach (DataRow row in dt.Rows)
        {
            int.TryParse(row["SoLuong"]?.ToString(), out int soLuong);
            decimal.TryParse(row["DonGiaNhap"]?.ToString(), out decimal donGiaNhap);

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaCTPN", row["MaCTPN"]?.ToString() ?? ""),
                new SqlParameter("@MaPN", (object?)(row["MaPN"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@MaSP", (object?)(row["MaSP"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGiaNhap", donGiaNhap));
        }
    }

    private static void SyncHoaDon()
    {
        DataTable dt = XmlDataService.LoadTable("HoaDon.xml", "HoaDon");
        string sql = @"
            MERGE HoaDon AS target
            USING (SELECT @MaHD AS MaHD, @MaKH AS MaKH, @MaNV AS MaNV, @NgayLap AS NgayLap, @TongTien AS TongTien) AS source
            ON target.MaHD = source.MaHD
            WHEN MATCHED THEN UPDATE SET MaKH = source.MaKH, MaNV = source.MaNV, NgayLap = source.NgayLap, TongTien = source.TongTien
            WHEN NOT MATCHED THEN INSERT (MaHD, MaKH, MaNV, NgayLap, TongTien) VALUES (source.MaHD, source.MaKH, source.MaNV, source.NgayLap, source.TongTien);";

        foreach (DataRow row in dt.Rows)
        {
            DateTime.TryParse(row["NgayLap"]?.ToString(), out DateTime ngayLap);
            decimal.TryParse(row["TongTien"]?.ToString(), out decimal tongTien);

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaHD", row["MaHD"]?.ToString() ?? ""),
                new SqlParameter("@MaKH", (object?)(row["MaKH"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@MaNV", (object?)(row["MaNV"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@NgayLap", ngayLap),
                new SqlParameter("@TongTien", tongTien));
        }
    }

    private static void SyncChiTietHoaDon()
    {
        DataTable dt = XmlDataService.LoadTable("Chitiethoadon.xml", "ChiTietHoaDon");
        // Xóa toàn bộ để tránh trùng lặp
        DatabaseHelper.ExecuteNonQuery("DELETE FROM ChiTietHoaDon");

        string sql = @"
            INSERT INTO ChiTietHoaDon (MaCTHD, MaHD, MaSP, SoLuong, DonGia)
            VALUES (@MaCTHD, @MaHD, @MaSP, @SoLuong, @DonGia);";

        foreach (DataRow row in dt.Rows)
        {
            int.TryParse(row["SoLuong"]?.ToString(), out int soLuong);
            decimal.TryParse(row["DonGia"]?.ToString(), out decimal donGia);

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@MaCTHD", row["MaCTHD"]?.ToString() ?? ""),
                new SqlParameter("@MaHD", (object?)(row["MaHD"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@MaSP", (object?)(row["MaSP"]?.ToString()) ?? DBNull.Value),
                new SqlParameter("@SoLuong", soLuong),
                new SqlParameter("@DonGia", donGia));
        }
    }
}

