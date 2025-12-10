using System.Data;
using Guna.UI2.WinForms;
using QuanLyBanDienThoai.Data;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLyHangSanXuat : Form
    {
        private DataTable _dtHang = new();

        public frmQuanLyHangSanXuat()
        {
            InitializeComponent();
            LoadDataXml();
        }

        private void LoadDataXml()
        {
            _dtHang = XmlDataService.LoadTable("Hangsanxuat.xml", "HangSanXuat");
            dgvHangSanXuat.DataSource = _dtHang.Copy();
            dgvHangSanXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) || string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_dtHang.AsEnumerable().Any(r => r.Field<string>("MaHang") == txtMaHang.Text.Trim()))
            {
                MessageBox.Show("Mã hãng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow row = _dtHang.NewRow();
                row["MaHang"] = txtMaHang.Text.Trim();
                row["TenHang"] = txtTenHang.Text.Trim();
                _dtHang.Rows.Add(row);

                XmlDataService.SaveTable(_dtHang, "Hangsanxuat.xml", "HangSanXuat");
                MessageBox.Show("Thêm hãng sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvHangSanXuat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hãng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ma = txtMaHang.Text.Trim();
                DataRow? row = _dtHang.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaHang") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy hãng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                row["TenHang"] = txtTenHang.Text.Trim();
                XmlDataService.SaveTable(_dtHang, "Hangsanxuat.xml", "HangSanXuat");
                MessageBox.Show("Cập nhật hãng sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvHangSanXuat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hãng sản xuất này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string ma = txtMaHang.Text.Trim();
                DataRow? row = _dtHang.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaHang") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy hãng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _dtHang.Rows.Remove(row);
                XmlDataService.SaveTable(_dtHang, "Hangsanxuat.xml", "HangSanXuat");
                MessageBox.Show("Xóa hãng sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nCó thể hãng này đang được sử dụng trong sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadDataXml();
        }

        private void dgvHangSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangSanXuat.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells["MaHang"].Value?.ToString();
                txtTenHang.Text = row.Cells["TenHang"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenHang_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyHangSanXuat_Load(object sender, EventArgs e)
        {

        }
    }
}

