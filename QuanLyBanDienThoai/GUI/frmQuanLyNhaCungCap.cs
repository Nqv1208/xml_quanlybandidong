using System.Data;
using QuanLyBanDienThoai.Data;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLyNhaCungCap : Form
    {
        private DataTable _dtNcc = new();

        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
            LoadDataXml();
        }

        private void LoadDataXml()
        {
            _dtNcc = XmlDataService.LoadTable("Nhacungcap.xml", "NhaCungCap");
            dgvNCC.DataSource = _dtNcc.Copy();
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (_dtNcc.AsEnumerable().Any(r => r.Field<string>("MaNCC") == txtMaNCC.Text.Trim()))
            {
                MessageBox.Show("Mã NCC đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow row = _dtNcc.NewRow();
                row["MaNCC"] = txtMaNCC.Text.Trim();
                row["TenNCC"] = txtTenNCC.Text.Trim();
                row["DiaChi"] = txtDiaChi.Text.Trim();
                row["SoDienThoai"] = txtSoDienThoai.Text.Trim();
                row["Email"] = txtEmail.Text.Trim();
                _dtNcc.Rows.Add(row);
                XmlDataService.SaveTable(_dtNcc, "Nhacungcap.xml", "NhaCungCap");
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                string ma = txtMaNCC.Text.Trim();
                DataRow? row = _dtNcc.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaNCC") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                row["TenNCC"] = txtTenNCC.Text.Trim();
                row["DiaChi"] = txtDiaChi.Text.Trim();
                row["SoDienThoai"] = txtSoDienThoai.Text.Trim();
                row["Email"] = txtEmail.Text.Trim();
                XmlDataService.SaveTable(_dtNcc, "Nhacungcap.xml", "NhaCungCap");
                MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvNCC.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string ma = txtMaNCC.Text.Trim();
                DataRow? row = _dtNcc.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaNCC") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _dtNcc.Rows.Remove(row);
                XmlDataService.SaveTable(_dtNcc, "Nhacungcap.xml", "NhaCungCap");
                MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nCó thể NCC đang được sử dụng trong phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtTimKiem.Clear();
            LoadDataXml();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text.Trim().Replace("'", "''");
            if (string.IsNullOrWhiteSpace(search))
            {
                LoadDataXml();
                return;
            }

            DataView dv = _dtNcc.DefaultView;
            dv.RowFilter = $"MaNCC LIKE '%{search}%' OR TenNCC LIKE '%{search}%'";
            dgvNCC.DataSource = dv.ToTable();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNCC"].Value?.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã NCC!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập tên NCC!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Focus();
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
        }
    }
}

