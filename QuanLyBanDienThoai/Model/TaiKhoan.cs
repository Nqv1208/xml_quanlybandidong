// Thuộc thư mục Model
namespace QuanLyBanDienThoai.Model
{
    public class TaiKhoan
    {
        public string MaTK { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; } // Ví dụ: Admin, NhanVien
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
    }
}