using System;
using System.Windows.Forms;
using QuanLyBanDienThoai.Model;
using QuanLyBanDienThoai.Service;
// Đảm bảo FormDangNhap nằm trong cùng Namespace nên không cần using nếu FormDangNhap cũng là QuanLyBanDienThoai.GUI

namespace QuanLyBanDienThoai.GUI
{
    public partial class FormDangKy : Form
    {
        private TaiKhoanService _taiKhoanService;

        public FormDangKy()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();

            // Cài đặt thuộc tính PasswordChar để ẩn mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;

            // GÁN CÁC SỰ KIỆN CẦN THIẾT
            btnDangKy.Click += btnDangKy_Click;
            linkDangNhap.LinkClicked += linkDangNhap_LinkClicked;
            btnThoat.Click += btnThoat_Click; // Nếu bạn có nút Thoát
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string matKhauXN = txtNhapLaiMatKhau.Text;

            // 2. Tạo đối tượng Model (TaiKhoan)
            TaiKhoan taiKhoanMoi = new TaiKhoan
            {
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                HoTen = hoTen,
                Email = email,
                Quyen = "NhanVien",
                MaNV = "ChuaGan"
            };
            // 1. Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(matKhauXN) || string.IsNullOrEmpty(hoTen))

            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != matKhauXN)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtNhapLaiMatKhau.Clear();
                return;
            }


            // 3. Gọi Service để thêm tài khoản vào XML
            if (_taiKhoanService.ThemTaiKhoan(taiKhoanMoi))
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang Form Đăng nhập
                FormDangNhap dangNhapForm = new FormDangNhap();
                dangNhapForm.Show();
              
            }
            else
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại hoặc xảy ra lỗi khi lưu dữ liệu.", "Lỗi Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Tạo instance Form Đăng nhập
            FormDangNhap dangNhapForm = new FormDangNhap();

            // 2. Hiển thị Form Đăng nhập
            dangNhapForm.Show();

          
        }
        // Phương thức xử lý sự kiện khi nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Thoát toàn bộ ứng dụng
        }
    }
}