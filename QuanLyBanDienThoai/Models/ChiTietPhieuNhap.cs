namespace QuanLyBanDienThoai.Models;

public class ChiTietPhieuNhap
{
    public string MaCTPN { get; set; } = string.Empty;
    public string MaPN { get; set; } = string.Empty;
    public string MaSP { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public decimal DonGiaNhap { get; set; }
    public decimal ThanhTien { get; set; }
}

