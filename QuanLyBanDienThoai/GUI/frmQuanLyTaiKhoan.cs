using System.Data;
using System.Text;
using Guna.UI2.WinForms;
using QuanLyBanDienThoai.Data;

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
                    string htmlContent = ConvertDataTableToHtml(dtToExport);
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

        private string ConvertDataTableToHtml(DataTable dt)
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html lang='vi'>");
            html.AppendLine("<head>");
            html.AppendLine("    <meta charset='utf-8'>");
            html.AppendLine("    <meta name='viewport' content='width=device-width, initial-scale=1.0'>");
            html.AppendLine("    <title>Danh Sách Tài Khoản</title>");
            html.AppendLine("    <style>");
            html.AppendLine("        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 0; padding: 20px; background-color: #f4f7f6; color: #333; }");
            html.AppendLine("        .container { max-width: 1200px; margin: 20px auto; background-color: #ffffff; padding: 30px; border-radius: 12px; box-shadow: 0 6px 20px rgba(0, 0, 0, 0.08); }");
            html.AppendLine("        .header { text-align: center; margin-bottom: 30px; padding-bottom: 20px; border-bottom: 2px solid #e0e0e0; }");
            html.AppendLine("        .header h1 { color: #4a148c; font-size: 2.5em; margin-bottom: 10px; text-shadow: 1px 1px 2px rgba(0,0,0,0.1); }");
            html.AppendLine("        .header p { color: #757575; font-size: 0.9em; }");
            html.AppendLine("        .table-wrapper { overflow-x: auto; border-radius: 10px; border: 1px solid #e0e0e0; box-shadow: 0 2px 8px rgba(0, 0, 0, 0.05); }");
            html.AppendLine("        table { width: 100%; border-collapse: collapse; margin: 0; background-color: #ffffff; }");
            html.AppendLine("        th, td { padding: 14px 18px; text-align: left; border-bottom: 1px solid #eeeeee; }");
            html.AppendLine("        th { background: linear-gradient(135deg, #673ab7 0%, #5e35b1 100%); color: white; font-weight: 600; text-transform: uppercase; font-size: 0.9em; }");
            html.AppendLine("        tr:nth-child(even) { background-color: #f9f9f9; }");
            html.AppendLine("        tr:hover { background-color: #e8eaf6; transform: translateY(-2px); box-shadow: 0 4px 12px rgba(0,0,0,0.08); transition: all 0.3s ease; }");
            html.AppendLine("        td { font-size: 0.9em; color: #424242; }");
            html.AppendLine("        td:first-child { font-weight: 600; color: #673ab7; }");
            html.AppendLine("        .footer { text-align: center; margin-top: 30px; padding-top: 20px; border-top: 1px solid #e0e0e0; font-size: 0.8em; color: #9e9e9e; }");
            html.AppendLine("        .footer strong { color: #616161; }");
            html.AppendLine("        @media (max-width: 768px) {");
            html.AppendLine("            body { padding: 10px; }");
            html.AppendLine("            .container { padding: 15px; }");
            html.AppendLine("            th, td { padding: 10px 12px; }");
            html.AppendLine("            .header h1 { font-size: 1.8em; }");
            html.AppendLine("        }");
            html.AppendLine("        @media print {");
            html.AppendLine("            body { background-color: #fff; }");
            html.AppendLine("            .container { box-shadow: none; border: 1px solid #ccc; }");
            html.AppendLine("            .header, .footer { border-color: #ccc; }");
            html.AppendLine("            .table-wrapper { border: none; box-shadow: none; }");
            html.AppendLine("            th { background: #e0e0e0 !important; color: #333 !important; -webkit-print-color-adjust: exact; print-color-adjust: exact; }");
            html.AppendLine("            tr:hover { background-color: #f9f9f9 !important; transform: none; box-shadow: none; }");
            html.AppendLine("        }");
            html.AppendLine("    </style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");

            html.AppendLine("<div class='container'>");
            html.AppendLine("<div class='header'>");
            html.AppendLine("<h1>🔐 DANH SÁCH TÀI KHOẢN</h1>");
            html.AppendLine($"<p>Xuất ngày: {DateTime.Now:dd/MM/yyyy HH:mm:ss} | Tổng số: {dt.Rows.Count} tài khoản</p>");
            html.AppendLine("</div>");

            html.AppendLine("<div class='content'>");
            html.AppendLine("<div class='table-wrapper'>");
            html.AppendLine("<table>");

            html.AppendLine("<thead><tr>");
            foreach (DataColumn column in dt.Columns)
            {
                string displayName = GetDisplayName(column.ColumnName);
                html.AppendLine($"<th>{displayName}</th>");
            }
            html.AppendLine("</tr></thead>");

            html.AppendLine("<tbody>");
            foreach (DataRow row in dt.Rows)
            {
                html.AppendLine("<tr>");
                foreach (var item in row.ItemArray)
                {
                    string formattedValue = FormatCellValue(item);
                    html.AppendLine($"<td>{formattedValue}</td>");
                }
                html.AppendLine("</tr>");
            }
            html.AppendLine("</tbody>");
            html.AppendLine("</table>");
            html.AppendLine("</div>");
            html.AppendLine("</div>");

            html.AppendLine("<div class='footer'>");
            html.AppendLine($"<p>Hệ thống quản lý bán điện thoại | <strong>Xuất báo cáo</strong> | {DateTime.Now:dd/MM/yyyy HH:mm:ss}</p>");
            html.AppendLine("</div>");

            html.AppendLine("</div>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }

        private string GetDisplayName(string columnName)
        {
            var displayNames = new Dictionary<string, string>
            {
                { "MaTK", "Mã TK" },
                { "TenDangNhap", "Tên Đăng Nhập" },
                { "MatKhau", "Mật Khẩu" },
                { "Quyen", "Quyền" },
                { "MaNV", "Mã NV" }
            };
            return displayNames.ContainsKey(columnName) ? displayNames[columnName] : columnName;
        }

        private string FormatCellValue(object? value)
        {
            if (value == null || value == DBNull.Value)
                return "-";

            string strValue = value.ToString() ?? "";
            return strValue
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&#39;");
        }
    }
}

