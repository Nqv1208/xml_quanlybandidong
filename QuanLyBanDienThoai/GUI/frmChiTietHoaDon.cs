using QuanLyBanDienThoai.Data;
using System.Data;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmChiTietHoaDon : Form
    {
        private string _maHD;
        private DataTable _dtHoaDon = new();
        private DataTable _dtChiTiet = new();
        private DataTable _dtSanPham = new();
        private DataTable _dtKhach = new();
        private DataTable _dtNhanVien = new();

        public frmChiTietHoaDon(string maHD)
        {
            InitializeComponent();
            _maHD = maHD;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _dtHoaDon = XmlDataService.LoadTable("Hoadon.xml", "HoaDon");
                DataRow? hd = _dtHoaDon.AsEnumerable()
                                       .FirstOrDefault(r => r.Field<string>("MaHD") == _maHD);

                if (hd == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi");
                    Close();
                    return;
                }

                _dtKhach = XmlDataService.LoadTable("Khachhang.xml", "KhachHang");
                _dtNhanVien = XmlDataService.LoadTable("Nhanvien.xml", "NhanVien");

                string maKH = hd["MaKH"]?.ToString() ?? "";
                string maNV = hd["MaNV"]?.ToString() ?? "";

                DataRow? kh = _dtKhach.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaKH") == maKH);
                DataRow? nv = _dtNhanVien.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaNV") == maNV);

                // ======= HIỂN THỊ THÔNG TIN HÓA ĐƠN =======
                lblMaHD.Text = $"Mã hóa đơn: {_maHD}";
                lblKhach.Text = $"Khách hàng: {kh?["TenKH"]?.ToString() ?? "N/A"}";
                lblNhanVien.Text = $"Nhân viên: {nv?["TenNV"]?.ToString() ?? "N/A"}";

                if (DateTime.TryParse(hd["NgayLap"]?.ToString(), out DateTime ngayLap))
                    lblNgayLap.Text = $"Ngày lập: {ngayLap:dd/MM/yyyy HH:mm}";

                // Load chi tiết
                LoadChiTiet();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadChiTiet()
        {
            // Nếu file chưa tồn tại → tạo DataTable rỗng
            string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "Chitiethoadon.xml");

            if (File.Exists(filePath))
                _dtChiTiet = XmlDataService.LoadTable("Chitiethoadon.xml", "ChiTietHoaDon");
            else
            {
                _dtChiTiet = new DataTable("ChiTietHoaDon");
                _dtChiTiet.Columns.Add("MaCTHD", typeof(string));
                _dtChiTiet.Columns.Add("MaHD", typeof(string));
                _dtChiTiet.Columns.Add("MaSP", typeof(string));
                _dtChiTiet.Columns.Add("SoLuong", typeof(int));
                _dtChiTiet.Columns.Add("DonGia", typeof(decimal));
                _dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));
            }

            // Lọc theo hóa đơn
            DataView dv = _dtChiTiet.DefaultView;
            dv.RowFilter = $"MaHD = '{_maHD}'";
            DataTable filtered = dv.ToTable();

            // LOAD SẢN PHẨM
            _dtSanPham = XmlDataService.LoadTable("Sanpham.xml", "SanPham");
            var spLookup = _dtSanPham.AsEnumerable()
                .ToDictionary(r => r.Field<string>("MaSP"), r => r.Field<string>("TenSP"));

            // Tạo bảng hiển thị
            DataTable view = new();
            view.Columns.Add("Mã CT", typeof(string));
            view.Columns.Add("Mã SP", typeof(string));
            view.Columns.Add("Tên sản phẩm", typeof(string));
            view.Columns.Add("Số lượng", typeof(int));
            view.Columns.Add("Đơn giá", typeof(decimal));
            view.Columns.Add("Thành tiền", typeof(decimal));

            decimal tongTien = 0;

            foreach (DataRow row in filtered.Rows)
            {
                string maSP = row["MaSP"]?.ToString() ?? "";

                string tenSP = spLookup.ContainsKey(maSP) ? spLookup[maSP] : "N/A";

                int soLuong = Convert.ToInt32(row["SoLuong"] ?? 0);
                decimal donGia = Convert.ToDecimal(row["DonGia"] ?? 0);
                decimal thanhTien = soLuong * donGia;

                view.Rows.Add(
                    row["MaCTHD"],
                    maSP,
                    tenSP,
                    soLuong,
                    donGia,
                    thanhTien
                );

                tongTien += thanhTien;

                // cập nhật thanh tiền vào DataTable gốc nếu chưa có
                row["ThanhTien"] = thanhTien;
            }

            // Hiện lên DGV
            dgvChiTiet.DataSource = view;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // format tiền
            dgvChiTiet.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
            dgvChiTiet.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";

            // ======= CẬP NHẬT TỔNG TIỀN CHO HÓA ĐƠN =======
            UpdateTongTien(tongTien);
        }

        private void UpdateTongTien(decimal tongTien)
        {
            DataRow? row = _dtHoaDon.AsEnumerable()
                                    .FirstOrDefault(r => r.Field<string>("MaHD") == _maHD);

            if (row != null)
            {
                row["TongTien"] = tongTien;
                XmlDataService.SaveTable(_dtHoaDon, "Hoadon.xml", "HoaDon");
            }

            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đ";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
