using System.Data;
using System.Text;
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

        private void btn_chuyendoi_Click(object sender, EventArgs e)
        {
            if (_dtHang == null || _dtHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để chuyển đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files|*.html";
            sfd.FileName = "DanhSachHangSanXuat.html";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy dữ liệu từ DataGridView (có thể đã được lọc)
                    DataTable dtToExport = (DataTable)dgvHangSanXuat.DataSource ?? _dtHang.Copy();
                    
                    // Lấy HTML từ DataTable
                    string htmlContent = ConvertDataTableToHtml(dtToExport);

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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Tìm kiếm real-time khi người dùng gõ
            PerformSearch();
        }

        private void PerformSearch()
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                // Nếu ô tìm kiếm trống, hiển thị lại toàn bộ dữ liệu
                LoadDataXml();
                return;
            }

            try
            {
                string filter = txtTimKiem.Text.Trim().Replace("'", "''");
                DataView dv = _dtHang.DefaultView;
                dv.RowFilter = $"MaHang LIKE '%{filter}%' OR TenHang LIKE '%{filter}%'";
                
                DataTable filtered = dv.ToTable();
                dgvHangSanXuat.DataSource = filtered;
                dgvHangSanXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            html.AppendLine("    <title>Danh Sách Hãng Sản Xuất</title>");
            html.AppendLine("    <style>");
            html.AppendLine("        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 0; padding: 20px; background-color: #f4f7f6; color: #333; }");
            html.AppendLine("        .container { max-width: 1200px; margin: 20px auto; background-color: #ffffff; padding: 30px; border-radius: 12px; box-shadow: 0 6px 20px rgba(0, 0, 0, 0.08); }");
            html.AppendLine("        .header { text-align: center; margin-bottom: 30px; padding-bottom: 20px; border-bottom: 2px solid #e0e0e0; }");
            html.AppendLine("        .header h1 { color: #4a148c; font-size: 2.5em; margin-bottom: 10px; text-shadow: 1px 1px 2px rgba(0,0,0,0.1); }");
            html.AppendLine("        .header p { color: #757575; font-size: 0.9em; }");
            html.AppendLine("        .table-wrapper { overflow-x: auto; border-radius: 10px; border: 1px solid #e0e0e0; box-shadow: 0 2px 8px rgba(0, 0, 0, 0.05); }");
            html.AppendLine("        table { width: 100%; border-collapse: collapse; margin: 0; background-color: #ffffff; }");
            html.AppendLine("        th, td { padding: 14px 18px; text-align: left; border-bottom: 1px solid #eeeeee; }");
            html.AppendLine("        th { background: linear-gradient(135deg, #673ab7 0%, #5e35b1 100%); color: white; font-weight: 600; text-transform: uppercase; font-size: 0.9em; cursor: pointer; position: sticky; top: 0; }");
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
            html.AppendLine("<h1>🏭 DANH SÁCH HÃNG SẢN XUẤT</h1>");
            html.AppendLine($"<p>Xuất ngày: {DateTime.Now:dd/MM/yyyy HH:mm:ss} | Tổng số: {dt.Rows.Count} hãng sản xuất</p>");
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
                { "MaHang", "Mã Hãng" },
                { "TenHang", "Tên Hãng" }
            };
            return displayNames.ContainsKey(columnName) ? displayNames[columnName] : columnName;
        }

        private string FormatCellValue(object? value)
        {
            if (value == null || value == DBNull.Value)
                return "-";

            string strValue = value.ToString() ?? "";
            
            // Escape HTML special characters
            return strValue
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&#39;");
        }
    }
}