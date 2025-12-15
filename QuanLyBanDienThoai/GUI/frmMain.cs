using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using QuanLyBanDienThoai.Model; // Đừng quên dòng này để dùng class TaiKhoan

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmMain : Form
    {
        private Form? currentForm = null;
        private Dictionary<Guna2Button, Image> _originalImages = new Dictionary<Guna2Button, Image>();

        // Biến lưu thông tin tài khoản đang đăng nhập
        private TaiKhoan _taiKhoanHienTai;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // --- SỬA CONSTRUCTOR ĐỂ NHẬN THAM SỐ TAIKHOAN ---
        public frmMain(TaiKhoan tk)
        {
            InitializeComponent();
            _taiKhoanHienTai = tk; // Lưu thông tin tài khoản được truyền sang

            label_header.Text = "Tổng quan";
            img_header.Image = Properties.Resources.layout_dashboard_2;
            ResetSidebarButtons();

            // Mặc định mở Dashboard
            btnSideBarOnClick(btnDashboard);
            OpenChildForm(new DashBoard()); // Lưu ý: Đảm bảo tên class là Dashboard (chữ b thường)

            // --- GỌI HÀM PHÂN QUYỀN & HIỂN THỊ ---
            PhanQuyen();
            HienThiThongTin();
        }

        // Hàm xử lý phân quyền
        private void PhanQuyen()
        {
            // Kiểm tra nếu tài khoản tồn tại và Quyền là "NhanVien"
            // (Chữ "NhanVien" phải khớp y hệt trong file XML của bạn)
            if (_taiKhoanHienTai != null && _taiKhoanHienTai.Quyen == "NhanVien")
            {
                // 1. Ẩn nút Quản lý Tài khoản (Nhân viên không được cấp tài khoản cho người khác)
                if (btnAccount != null) btnAccount.Visible = false;

                // 2. Ẩn nút Quản lý Nhân viên (Tùy chọn: Nhân viên thường không quản lý nhân sự)
                if (btnStaff != null) btnStaff.Visible = false;

                // 3. Ẩn nút Thống kê/Dashboard nếu cần (Tùy logic của bạn)
                // if (btnDashboard != null) btnDashboard.Enabled = false;
            }
        }

        // Hàm hiển thị tên và quyền lên thanh Sidebar
        private void HienThiThongTin()
        {
            if (_taiKhoanHienTai != null)
            {
                // Gán họ tên vào Label Name (Góc dưới trái sidebar)
                if (label_name != null) label_name.Text = _taiKhoanHienTai.HoTen;

                // Gán quyền vào Label Role
                if (label_role != null) label_role.Text = _taiKhoanHienTai.Quyen;
            }
        }

        // --- CÁC HÀM CŨ GIỮ NGUYÊN BÊN DƯỚI ---

        private void frmMain_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            img_header.Image = Properties.Resources.layout_dashboard_2;
            SaveOriginalButtonStates();
        }

        private void SaveOriginalButtonStates()
        {
            foreach (Control c in guna2Panel_sidebar.Controls)
            {
                if (c is Guna2Button btn)
                {
                    if (btn.Image != null)
                    {
                        _originalImages[btn] = btn.Image;
                    }
                }
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (guna2Panel_Container.Controls.Count > 0)
            {
                guna2Panel_Container.Controls.Clear();
            }
            Form fm = childForm as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill; // Thêm dòng này để form con lấp đầy container
            guna2Panel_Container.Controls.Add(fm);
            guna2Panel_Container.Tag = fm;
            fm.Show();
        }

        // --- CÁC SỰ KIỆN CLICK ---

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            label_header.Text = "Tổng quan";
            img_header.Image = Properties.Resources.layout_dashboard_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnDashboard);
            OpenChildForm(new DashBoard());
        }

        private void btn_hangsanxuat_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Hãng Sản Xuất";
            img_header.Image = Properties.Resources.manufacture_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btn_hangsanxuat);
            OpenChildForm(new frmQuanLyHangSanXuat());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Sản Phẩm";
            img_header.Image = Properties.Resources.package_open_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnProduct);
            OpenChildForm(new frmQuanLySanPham());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Khách Hàng";
            img_header.Image = Properties.Resources.users_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnCustomer);
            OpenChildForm(new frmQuanLyKhachHang());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Hóa Đơn";
            img_header.Image = Properties.Resources.clipboard_list_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnBill);
            OpenChildForm(new frmQuanLyHoaDon(this));
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Phiếu Nhập";
            img_header.Image = Properties.Resources.file_bar_chart_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnPhieuNhap);
            OpenChildForm(new frmQuanLyPhieuNhap(this));
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Nhân Viên";
            img_header.Image = Properties.Resources.users_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnStaff);
            OpenChildForm(new frmQuanLyNhanVien());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Tài Khoản";
            img_header.Image = Properties.Resources.users_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnAccount);
            OpenChildForm(new frmQuanLyTaiKhoan());
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Nhà Cung Cấp";
            img_header.Image = Properties.Resources.store_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnProvider);
            OpenChildForm(new frmQuanLyNhaCungCap());
        }

        private void btnSideBarOnClick(Guna2Button btn)
        {
            btn.FillColor = btn.HoverState.FillColor;
            btn.ForeColor = btn.HoverState.ForeColor;
            btn.Image = btn.HoverState.Image;
            btn.BorderColor = btn.HoverState.BorderColor;
        }

        private void ResetSidebarButtons()
        {
            foreach (Control c in guna2Panel_sidebar.Controls)
            {
                if (c is Guna2Button b)
                {
                    b.FillColor = Color.Transparent;
                    b.ForeColor = Color.Black;
                    b.BorderColor = Color.Transparent;
                    if (_originalImages.ContainsKey(b))
                    {
                        b.Image = _originalImages[b];
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap loginForm = new FormDangNhap();
            loginForm.ShowDialog();
            this.Close();
        }

        private void guna2Panel_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }
    }
}