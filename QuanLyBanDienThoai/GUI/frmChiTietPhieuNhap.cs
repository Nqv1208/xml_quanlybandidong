using QuanLyBanDienThoai.DAL;
using System.Data;
using System.Text;
using Guna.UI2.WinForms;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmChiTietPhieuNhap : Form
    {
        private string _maPN;
        private DataTable _dtChiTiet = new();
        private DataTable _dtSanPham = new();
        private DataTable _dtPhieuNhap = new();
        private DataTable _dtNCC = new();
        private frmMain _parent;

        public frmChiTietPhieuNhap(string maPN, frmMain parent)
        {
            InitializeComponent();
            _parent = parent;
            _maPN = maPN;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Load thông tin phiếu nhập
                _dtPhieuNhap = XmlDataService.LoadTable("Phieunhap.xml", "PhieuNhap");
                DataRow? phieuNhap = _dtPhieuNhap.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaPN") == _maPN);

                if (phieuNhap == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                // Load nhà cung cấp
                _dtNCC = XmlDataService.LoadTable("Nhacungcap.xml", "NhaCungCap");
                string maNCC = phieuNhap["MaNCC"]?.ToString() ?? "";
                DataRow? ncc = _dtNCC.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaNCC") == maNCC);

                // Hiển thị thông tin phiếu nhập
                lblMaPN.Text = $"Mã phiếu nhập: {_maPN}";
                lblTenNCC.Text = $"Nhà cung cấp: {(ncc?["TenNCC"]?.ToString() ?? "N/A")}";
                lblMaNV.Text = $"Mã nhân viên: {phieuNhap["MaNV"]?.ToString() ?? "N/A"}";
                
                if (DateTime.TryParse(phieuNhap["NgayNhap"]?.ToString(), out DateTime ngayNhap))
                {
                    lblNgayNhap.Text = $"Ngày nhập: {ngayNhap:dd/MM/yyyy HH:mm}";
                }

                if (decimal.TryParse(phieuNhap["TongTien"]?.ToString(), out decimal tongTien))
                {
                    lblTongTien.Text = $"Tổng tiền: {tongTien:N0} đ";
                }

                // Load chi tiết phiếu nhập
                LoadChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChiTiet()
        {
            try
            {
                // Load chi tiết từ XML (nếu file chưa có thì tạo mới)
                string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "Chitietphieunhap.xml");
                if (File.Exists(filePath))
                {
                    _dtChiTiet = XmlDataService.LoadTable("Chitietphieunhap.xml", "ChiTietPhieuNhap");
                }
                else
                {
                    // Tạo DataTable mới nếu file chưa tồn tại
                    _dtChiTiet = new DataTable("ChiTietPhieuNhap");
                    _dtChiTiet.Columns.Add("MaCTPN", typeof(string));
                    _dtChiTiet.Columns.Add("MaPN", typeof(string));
                    _dtChiTiet.Columns.Add("MaSP", typeof(string));
                    _dtChiTiet.Columns.Add("SoLuong", typeof(int));
                    _dtChiTiet.Columns.Add("DonGiaNhap", typeof(decimal));
                    _dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));
                }

                // Lọc chi tiết theo mã phiếu nhập
                DataView dv = _dtChiTiet.DefaultView;
                dv.RowFilter = $"MaPN = '{_maPN}'";
                DataTable filtered = dv.ToTable();

                // Load sản phẩm để hiển thị tên
                _dtSanPham = XmlDataService.LoadTable("Sanpham.xml", "SanPham");
                var spLookup = _dtSanPham.AsEnumerable()
                    .ToDictionary(r => r.Field<string>("MaSP"), r => r.Field<string>("TenSP"));

                // Tạo view để hiển thị
                DataTable view = filtered.Copy();
                if (!view.Columns.Contains("TenSP"))
                    view.Columns.Add("TenSP", typeof(string));

                foreach (DataRow row in view.Rows)
                {
                    string maSP = row["MaSP"]?.ToString() ?? "";
                    row["TenSP"] = spLookup.ContainsKey(maSP) ? spLookup[maSP] : "N/A";
                    
                    // Tính thành tiền nếu chưa có
                    if (row["ThanhTien"] == DBNull.Value || row["ThanhTien"] == null)
                    {
                        int soLuong = Convert.ToInt32(row["SoLuong"] ?? 0);
                        decimal donGia = Convert.ToDecimal(row["DonGiaNhap"] ?? 0);
                        row["ThanhTien"] = soLuong * donGia;
                    }
                }

                // Sắp xếp cột để hiển thị
                DataTable displayTable = new DataTable();
                displayTable.Columns.Add("Mã CT", typeof(string));
                displayTable.Columns.Add("Mã SP", typeof(string));
                displayTable.Columns.Add("Tên sản phẩm", typeof(string));
                displayTable.Columns.Add("Số lượng", typeof(int));
                displayTable.Columns.Add("Đơn giá nhập", typeof(decimal));
                displayTable.Columns.Add("Thành tiền", typeof(decimal));

                foreach (DataRow row in view.Rows)
                {
                    displayTable.Rows.Add(
                        row["MaCTPN"],
                        row["MaSP"],
                        row["TenSP"],
                        row["SoLuong"],
                        row["DonGiaNhap"],
                        row["ThanhTien"]
                    );
                }

                dgvChiTiet.DataSource = displayTable;
                dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Format cột tiền
                if (dgvChiTiet.Columns["Đơn giá nhập"] != null)
                {
                    dgvChiTiet.Columns["Đơn giá nhập"].DefaultCellStyle.Format = "N0";
                    dgvChiTiet.Columns["Đơn giá nhập"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvChiTiet.Columns["Thành tiền"] != null)
                {
                    dgvChiTiet.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
                    dgvChiTiet.Columns["Thành tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvChiTiet.Columns["Số lượng"] != null)
                {
                    dgvChiTiet.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyPhieuNhap frm = new frmQuanLyPhieuNhap(_parent);
            _parent.OpenChildForm(frm);
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin phiếu nhập
                DataRow? phieuNhap = _dtPhieuNhap.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaPN") == _maPN);

                if (phieuNhap == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin phiếu nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin nhà cung cấp
                string maNCC = phieuNhap["MaNCC"]?.ToString() ?? "";
                DataRow? ncc = _dtNCC.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaNCC") == maNCC);

                // Lọc chi tiết theo phiếu nhập
                DataView dv = _dtChiTiet.DefaultView;
                dv.RowFilter = $"MaPN = '{_maPN}'";
                DataTable filteredChiTiet = dv.ToTable();

                if (filteredChiTiet.Rows.Count == 0)
                {
                    MessageBox.Show("Không có chi tiết để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Load sản phẩm để lấy tên
                var spLookup = _dtSanPham.AsEnumerable()
                    .ToDictionary(r => r.Field<string>("MaSP"), r => r.Field<string>("TenSP"));

                // Tạo DataTable chi tiết có TenSP
                DataTable chiTietWithTenSP = filteredChiTiet.Copy();
                if (!chiTietWithTenSP.Columns.Contains("TenSP"))
                    chiTietWithTenSP.Columns.Add("TenSP", typeof(string));

                foreach (DataRow row in chiTietWithTenSP.Rows)
                {
                    string maSP = row["MaSP"]?.ToString() ?? "";
                    row["TenSP"] = spLookup.ContainsKey(maSP) ? spLookup[maSP] : "N/A";
                    
                    // Đảm bảo có ThanhTien
                    if (row["ThanhTien"] == DBNull.Value || row["ThanhTien"] == null)
                    {
                        int soLuong = Convert.ToInt32(row["SoLuong"] ?? 0);
                        decimal donGia = Convert.ToDecimal(row["DonGiaNhap"] ?? 0);
                        row["ThanhTien"] = soLuong * donGia;
                    }
                }

                // Tạo header info
                Dictionary<string, string> headerInfo = new()
                {
                    { "MaPN", _maPN },
                    { "TenNCC", ncc?["TenNCC"]?.ToString() ?? "N/A" },
                    { "MaNV", phieuNhap["MaNV"]?.ToString() ?? "N/A" },
                    { "NgayNhap", phieuNhap["NgayNhap"]?.ToString() ?? "" }
                };

                // Xuất HTML
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "HTML Files|*.html";
                sfd.FileName = $"ChiTietPhieuNhap_{_maPN}.html";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string htmlContent = XmlDataService.ConvertChiTietToHtml(
                        headerInfo,
                        chiTietWithTenSP,
                        "Chitietphieunhap.xslt",
                        "PhieuNhapInfo",
                        "ChiTietPhieuNhap");

                    File.WriteAllText(sfd.FileName, htmlContent, Encoding.UTF8);
                    MessageBox.Show("Xuất HTML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

