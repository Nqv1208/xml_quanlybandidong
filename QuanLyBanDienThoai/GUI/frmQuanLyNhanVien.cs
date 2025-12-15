using System.Data;
using System.Text;
using Guna.UI2.WinForms;
using QuanLyBanDienThoai.DAL;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLyNhanVien : Form
    {
        private DataTable _dtNhanVien = new();

        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            LoadDataXml();
        }

        private void LoadDataXml()
        {
            _dtNhanVien = XmlDataService.LoadTable("Nhanvien.xml", "NhanVien");
            dgvNhanVien.DataSource = _dtNhanVien.Copy();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_dtNhanVien.AsEnumerable().Any(r => r.Field<string>("MaNV") == txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow row = _dtNhanVien.NewRow();
                row["MaNV"] = txtMaNV.Text.Trim();
                row["TenNV"] = txtTenNV.Text.Trim();
                row["ChucVu"] = txtChucVu.Text.Trim();
                row["SoDienThoai"] = txtSoDienThoai.Text.Trim();
                _dtNhanVien.Rows.Add(row);

                XmlDataService.SaveTable(_dtNhanVien, "Nhanvien.xml", "NhanVien");
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ma = txtMaNV.Text.Trim();
                DataRow? row = _dtNhanVien.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaNV") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                row["TenNV"] = txtTenNV.Text.Trim();
                row["ChucVu"] = txtChucVu.Text.Trim();
                row["SoDienThoai"] = txtSoDienThoai.Text.Trim();
                XmlDataService.SaveTable(_dtNhanVien, "Nhanvien.xml", "NhanVien");
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string ma = txtMaNV.Text.Trim();
                DataRow? row = _dtNhanVien.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaNV") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _dtNhanVien.Rows.Remove(row);
                XmlDataService.SaveTable(_dtNhanVien, "Nhanvien.xml", "NhanVien");
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nCó thể nhân viên này đang được sử dụng trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadDataXml();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value?.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtChucVu.Clear();
            txtSoDienThoai.Clear();
        }

        private void btn_chuyendoi_Click(object sender, EventArgs e)
        {
            if (_dtNhanVien == null || _dtNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để chuyển đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files|*.html";
            sfd.FileName = "DanhSachNhanVien.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dtToExport = (DataTable)dgvNhanVien.DataSource ?? _dtNhanVien.Copy();
                    string htmlContent = XmlDataService.ConvertDataTableToHtml(dtToExport, "Nhanvien.xslt", "NhanVien");
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
                DataView dv = _dtNhanVien.DefaultView;
                dv.RowFilter = $"MaNV LIKE '%{filter}%' OR TenNV LIKE '%{filter}%' OR ChucVu LIKE '%{filter}%' OR SoDienThoai LIKE '%{filter}%'";

                DataTable filtered = dv.ToTable();
                dgvNhanVien.DataSource = filtered;
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void groupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

