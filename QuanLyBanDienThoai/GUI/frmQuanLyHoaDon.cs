using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanDienThoai.Data;

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
                frmChiTietHoaDon frm = new frmChiTietHoaDon(maHD);
                frm.ShowDialog();
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
                    string htmlContent = ConvertDataTableToHtml(_dtHd);

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
        private string ConvertDataTableToHtml(DataTable dt)
        {
            StringBuilder html = new StringBuilder();

            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html lang='vi'>");
            html.AppendLine("<head>");
            html.AppendLine("<meta charset='utf-8'>");
            html.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1.0'>");
            html.AppendLine("<title>Danh Sách Hóa Đơn</title>");
            html.AppendLine("<style>");
            html.AppendLine("* { margin: 0; padding: 0; box-sizing: border-box; }");
            html.AppendLine("body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; background: linear-gradient(135deg, #ff9a9e 0%, #fad0c4 100%); padding: 20px; min-height: 100vh; }");
            html.AppendLine(".container { max-width: 1400px; margin: 0 auto; background: white; border-radius: 15px; box-shadow: 0 20px 60px rgba(0,0,0,0.3); overflow: hidden; }");
            html.AppendLine(".header { background: linear-gradient(135deg, #ff758c 0%, #ff7eb3 100%); color: white; padding: 30px; text-align: center; }");
            html.AppendLine(".header h1 { font-size: 32px; font-weight: 700; margin-bottom: 10px; text-shadow: 2px 2px 4px rgba(0,0,0,0.2); }");
            html.AppendLine(".header p { font-size: 14px; opacity: 0.9; }");
            html.AppendLine(".content { padding: 30px; }");
            html.AppendLine(".table-wrapper { overflow-x: auto; border-radius: 10px; box-shadow: 0 4px 15px rgba(0,0,0,0.1); }");
            html.AppendLine("table { width: 100%; border-collapse: separate; border-spacing: 0; background: white; }");
            html.AppendLine("thead { background: linear-gradient(135deg, #ff758c 0%, #ff7eb3 100%); }");
            html.AppendLine("th { color: white; font-weight: 600; padding: 18px 15px; text-align: left; font-size: 14px; letter-spacing: 0.5px; border: none; }");
            html.AppendLine("tbody tr:hover { background-color: #fff0f5; transform: scale(1.01); transition: 0.2s; }");
            html.AppendLine("td { padding: 14px; font-size: 14px; border-bottom: 1px solid #eee; }");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");

            html.AppendLine("<div class='container'>");
            html.AppendLine("<div class='header'>");
            html.AppendLine("<h1>📑 DANH SÁCH HÓA ĐƠN</h1>");
            html.AppendLine($"<p>Xuất lúc: {DateTime.Now:dd/MM/yyyy HH:mm:ss} — Tổng: {dt.Rows.Count} hóa đơn</p>");
            html.AppendLine("</div>");

            html.AppendLine("<div class='content'>");
            html.AppendLine("<div class='table-wrapper'>");
            html.AppendLine("<table>");

            // HEADER
            html.AppendLine("<thead><tr>");
            foreach (DataColumn col in dt.Columns)
                html.AppendLine($"<th>{GetDisplayName(col.ColumnName)}</th>");
            html.AppendLine("</tr></thead>");

            // BODY
            html.AppendLine("<tbody>");
            foreach (DataRow row in dt.Rows)
            {
                html.AppendLine("<tr>");
                foreach (DataColumn col in dt.Columns)
                {
                    string v = FormatCellValue(row[col], col.ColumnName);
                    html.AppendLine($"<td>{v}</td>");
                }
                html.AppendLine("</tr>");
            }
            html.AppendLine("</tbody>");

            html.AppendLine("</table>");
            html.AppendLine("</div>");
            html.AppendLine("</div>");

            html.AppendLine("</div>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }
        private string FormatCellValue(object value, string columnName)
        {
            if (value == null || value == DBNull.Value)
                return "-";

            string strValue = value.ToString() ?? "";

            // Format ngày lập
            if (columnName == "NgayLap" && DateTime.TryParse(strValue, out DateTime dt))
            {
                return dt.ToString("dd/MM/yyyy HH:mm");
            }

            // Format tiền tệ
            if (columnName == "TongTien" && decimal.TryParse(strValue, out decimal money))
            {
                return money.ToString("N0") + " đ";
            }

            // Các cột khác: escape HTML để an toàn
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
