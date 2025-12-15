using QuanLyBanDienThoai.DAL;
using System.Data;
using System.Text;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLyPhieuNhap : Form
    {
        private DataTable _dtPN = new();
        private DataTable _dtNCC = new();
        private frmMain _parent;

        public frmQuanLyPhieuNhap(frmMain parent)
        {
            InitializeComponent();
            LoadNhaCungCapXml();
            LoadDataXml();
            _parent = parent;
        }

        private void LoadNhaCungCapXml()
        {
            _dtNCC = XmlDataService.LoadTable("Nhacungcap.xml", "NhaCungCap");
            cboMaNCC.DataSource = _dtNCC;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";
        }

        private void LoadDataXml()
        {
            _dtPN = XmlDataService.LoadTable("Phieunhap.xml", "PhieuNhap");

            DataTable view = _dtPN.Copy();
            if (!view.Columns.Contains("TenNCC"))
                view.Columns.Add("TenNCC", typeof(string));

            var nccLookup = _dtNCC.AsEnumerable()
                .ToDictionary(r => r.Field<string>("MaNCC"), r => r.Field<string>("TenNCC"));

            foreach (DataRow row in view.Rows)
            {
                string ma = row["MaNCC"]?.ToString() ?? "";
                row["TenNCC"] = nccLookup.ContainsKey(ma) ? nccLookup[ma] : "";
            }

            dgvPhieuNhap.DataSource = view;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            if (_dtPN.AsEnumerable().Any(r => r.Field<string>("MaPN") == txtMaPN.Text.Trim()))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow row = _dtPN.NewRow();
                row["MaPN"] = txtMaPN.Text.Trim();
                row["MaNCC"] = cboMaNCC.SelectedValue?.ToString() ?? "";
                row["MaNV"] = txtMaNV.Text.Trim();
                row["NgayNhap"] = dtNgayNhap.Value;
                row["TongTien"] = decimal.Parse(txtTongTien.Text);
                _dtPN.Rows.Add(row);

                XmlDataService.SaveTable(_dtPN, "Phieunhap.xml", "PhieuNhap");
                MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                string ma = txtMaPN.Text.Trim();
                DataRow? row = _dtPN.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaPN") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                row["MaNCC"] = cboMaNCC.SelectedValue?.ToString() ?? "";
                row["MaNV"] = txtMaNV.Text.Trim();
                row["NgayNhap"] = dtNgayNhap.Value;
                row["TongTien"] = decimal.Parse(txtTongTien.Text);

                XmlDataService.SaveTable(_dtPN, "Phieunhap.xml", "PhieuNhap");
                MessageBox.Show("Cập nhật phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvPhieuNhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string ma = txtMaPN.Text.Trim();
                DataRow? row = _dtPN.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaPN") == ma);
                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _dtPN.Rows.Remove(row);
                XmlDataService.SaveTable(_dtPN, "Phieunhap.xml", "PhieuNhap");
                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DataTable view = _dtPN.Copy();
            if (!view.Columns.Contains("TenNCC"))
                view.Columns.Add("TenNCC", typeof(string));

            var nccLookup = _dtNCC.AsEnumerable()
                .ToDictionary(r => r.Field<string>("MaNCC"), r => r.Field<string>("TenNCC"));

            foreach (DataRow row in view.Rows)
            {
                string ma = row["MaNCC"]?.ToString() ?? "";
                row["TenNCC"] = nccLookup.ContainsKey(ma) ? nccLookup[ma] : "";
            }

            DataView dv = view.DefaultView;
            dv.RowFilter = $"MaPN LIKE '%{search}%' OR MaNCC LIKE '%{search}%' OR TenNCC LIKE '%{search}%'";
            dgvPhieuNhap.DataSource = dv.ToTable();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                txtMaPN.Text = row.Cells["MaPN"].Value?.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["NgayNhap"].Value?.ToString(), out DateTime dt))
                    dtNgayNhap.Value = dt;
                string maNCC = row.Cells["MaNCC"].Value?.ToString() ?? "";
                cboMaNCC.SelectedValue = maNCC;
            }
        }

        private void dgvPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                string maPN = row.Cells["MaPN"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(maPN))
                {
                    frmChiTietPhieuNhap frmChiTiet = new frmChiTietPhieuNhap(maPN, _parent);
                    _parent.OpenChildForm(frmChiTiet);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaPN.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPN.Focus();
                return false;
            }
            if (!decimal.TryParse(txtTongTien.Text, out decimal tt) || tt < 0)
            {
                MessageBox.Show("Vui lòng nhập tổng tiền hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Focus();
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            txtMaPN.Clear();
            txtMaNV.Clear();
            txtTongTien.Clear();
            dtNgayNhap.Value = DateTime.Now;
            if (cboMaNCC.Items.Count > 0)
                cboMaNCC.SelectedIndex = 0;
        }

        private void frmQuanLyPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null)
            {
                string filter = txtTimKiem.Text.Trim().Replace("'", "''");
                DataView dv = _dtPN.DefaultView;
                dv.RowFilter = $"MaPN LIKE '%{filter}%' OR MaNCC LIKE '%{filter}%'";
                dgvPhieuNhap.DataSource = dv.ToTable();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null)
            {
                string filter = txtTimKiem.Text.Trim().Replace("'", "''");
                DataView dv = _dtPN.DefaultView;
                dv.RowFilter = $"MaPN LIKE '%{filter}%' OR MaNCC LIKE '%{filter}%'";
                dgvPhieuNhap.DataSource = dv.ToTable();
            }

        }

        private void btn_chuyendoi_Click(object sender, EventArgs e)
        {
            if (_dtPN == null || _dtPN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để chuyển đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files|*.html";
            sfd.FileName = "DanhSachPhieuNhap.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy HTML từ DataTable
                    string htmlContent = XmlDataService.ConvertDataTableToHtml(_dtPN, "Phieunhap.xslt", "PhieuNhap");

                    // Ghi file
                    File.WriteAllText(sfd.FileName, htmlContent, Encoding.UTF8);

                    MessageBox.Show("Chuyển đổi HTML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tùy chọn: Mở file ngay sau khi lưu
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private string GetDisplayName(string columnName)
        {
            var displayNames = new Dictionary<string, string>
            {
                { "MaPN", "Mã Phiếu Nhập" },
                { "MaNCC", "Mã NCC" },
                { "TenNCC", "Tên Nhà Cung Cấp" },
                { "MaNV", "Mã Nhân Viên" },
                { "NgayNhap", "Ngày Nhập" },
                { "TongTien", "Tổng Tiền" }
            };
            return displayNames.ContainsKey(columnName) ? displayNames[columnName] : columnName;
        }

        private string FormatCellValue(object? value, string columnName)
        {
            if (value == null || value == DBNull.Value)
                return "-";

            string strValue = value.ToString() ?? "";

            // Format ngày tháng
            if (columnName == "NgayNhap" && DateTime.TryParse(strValue, out DateTime dt))
            {
                return dt.ToString("dd/MM/yyyy HH:mm");
            }

            // Format tiền tệ
            if (columnName == "TongTien" && decimal.TryParse(strValue, out decimal money))
            {
                return money.ToString("N0") + " đ";
            }

            // Escape HTML để tránh XSS
            return EscapeHtml(strValue);
        }

        private string EscapeHtml(string? text)
        {
            if (string.IsNullOrEmpty(text))
                return "";

            return text
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&#39;");
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}