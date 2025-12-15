using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Guna.UI2.WinForms;
using QuanLyBanDienThoai.DAL; // Đảm bảo bạn đã có namespace này từ project cũ

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmQuanLyKhachHang : Form
    {
        // DataTable để lưu trữ dữ liệu khách hàng
        private DataTable _dtKhachHang = new DataTable();

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            LoadDataXml();
        }

        // Hàm load dữ liệu từ file XML lên DataGridView
        private void LoadDataXml()
        {
            try
            {
                // Load bảng "KhachHang" từ file "Khachhang.xml"
                // Lưu ý: Bạn cần đảm bảo file Khachhang.xml đã tồn tại với cấu trúc cột tương ứng
                _dtKhachHang = XmlDataService.LoadTable("Khachhang.xml", "KhachHang");

                dgvKhachHang.DataSource = _dtKhachHang.Copy();
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Đặt tên tiêu đề tiếng Việt cho các cột
                if (dgvKhachHang.Columns.Contains("MaKH")) dgvKhachHang.Columns["MaKH"].HeaderText = "Mã KH";
                if (dgvKhachHang.Columns.Contains("TenKH")) dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                if (dgvKhachHang.Columns.Contains("SoDienThoai")) dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- XỬ LÝ SỰ KIỆN CÁC NÚT BẤM ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra trùng mã khách hàng
            if (_dtKhachHang.AsEnumerable().Any(r => r.Field<string>("MaKH") == txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Thêm dòng mới vào DataTable
                DataRow row = _dtKhachHang.NewRow();
                row["MaKH"] = txtMaKH.Text.Trim();
                row["TenKH"] = txtTenKH.Text.Trim();
                row["SoDienThoai"] = txtSoDienThoai.Text.Trim();
                _dtKhachHang.Rows.Add(row);

                // 4. Lưu xuống file XML
                XmlDataService.SaveTable(_dtKhachHang, "Khachhang.xml", "KhachHang");

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml(); // Refresh lại lưới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tìm dòng dữ liệu cần sửa theo Mã KH (Mã KH thường không cho sửa, chỉ sửa thông tin khác)
                string ma = txtMaKH.Text.Trim();
                DataRow row = _dtKhachHang.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaKH") == ma);

                if (row == null)
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng trong dữ liệu gốc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật giá trị mới
                row["TenKH"] = txtTenKH.Text.Trim();
                row["SoDienThoai"] = txtSoDienThoai.Text.Trim();

                // Lưu lại
                XmlDataService.SaveTable(_dtKhachHang, "Khachhang.xml", "KhachHang");

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadDataXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string ma = txtMaKH.Text.Trim();
                    DataRow row = _dtKhachHang.AsEnumerable().FirstOrDefault(r => r.Field<string>("MaKH") == ma);

                    if (row != null)
                    {
                        _dtKhachHang.Rows.Remove(row); // Xóa khỏi DataTable
                        XmlDataService.SaveTable(_dtKhachHang, "Khachhang.xml", "KhachHang"); // Lưu thay đổi

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadDataXml();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadDataXml(); // Load lại dữ liệu gốc (bỏ lọc tìm kiếm nếu có)
        }

        // --- SỰ KIỆN GRIDVIEW ---

        // Khi click vào dòng trong bảng -> Đổ dữ liệu lên các ô textbox
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
            }
        }

        // Hàm xóa trắng các ô nhập liệu
        private void ClearFields()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSoDienThoai.Clear();
            txtMaKH.Focus();
        }

        // --- CHỨC NĂNG TÌM KIẾM ---

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
                LoadDataXml(); // Nếu ô tìm kiếm trống -> Hiện tất cả
                return;
            }

            try
            {
                string filter = txtTimKiem.Text.Trim().Replace("'", "''"); // Tránh lỗi cú pháp Filter
                DataView dv = _dtKhachHang.DefaultView;

                // Lọc theo Mã, Tên hoặc SĐT
                dv.RowFilter = $"MaKH LIKE '%{filter}%' OR TenKH LIKE '%{filter}%' OR SoDienThoai LIKE '%{filter}%'";

                dgvKhachHang.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi lọc nếu cú pháp sai tạm thời khi gõ
                Console.WriteLine(ex.Message);
            }
        }

        // --- CHỨC NĂNG XUẤT HTML ---

        private void btn_chuyendoi_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "HTML Files|*.html";
            sfd.FileName = "DanhSachKhachHang.html";
            sfd.Title = "Xuất danh sách khách hàng";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy dữ liệu hiện tại trên Grid (bao gồm cả kết quả đang tìm kiếm)
                    DataTable dtToExport = (DataTable)dgvKhachHang.DataSource;
                    string htmlContent = XmlDataService.ConvertDataTableToHtml(dtToExport, "Khachhang.xslt", "KhachHang");

                    File.WriteAllText(sfd.FileName, htmlContent, Encoding.UTF8);

                    MessageBox.Show("Xuất file HTML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tự động mở file sau khi xuất
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}