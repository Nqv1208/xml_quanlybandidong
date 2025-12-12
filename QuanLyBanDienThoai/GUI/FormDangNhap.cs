using System;
using System.Windows.Forms;
using QuanLyBanDienThoai.Service;
using QuanLyBanDienThoai.Model;
// Các Form khác (FormMain, FormDangKy, FormQuenMatKhau) nằm trong cùng Namespace GUI

namespace QuanLyBanDienThoai.GUI
{
    public partial class FormDangNhap : Form
    {
        // Khai báo Service để xử lý logic kiểm tra tài khoản
        private TaiKhoanService _taiKhoanService;

        public FormDangNhap()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();

            // Cài đặt thuộc tính PasswordChar để ẩn mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;

            // GÁN TẤT CẢ CÁC SỰ KIỆN (Để tránh lỗi thiếu phương thức)
            btnDangNhap.Click += btnDangNhap_Click;
            linkDangKy.LinkClicked += linkDangKy_LinkClicked;
            linkQuenMatKhau.LinkClicked += linkQuenMatKhau_LinkClicked;
            btnThoat.Click += btnThoat_Click;
        }

        // ==========================================================
        // PHƯƠNG THỨC XỬ LÝ ĐĂNG NHẬP
        // ==========================================================

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.", "Thiếu Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi Service để kiểm tra thông tin đăng nhập
            // Giả định TaiKhoanService có phương thức KiemTraDangNhap
            TaiKhoan taiKhoanHienTai = _taiKhoanService.KiemTraDangNhap(tenDangNhap, matKhau);

            if (taiKhoanHienTai != null)
            {
                // ĐĂNG NHẬP THÀNH CÔNG: Chuyển sang FormMain
                MessageBox.Show("Đăng nhập thành công! Chào mừng " + taiKhoanHienTai.HoTen, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở FormMain
                FormMain mainForm = new FormMain();

                // (Tùy chọn) Có thể truyền thông tin tài khoản đang đăng nhập qua FormMain
                // mainForm.LoggedInUser = taiKhoanHienTai;

                mainForm.Show();
                this.Hide(); // Ẩn Form Đăng nhập
            }
            else
            {
                // ĐĂNG NHẬP THẤT BẠI
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDangNhap.Focus();
            }
        }

        // ==========================================================
        // PHƯƠNG THỨC XỬ LÝ ĐIỀU HƯỚNG
        // ==========================================================

        // Chuyển sang Form Đăng ký
        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy dangKyForm = new FormDangKy();
            dangKyForm.Show();
            this.Hide();
        }

        // Chuyển sang Form Quên Mật Khẩu
        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // FormQuenMatKhau tồn tại theo cấu trúc dự án
            FormQuenMatKhau quenMatKhauForm = new FormQuenMatKhau();
            quenMatKhauForm.Show();
            this.Hide();
        }

        // Xử lý nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}