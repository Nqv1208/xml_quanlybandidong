namespace QuanLyBanDienThoai.Models;

public class ChiTietHoaDon
{
    public string MaCTHD { get; set; } = string.Empty;
    public string MaHD { get; set; } = string.Empty;
    public string MaSP { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien { get; set; }
}

