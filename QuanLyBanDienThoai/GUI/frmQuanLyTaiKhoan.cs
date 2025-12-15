using System.Data;
using System.Text;
using Guna.UI2.WinForms;
using QuanLyBanDienThoai.DAL;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        private DataTable _dtTaiKhoan = new();
        private DataTable _dtNhanVien = new();

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadNhanVienXml();
            LoadDataXml();
        }

        private void LoadNhanVienXml()
        {
            _dtNhanVien = XmlDataService.LoadTable("Nhanvien.xml", "NhanVien");

            if (!_dtNhanVien.Columns.Contains("DisplayNV"))
                _dtNhanVien.Columns.Add("DisplayNV", typeof(string));

            foreach (DataRow r in _dtNhanVien.Rows)
            {
                string ma = r["MaNV"]?.ToString() ?? "";
                string ten = r["TenNV"]?.ToString() ?? "";
                r["DisplayNV"] = $"{ma} - {ten}";
            }

            cboNhanVien.DataSource = _dtNhanVien.Copy();
            cboNhanVien.DisplayMember = "DisplayNV";
            cboNhanVien.ValueMember = "MaNV";
            if (cboNhanVien.Items.Count > 0)
                cboNhanVien.SelectedIndex = 0;
        }

        private void LoadDataXml()
        {
            _dtTaiKhoan = XmlDataService.LoadTable("Taikhoan.xml", "TaiKhoan");
            dgvTaiKhoan.DataSource = _dtTaiKhoan.Copy();
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTK.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(cboQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_dtTaiKhoan.AsEnumerable().Any(r => r.Field<string>("MaTK") == txtMaTK.Text.Trim()))
            {
                MessageBox.Show("Mã tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_dtTaiKhoan.AsEnumerable().Any(r => r.Field<string>("TenDangNhap") == txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow row = _dtTaiKhoan.NewRow();
                row["MaTK"] = txtMaTK.Text.Trim();
                row["TenDangNhap"] = txtTenDangNhap.Text.Trim();
                row["MatKhau"] = txtMatKhau.Text.Trim();
                row["Quyen"] = cboQuyen.Text.Trim();
                row["MaNV"] = cboNhanVien.SelectedValue?.ToString() ?? "";
                _dtTaiKhoan.Rows.Add(row);

                XmlDataService.SaveTable(_dtTaiKhoan, "Taikhoan.xml", "TaiKhoan");
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ma = txtMaTK.Text.Trim();
                DataRow? row = _dtTaiKhoan.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaTK") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                row["TenDangNhap"] = txtTenDangNhap.Text.Trim();
                row["MatKhau"] = txtMatKhau.Text.Trim();
                row["Quyen"] = cboQuyen.Text.Trim();
                row["MaNV"] = cboNhanVien.SelectedValue?.ToString() ?? "";
                XmlDataService.SaveTable(_dtTaiKhoan, "Taikhoan.xml", "TaiKhoan");
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string ma = txtMaTK.Text.Trim();
                DataRow? row = _dtTaiKhoan.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaTK") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _dtTaiKhoan.Rows.Remove(row);
                XmlDataService.SaveTable(_dtTaiKhoan, "Taikhoan.xml", "TaiKhoan");
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadDataXml();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTK.Text = row.Cells["MaTK"].Value?.ToString();
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
                cboQuyen.Text = row.Cells["Quyen"].Value?.ToString();

                string maNV = row.Cells["MaNV"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(maNV))
                {
                    cboNhanVien.SelectedValue = maNV;
                }
            }
        }

        private void ClearFields()
        {
            txtMaTK.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyen.SelectedIndex = -1;
            if (cboNhanVien.Items.Count > 0)
                cboNhanVien.SelectedIndex = 0;
        }

        private void btn_chuyendoi_Click(object sender, EventArgs e)
        {
            if (_dtTaiKhoan == null || _dtTaiKhoan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để chuyển đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files|*.html";
            sfd.FileName = "DanhSachTaiKhoan.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dtToExport = (DataTable)dgvTaiKhoan.DataSource ?? _dtTaiKhoan.Copy();
                    string htmlContent = XmlDataService.ConvertDataTableToHtml(dtToExport, "Taikhoan.xslt", "TaiKhoan");
                    File.WriteAllText(sfd.FileName, htmlContent, Encoding.UTF8);
                    MessageBox.Show("Chuyển đổi HTML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                LoadDataXml();
                return;
            }

            try
            {
                string filter = txtTimKiem.Text.Trim().Replace("'", "''");
                DataView dv = _dtTaiKhoan.DefaultView;
                dv.RowFilter = $"MaTK LIKE '%{filter}%' OR TenDangNhap LIKE '%{filter}%' OR Quyen LIKE '%{filter}%' OR MaNV LIKE '%{filter}%'";

                DataTable filtered = dv.ToTable();
                dgvTaiKhoan.DataSource = filtered;
                dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

