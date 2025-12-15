namespace QuanLyBanDienThoai.Models;

public class SanPham
{
    public string MaSP { get; set; } = string.Empty;
    public string TenSP { get; set; } = string.Empty;
    public string MaHang { get; set; } = string.Empty;
    public decimal GiaBan { get; set; }
    public int SoLuongTon { get; set; }
    public string MoTa { get; set; } = string.Empty;
}

