using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanDienThoai.DAL;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLyHoaDon : Form
    {
        private DataTable _dtHd = new();
        private DataTable _dtKh = new();
        private DataTable _dtNv = new();

        private frmMain _parent;
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            LoadDataXml();
        }
        public frmQuanLyHoaDon(frmMain parent) : this()
        {
            _parent = parent;
        }

        // ====================================================
        // LOAD TẤT CẢ DỮ LIỆU
        // ====================================================
        private void LoadDataXml()
        {
            _dtHd = XmlDataService.LoadTable("Hoadon.xml", "HoaDon");
            _dtKh = XmlDataService.LoadTable("Khachhang.xml", "KhachHang");
            _dtNv = XmlDataService.LoadTable("Nhanvien.xml", "NhanVien");

            // ====== TẠO CỘT HIỂN THỊ ĐẸP CHO KHÁCH HÀNG ======
            if (!_dtKh.Columns.Contains("DisplayKH"))
                _dtKh.Columns.Add("DisplayKH", typeof(string));

            foreach (DataRow r in _dtKh.Rows)
            {
                string ma = r["MaKH"]?.ToString() ?? "";
                string ten = r["TenKH"]?.ToString() ?? "";
                r["DisplayKH"] = $"{ma} - {ten}";
            }

            cboKhach.DataSource = _dtKh;
            cboKhach.DisplayMember = "DisplayKH";  // HIỂN THỊ: MaKH - TenKH
            cboKhach.ValueMember = "MaKH";         // GIÁ TRỊ LƯU: MaKH

            // ====== TẠO CỘT HIỂN THỊ ĐẸP CHO NHÂN VIÊN ======
            if (!_dtNv.Columns.Contains("DisplayNV"))
                _dtNv.Columns.Add("DisplayNV", typeof(string));

            foreach (DataRow r in _dtNv.Rows)
            {
                string ma = r["MaNV"]?.ToString() ?? "";
                string ten = r["TenNV"]?.ToString() ?? "";
                r["DisplayNV"] = $"{ma} - {ten}";
            }

            cboNhanVien.DataSource = _dtNv;
            cboNhanVien.DisplayMember = "DisplayNV"; // HIỂN THỊ: MaNV - TenNV
            cboNhanVien.ValueMember = "MaNV";        // GIÁ TRỊ LƯU: MaNV

            // ====== LOAD HÓA ĐƠN LÊN GRID ======
            dgvHoaDon.DataSource = _dtHd;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ====================================================
        // TỰ TẠO MÃ HD
        // ====================================================
        private string AutoMaHD()
        {
            if (_dtHd.Rows.Count == 0)
                return "HD001";

            int maxNumber = _dtHd.AsEnumerable()
                .Select(r => int.Parse(r.Field<string>("MaHD").Substring(2)))
                .Max();

            return "HD" + (maxNumber + 1).ToString("000");
        }

        // ====================================================
        // LÀM MỚI
        // ====================================================
        private void LamMoi()
        {
            txtMaHD.Text = AutoMaHD();
            txtTongTien.Text = "";
            txtTimKiemHD.Clear();

            if (cboKhach.Items.Count > 0) cboKhach.SelectedIndex = 0;
            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;

            dtNgayLap.Value = DateTime.Now;

            dgvHoaDon.DataSource = _dtHd;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // ====================================================
        // KIỂM TRA DỮ LIỆU
        // ====================================================
        private bool ValidateInput()
        {
            if (cboKhach.SelectedValue == null || cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng và nhân viên!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTongTien.Text) ||
                !decimal.TryParse(txtTongTien.Text, out _))
            {
                MessageBox.Show("Tổng tiền không hợp lệ!");
                return false;
            }

            return true;
        }

        // ====================================================
        // THÊM HÓA ĐƠN
        // ====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                DataRow newRow = _dtHd.NewRow();
                newRow["MaHD"] = AutoMaHD();
                newRow["MaKH"] = cboKhach.SelectedValue.ToString();
                newRow["MaNV"] = cboNhanVien.SelectedValue.ToString();
                newRow["NgayLap"] = dtNgayLap.Value;
                newRow["TongTien"] = decimal.Parse(txtTongTien.Text);

                _dtHd.Rows.Add(newRow);

                XmlDataService.SaveTable(_dtHd, "Hoadon.xml", "HoaDon");

                MessageBox.Show("Thêm hóa đơn thành công!");
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        // ====================================================
        // SỬA HÓA ĐƠN
        // ====================================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Chọn hóa đơn cần sửa!");
                return;
            }
            if (!ValidateInput()) return;

            string ma = txtMaHD.Text.Trim();
            DataRow row = _dtHd.AsEnumerable()
                               .FirstOrDefault(r => r.Field<string>("MaHD") == ma);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
                return;
            }

            try
            {
                row["MaKH"] = cboKhach.SelectedValue.ToString();
                row["MaNV"] = cboNhanVien.SelectedValue.ToString();
                row["NgayLap"] = dtNgayLap.Value;
                row["TongTien"] = decimal.Parse(txtTongTien.Text.Trim());

                XmlDataService.SaveTable(_dtHd, "Hoadon.xml", "HoaDon");

                MessageBox.Show("Cập nhật hóa đơn thành công!");
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        // ====================================================
        // XÓA HÓA ĐƠN
        // ====================================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Chọn hóa đơn cần xóa!");
                return;
            }

            string maHD = txtMaHD.Text.Trim();
            DataRow row = _dtHd.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaHD") == maHD);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
                return;
            }

            try
            {
                _dtHd.Rows.Remove(row);
                XmlDataService.SaveTable(_dtHd, "Hoadon.xml", "HoaDon");

                MessageBox.Show("Xóa thành công!");
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        // ====================================================
        // TÌM KIẾM
        // ====================================================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s = txtTimKiemHD.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(s))
            {
                dgvHoaDon.DataSource = _dtHd;
                return;
            }

            var filtered = _dtHd.AsEnumerable()
                .Where(r =>
                    r["MaHD"].ToString().ToLower().Contains(s) ||
                    r["MaKH"].ToString().ToLower().Contains(s) ||
                    r["MaNV"].ToString().ToLower().Contains(s) ||
                    r["NgayLap"].ToString().ToLower().Contains(s) ||
                    r["TongTien"].ToString().ToLower().Contains(s)
                );

            dgvHoaDon.DataSource = filtered.Any() ? filtered.CopyToDataTable() : _dtHd.Clone();
        }

        // ====================================================
        // CLICK GRID → ĐỔ LÊN FORM
        // ====================================================
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvHoaDon.Rows[e.RowIndex];

            txtMaHD.Text = r.Cells["MaHD"].Value?.ToString();
            txtTongTien.Text = r.Cells["TongTien"].Value?.ToString();

            cboKhach.SelectedValue = r.Cells["MaKH"].Value?.ToString();
            cboNhanVien.SelectedValue = r.Cells["MaNV"].Value?.ToString();

            if (DateTime.TryParse(r.Cells["NgayLap"].Value?.ToString(), out DateTime ngay))
                dtNgayLap.Value = ngay;
            if (e.RowIndex < 0) return;

            string maHD = dgvHoaDon.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();

            if (!string.IsNullOrEmpty(maHD))
            {
                frmChiTietHoaDon frm = new frmChiTietHoaDon(_parent, maHD, this);
                _parent.OpenChildForm(frm);
            }
        }

        private void btnXuatHTML_Click(object sender, EventArgs e)
        {
            if (_dtHd == null || _dtHd.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files|*.html";
            sfd.FileName = "DanhSachHoaDon.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string htmlContent = XmlDataService.ConvertDataTableToHtml(_dtHd, "Hoadon.xslt", "HoaDon");

                    File.WriteAllText(sfd.FileName, htmlContent, Encoding.UTF8);

                    MessageBox.Show("Xuất HTML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName)
                    {
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetDisplayName(string columnName)
        {
            var map = new Dictionary<string, string>
    {
        { "MaHD", "Mã Hóa Đơn" },
        { "MaKH", "Mã KH" },
        { "MaNV", "Mã NV" },
        { "NgayLap", "Ngày Lập" },
        { "TongTien", "Tổng Tiền" }
    };

            return map.ContainsKey(columnName) ? map[columnName] : columnName;
        }

    }
}
