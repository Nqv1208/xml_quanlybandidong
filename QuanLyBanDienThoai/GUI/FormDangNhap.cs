using System;
using System.Windows.Forms;
using QuanLyBanDienThoai.Service;
using QuanLyBanDienThoai.Models;

namespace QuanLyBanDienThoai.GUI
{
    public partial class FormDangNhap : Form
    {
        private TaiKhoanService _taiKhoanService;

        public FormDangNhap()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();

            // Đảm bảo mật khẩu được ẩn bằng ký tự chấm tròn
            txtMatKhau.UseSystemPasswordChar = true;

            // Gán các sự kiện
            // Lưu ý: Nếu trong Designer đã gán sự kiện rồi thì các dòng += này có thể bỏ qua để tránh gán 2 lần
            // Nhưng để chắc chắn, bạn cứ giữ nguyên cũng không sao.
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            // 1. Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.", "Thiếu Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gọi Service kiểm tra đăng nhập
            TaiKhoan taiKhoanHienTai = _taiKhoanService.KiemTraDangNhap(tenDangNhap, matKhau);

            if (taiKhoanHienTai != null)
            {
                // Thông báo thành công -> Chờ người dùng nhấn OK
                MessageBox.Show("Đăng nhập thành công! Chào mừng " + taiKhoanHienTai.HoTen, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- QUAN TRỌNG: LOGIC MỞ FORM CHÍNH ---

                // B1: Ẩn Form Đăng Nhập đi (không đóng ngay, vì đóng sẽ tắt app)
                this.Hide();

                try
                {
                    // B2: Khởi tạo và mở Form Main
                    frmMain mainForm = new frmMain(taiKhoanHienTai);
                   

                    // Dùng ShowDialog() để "treo" code ở đây, giữ cho ứng dụng chạy
                    // cho đến khi bạn tắt Form Main đi.
                    mainForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở Form Chính: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Nếu lỗi thì hiện lại form đăng nhập
                    this.Show();
                }
                finally
                {
                    // B3: Khi Form Main bị đóng (người dùng tắt app), 
                    // dòng này mới chạy để đóng hoàn toàn ứng dụng sạch sẽ.
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chuyển sang form Đăng Ký
            FormDangKy dangKyForm = new FormDangKy();
            this.Hide();
            dangKyForm.ShowDialog(); // Dùng ShowDialog để khi tắt form Đăng ký thì quay lại đây được
            this.Show(); // Hiện lại form đăng nhập khi form đăng ký đóng
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chuyển sang form Quên Mật Khẩu
            FormQuenMatKhau quenMatKhauForm = new FormQuenMatKhau();
            this.Hide();
            quenMatKhauForm.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- Các hàm sự kiện rỗng (Giữ lại để tránh lỗi Designer nếu có liên kết) ---
        private void FormDangNhap_Load(object sender, EventArgs e) { }
        private void FormDangNhap_Load_1(object sender, EventArgs e) { }
        private void txtMatKhau_TextChanged(object sender, EventArgs e) { }
        private void pnlRight_Paint(object sender, PaintEventArgs e) { }
        private void picLogo_Click(object sender, EventArgs e) { }
        private void pnlLeft_Paint(object sender, PaintEventArgs e) { }

        private void linkQuenMatKhau_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau quenmatkhauForm = new FormQuenMatKhau();
            this.Hide();
            quenmatkhauForm.ShowDialog(); // Dùng ShowDialog để khi tắt form Đăng ký thì quay lại đây được
            this.Show();
        }
    }
}