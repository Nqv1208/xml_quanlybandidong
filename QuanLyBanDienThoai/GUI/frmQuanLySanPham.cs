using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanDienThoai.DAL;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLySanPham : Form
    {
        private DataTable _dtSp = new();
        private DataTable _dtHang = new();

        public frmQuanLySanPham()
        {
            InitializeComponent();
            LoadDataXml();
        }

        // ====================================================
        // LOAD DỮ LIỆU
        // ====================================================
        private void LoadDataXml()
        {
            _dtSp = XmlDataService.LoadTable("Sanpham.xml", "SanPham");
            _dtHang = XmlDataService.LoadTable("Hangsanxuat.xml", "HangSanXuat");
            if (!_dtHang.Columns.Contains("DisplayH"))
                _dtHang.Columns.Add("DisplayH", typeof(string));

            foreach (DataRow r in _dtHang.Rows)
            {
                string maH = r["MaHang"]?.ToString() ?? "";
                string tenH = r["TenHang"]?.ToString() ?? "";
                r["DisplayH"] = $"{maH} - {tenH}";
            }

            cboHang.DataSource = _dtHang;
            cboHang.DisplayMember = "DisplayH";  // HIỂN THỊ: MaKH - TenKH
            cboHang.ValueMember = "MaHang";

            dgvSanPham.DataSource = _dtSp;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        // ====================================================
        // TỰ TĂNG MÃ SP
        // ====================================================
        private string AutoMaSP()
        {
            if (_dtSp.Rows.Count == 0)
                return "SP001";

            int maxId = _dtSp.AsEnumerable()
                .Select(r => int.Parse(r.Field<string>("MaSP").Substring(2)))
                .Max();

            return "SP" + (maxId + 1).ToString("000");
        }

        // ====================================================
        // THÊM SẢN PHẨM
        // ====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                DataRow row = _dtSp.NewRow();
                row["MaSP"] = AutoMaSP();
                row["TenSP"] = txtTenSP.Text.Trim();
                row["MaHang"] = cboHang.SelectedValue.ToString();
                row["GiaBan"] = decimal.Parse(txtGia.Text.Trim());
                row["SoLuongTon"] = int.Parse(txtSoLuong.Text.Trim());
                row["MoTa"] = txtMoTa.Text.Trim();

                _dtSp.Rows.Add(row);
                XmlDataService.SaveTable(_dtSp, "Sanpham.xml", "SanPham");

                MessageBox.Show("Thêm sản phẩm thành công!");
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ====================================================
        // SỬA
        // ====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string ma = txtMaSP.Text.Trim();
            DataRow row = _dtSp.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaSP") == ma);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
                return;
            }

            row["TenSP"] = txtTenSP.Text.Trim();
            row["MaHang"] = cboHang.SelectedValue.ToString();
            row["GiaBan"] = decimal.Parse(txtGia.Text.Trim());
            row["SoLuongTon"] = int.Parse(txtSoLuong.Text.Trim());
            row["MoTa"] = txtMoTa.Text.Trim();

            XmlDataService.SaveTable(_dtSp, "Sanpham.xml", "SanPham");

            MessageBox.Show("Cập nhật thành công!");
            ClearFields();
            LoadDataXml();
        }

        // ====================================================
        // XÓA
        // ====================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Chọn sản phẩm cần xóa!");
                return;
            }

            if (MessageBox.Show("Xóa sản phẩm này?", "Xác nhận!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            string ma = txtMaSP.Text.Trim();
            DataRow row = _dtSp.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaSP") == ma);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
                return;
            }

            _dtSp.Rows.Remove(row);
            XmlDataService.SaveTable(_dtSp, "Sanpham.xml", "SanPham");

            MessageBox.Show("Xóa thành công!");
            ClearFields();
            LoadDataXml();
        }

        // ====================================================
        // TÌM KIẾM
        // ====================================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(s))
            {
                dgvSanPham.DataSource = _dtSp;   // trả về bảng gốc
                return;
            }

            DataView dv = new DataView(_dtSp);

            dv.RowFilter =
                $"MaSP LIKE '%{s}%' OR " +
                $"TenSP LIKE '%{s}%' OR " +
                $"MaHang LIKE '%{s}%' OR " +
                $"CONVERT(GiaBan, 'System.String') LIKE '%{s}%' OR " +
                $"CONVERT(SoLuongTon, 'System.String') LIKE '%{s}%' OR " +
                $"MoTa LIKE '%{s}%'";

            dgvSanPham.DataSource = dv;  // không dùng ToTable()
        }



        // ====================================================
        // CLICK LÊN DATAGRIDVIEW
        // ====================================================
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgvSanPham.Rows[e.RowIndex];

            txtMaSP.Text = r.Cells["MaSP"].Value?.ToString() ?? "";
            txtTenSP.Text = r.Cells["TenSP"].Value?.ToString() ?? "";
            txtGia.Text = r.Cells["GiaBan"].Value?.ToString() ?? "";
            txtSoLuong.Text = r.Cells["SoLuongTon"].Value?.ToString() ?? "";
            txtMoTa.Text = r.Cells["MoTa"].Value?.ToString() ?? "";

            // xử lý combobox hãng
            if (r.Cells["MaHang"].Value != null)
                cboHang.SelectedValue = r.Cells["MaHang"].Value.ToString();
        }


        // ====================================================
        // KIỂM TRA INPUT
        // ====================================================
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return false;
            }

            if (!decimal.TryParse(txtGia.Text, out _))
            {
                MessageBox.Show("Giá bán phải là số!");
                return false;
            }

            if (!int.TryParse(txtSoLuong.Text, out _))
            {
                MessageBox.Show("Số lượng phải là số!");
                return false;
            }

            return true;
        }

        // ====================================================
        // LÀM MỚI
        // ====================================================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtTimKiem.Clear();
            LoadDataXml();
        }

        private void ClearFields()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtMoTa.Clear();
        }

        private void btnXuatHTML_Click(object sender, EventArgs e)
        {
            if (_dtSp == null || _dtSp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files|*.html";
            sfd.FileName = "DanhSachSanPham.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string html = XmlDataService.ConvertDataTableToHtml(_dtSp, "Sanpham.xslt", "SanPham");
                    File.WriteAllText(sfd.FileName, html, Encoding.UTF8);

                    MessageBox.Show("Xuất HTML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetDisplayName(string columnName)
        {
            // map tiêu đề cột thân thiện cho sản phẩm
            var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"MaSP", "Mã SP"},
        {"TenSP", "Tên sản phẩm"},
        {"MaHang", "Mã hãng"},
        {"GiaBan", "Giá bán"},
        {"SoLuongTon", "Tồn kho"},
        {"MoTa", "Mô tả"},
        // nếu xml của bạn có cột khác, thêm vào đây
    };

            return map.ContainsKey(columnName) ? map[columnName] : columnName;
        }
    }
}
