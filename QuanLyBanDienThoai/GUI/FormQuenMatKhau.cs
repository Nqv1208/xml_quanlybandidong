using System;
using System.Windows.Forms;
using QuanLyBanDienThoai.Service;
using QuanLyBanDienThoai.Models;

namespace QuanLyBanDienThoai.GUI
{
    public partial class FormQuenMatKhau : Form
    {
        private TaiKhoanService _taiKhoanService;
        private EmailService _emailService;
        private string _maOTP;
        private string _tenDangNhapCanCapNhat;

        public FormQuenMatKhau()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
            _emailService = new EmailService();

            // Cấu hình ẩn mật khẩu
            txtMatKhauMoi.UseSystemPasswordChar = true;

            // ĐÃ SỬA LỖI TÊN CONTROL: txtNhapLaiMatKhauMoi -> txtNhapLaiMatKhau
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;

            // MẶC ĐỊNH ẨN PANEL ĐẶT MẬT KHẨU MỚI
            pnlDatMatKhau.Visible = false;

            // Gán sự kiện (ĐÃ SỬA: Dùng btnXacNhan)
            btnGuiMa.Click += btnGuiMa_Click;
            btnXacNhan.Click += btnXacNhan_Click; // <<< ĐÃ CẬP NHẬT TÊN NÚT
            btnThoat.Click += btnThoat_Click;
        }

        // ==========================================================
        // 1. XỬ LÝ GỬI MÃ OTP (btnGuiMa_Click)
        // ==========================================================
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            string email = txtNhapEmail.Text.Trim(); // Dùng txtNhapEmail

            TaiKhoan taiKhoanTimThay = _taiKhoanService.LayTaiKhoanTheoEmail(email);

            if (taiKhoanTimThay == null)
            {
                MessageBox.Show("Email này chưa được đăng ký trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _tenDangNhapCanCapNhat = taiKhoanTimThay.TenDangNhap;

            Random rand = new Random();
            _maOTP = rand.Next(100000, 999999).ToString();

            string subject = "Mã OTP Đặt Lại Mật Khẩu";
            string body = $"Mã OTP của bạn là: {_maOTP}. Mã này có hiệu lực trong 5 phút.";

            if (_emailService.GuiMail(email, subject, body))
            {
                MessageBox.Show("Mã OTP đã được gửi đến email của bạn. Vui lòng kiểm tra hộp thư.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlDatMatKhau.Visible = true;
                txtNhapEmail.Enabled = false;
                btnGuiMa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lỗi khi gửi mã OTP. Vui lòng kiểm tra lại địa chỉ email hoặc cài đặt EmailService.", "Lỗi Gửi Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // 2. XỬ LÝ XÁC NHẬN MẬT KHẨU (btnXacNhan_Click)
        // ==========================================================
        private void btnXacNhan_Click(object sender, EventArgs e) // <<< ĐÃ CẬP NHẬT TÊN PHƯƠNG THỨC
        {
            string otpNhap = txtMaOTP.Text.Trim(); // Dùng txtMaOTP
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMK = txtNhapLaiMatKhau.Text; // Dùng txtNhapLaiMatKhau

            if (otpNhap != _maOTP)
            {
                MessageBox.Show("Mã OTP không chính xác. Vui lòng kiểm tra lại email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhauMoi != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu mới không khớp với mật khẩu xác nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_taiKhoanService.CapNhatMatKhau(_tenDangNhapCanCapNhat, matKhauMoi))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công! Vui lòng đăng nhập lại.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormDangNhap dangNhapForm = new FormDangNhap();
                dangNhapForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống khi cập nhật mật khẩu. Vui lòng thử lại.", "Lỗi Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // 3. XỬ LÝ THOÁT (btnThoat_Click)
        // ==========================================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }
    }
}