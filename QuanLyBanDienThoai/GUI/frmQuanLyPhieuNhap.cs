using QuanLyBanDienThoai.Data;
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
                    frmChiTietPhieuNhap frmChiTiet = new frmChiTietPhieuNhap(maPN);
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
                    string htmlContent = ConvertDataTableToHtml(_dtPN);

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

        private string ConvertDataTableToHtml(DataTable dt)
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html lang='vi'>");
            html.AppendLine("<head>");
            html.AppendLine("<meta charset='utf-8'>");
            html.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1.0'>");
            html.AppendLine("<title>Danh Sách Phiếu Nhập</title>");
            html.AppendLine("<style>");
            html.AppendLine("* { margin: 0; padding: 0; box-sizing: border-box; }");
            html.AppendLine("body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); padding: 20px; min-height: 100vh; }");
            html.AppendLine(".container { max-width: 1400px; margin: 0 auto; background: white; border-radius: 15px; box-shadow: 0 20px 60px rgba(0,0,0,0.3); overflow: hidden; }");
            html.AppendLine(".header { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; padding: 30px; text-align: center; }");
            html.AppendLine(".header h1 { font-size: 32px; font-weight: 700; margin-bottom: 10px; text-shadow: 2px 2px 4px rgba(0,0,0,0.2); }");
            html.AppendLine(".header p { font-size: 14px; opacity: 0.9; }");
            html.AppendLine(".content { padding: 30px; }");
            html.AppendLine(".table-wrapper { overflow-x: auto; border-radius: 10px; box-shadow: 0 4px 15px rgba(0,0,0,0.1); }");
            html.AppendLine("table { width: 100%; border-collapse: separate; border-spacing: 0; background: white; }");
            html.AppendLine("thead { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); }");
            html.AppendLine("th { color: white; font-weight: 600; padding: 18px 15px; text-align: left; font-size: 14px; text-transform: uppercase; letter-spacing: 0.5px; border: none; }");
            html.AppendLine("th:first-child { border-top-left-radius: 10px; }");
            html.AppendLine("th:last-child { border-top-right-radius: 10px; }");
            html.AppendLine("tbody tr { transition: all 0.3s ease; border-bottom: 1px solid #e0e0e0; }");
            html.AppendLine("tbody tr:hover { background-color: #f5f7ff; transform: scale(1.01); box-shadow: 0 2px 8px rgba(102, 126, 234, 0.2); }");
            html.AppendLine("tbody tr:nth-child(even) { background-color: #fafbff; }");
            html.AppendLine("tbody tr:nth-child(even):hover { background-color: #f0f2ff; }");
            html.AppendLine("td { padding: 15px; color: #333; font-size: 14px; border: none; }");
            html.AppendLine("td:first-child { font-weight: 600; color: #667eea; }");
            html.AppendLine(".footer { background: #f8f9fa; padding: 20px 30px; text-align: center; color: #666; font-size: 12px; border-top: 1px solid #e0e0e0; }");
            html.AppendLine(".footer strong { color: #667eea; }");
            html.AppendLine("@media print { body { background: white; padding: 0; } .container { box-shadow: none; } }");
            html.AppendLine("@media (max-width: 768px) { .header h1 { font-size: 24px; } th, td { padding: 10px 8px; font-size: 12px; } }");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");

            html.AppendLine("<div class='container'>");
            html.AppendLine("<div class='header'>");
            html.AppendLine("<h1>📋 DANH SÁCH PHIẾU NHẬP</h1>");
            html.AppendLine($"<p>Xuất ngày: {DateTime.Now:dd/MM/yyyy HH:mm:ss} | Tổng số: {dt.Rows.Count} phiếu nhập</p>");
            html.AppendLine("</div>");

            html.AppendLine("<div class='content'>");
            html.AppendLine("<div class='table-wrapper'>");
            html.AppendLine("<table>");

            // Tạo tiêu đề bảng (Header)
            html.AppendLine("<thead><tr>");
            foreach (DataColumn column in dt.Columns)
            {
                string displayName = GetDisplayName(column.ColumnName);
                html.AppendLine($"<th>{displayName}</th>");
            }
            html.AppendLine("</tr></thead>");

            // Tạo nội dung bảng (Body)
            html.AppendLine("<tbody>");
            foreach (DataRow row in dt.Rows)
            {
                html.AppendLine("<tr>");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string columnName = dt.Columns[i].ColumnName;
                    object? cellValue = row[i];
                    string formattedValue = FormatCellValue(cellValue, columnName);
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

    }
}