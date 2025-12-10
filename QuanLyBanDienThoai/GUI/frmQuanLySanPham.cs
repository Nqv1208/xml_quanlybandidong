using System.Data;
using Guna.UI2.WinForms;
using QuanLyBanDienThoai.Data;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLySanPham : Form
    {
        private DataTable _dtSanPham = new();
        private DataTable _dtHang = new();

        public frmQuanLySanPham()
        {
            InitializeComponent();
            LoadHangSanXuatXml();
            LoadDataXml();
        }

        private void LoadHangSanXuatXml()
        {
            _dtHang = XmlDataService.LoadTable("Hangsanxuat.xml", "HangSanXuat");
            cboMaHang.DataSource = _dtHang;
            cboMaHang.DisplayMember = "TenHang";
            cboMaHang.ValueMember = "MaHang";
        }

        private void LoadDataXml()
        {
            _dtSanPham = XmlDataService.LoadTable("Sanpham.xml", "SanPham");

            // tạo bảng hiển thị kèm tên hãng
            DataTable dtView = _dtSanPham.Copy();
            if (!dtView.Columns.Contains("TenHang"))
            {
                dtView.Columns.Add("TenHang", typeof(string));
            }

            var hangLookup = _dtHang.AsEnumerable()
                .ToDictionary(r => r.Field<string>("MaHang"), r => r.Field<string>("TenHang"));

            foreach (DataRow row in dtView.Rows)
            {
                string maHang = row["MaHang"]?.ToString() ?? "";
                row["TenHang"] = hangLookup.ContainsKey(maHang) ? hangLookup[maHang] : "";
            }

            dgvSanPham.DataSource = dtView;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string ma = txtMaSP.Text.Trim();
            if (_dtSanPham.AsEnumerable().Any(r => r.Field<string>("MaSP") == ma))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow row = _dtSanPham.NewRow();
                row["MaSP"] = ma;
                row["TenSP"] = txtTenSP.Text.Trim();
                row["MaHang"] = cboMaHang.SelectedValue?.ToString() ?? "";
                row["GiaBan"] = decimal.Parse(txtGiaBan.Text);
                row["SoLuongTon"] = int.Parse(txtSoLuongTon.Text);
                row["MoTa"] = txtMoTa.Text.Trim();
                _dtSanPham.Rows.Add(row);

                XmlDataService.SaveTable(_dtSanPham, "Sanpham.xml", "SanPham");
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                string ma = txtMaSP.Text.Trim();
                DataRow? row = _dtSanPham.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaSP") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                row["TenSP"] = txtTenSP.Text.Trim();
                row["MaHang"] = cboMaHang.SelectedValue?.ToString() ?? "";
                row["GiaBan"] = decimal.Parse(txtGiaBan.Text);
                row["SoLuongTon"] = int.Parse(txtSoLuongTon.Text);
                row["MoTa"] = txtMoTa.Text.Trim();

                XmlDataService.SaveTable(_dtSanPham, "Sanpham.xml", "SanPham");
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string ma = txtMaSP.Text.Trim();
                DataRow? row = _dtSanPham.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaSP") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _dtSanPham.Rows.Remove(row);
                XmlDataService.SaveTable(_dtSanPham, "Sanpham.xml", "SanPham");
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "\nCó thể sản phẩm này đang được sử dụng trong hóa đơn hoặc phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadDataXml();
                return;
            }

            var view = _dtSanPham.Copy();
            if (!view.Columns.Contains("TenHang"))
                view.Columns.Add("TenHang", typeof(string));

            var hangLookup = _dtHang.AsEnumerable()
                .ToDictionary(r => r.Field<string>("MaHang"), r => r.Field<string>("TenHang"));

            foreach (DataRow row in view.Rows)
            {
                string maHang = row["MaHang"]?.ToString() ?? "";
                row["TenHang"] = hangLookup.ContainsKey(maHang) ? hangLookup[maHang] : "";
            }

            string filter = searchText.Replace("'", "''");
            DataView dv = view.DefaultView;
            dv.RowFilter = $"MaSP LIKE '%{filter}%' OR TenSP LIKE '%{filter}%' OR TenHang LIKE '%{filter}%'";
            dgvSanPham.DataSource = dv.ToTable();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtTimKiem.Clear();
            LoadDataXml();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();

                string maHang = row.Cells["MaHang"]?.Value?.ToString() ?? "";
                cboMaHang.SelectedValue = maHang;

                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString() ?? "0";
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString() ?? "0";
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString() ?? "";
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaBan.Text, out decimal giaBan) || giaBan < 0)
            {
                MessageBox.Show("Vui lòng nhập giá bán hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuongTon.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng tồn hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongTon.Focus();
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            if (cboMaHang.Items.Count > 0)
                cboMaHang.SelectedIndex = 0;
            txtGiaBan.Clear();
            txtSoLuongTon.Clear();
            txtMoTa.Clear();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {

        }
    }
}

