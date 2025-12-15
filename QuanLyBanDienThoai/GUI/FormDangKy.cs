using System;
using System.Windows.Forms;
using QuanLyBanDienThoai.Models;
using QuanLyBanDienThoai.Service;

namespace QuanLyBanDienThoai.GUI
{
    public partial class FormDangKy : Form
    {
        private TaiKhoanService _taiKhoanService;

        public FormDangKy()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();

            // Ẩn mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string matKhauXN = txtNhapLaiMatKhau.Text;

            // 1. Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(matKhauXN) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != matKhauXN)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtNhapLaiMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            // 2. Tạo đối tượng Model
            // Lưu ý: Không cần gán MaTK ở đây vì Service sẽ tự sinh mã TK00x
            TaiKhoan taiKhoanMoi = new TaiKhoan
            {
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                HoTen = hoTen,
                Email = email,
                Quyen = "NhanVien", // Mặc định quyền
                MaNV = "ChuaGan"    // Mặc định chưa gán mã nhân viên
            };

            // 3. Gọi Service
            bool ketQua = _taiKhoanService.ThemTaiKhoan(taiKhoanMoi);

            if (ketQua)
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang form đăng nhập và đóng form đăng ký
                this.Hide();
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại hoặc lỗi hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormDangNhap loginForm = new FormDangNhap();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}