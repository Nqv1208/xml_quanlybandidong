using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using QuanLyBanDienThoai.Models;
using QuanLyBanDienThoai.DAL;
using System.Data;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmMain : Form
    {
        private Form? currentForm = null;
        private Dictionary<Guna2Button, Image> _originalImages = new Dictionary<Guna2Button, Image>();

        // Biến lưu thông tin tài khoản đang đăng nhập
        private TaiKhoan _taiKhoanHienTai;
        private NhanVien _nhanVienHienTai;
        private string name = "";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // --- SỬA CONSTRUCTOR ĐỂ NHẬN THAM SỐ TAIKHOAN ---
        public frmMain(TaiKhoan tk)
        {
            InitializeComponent();
            _taiKhoanHienTai = tk; // Lưu thông tin tài khoản được truyền sang

            // Load thông tin nhân viên từ XML
            LoadNhanVien();

            label_header.Text = "Tổng quan";
            img_header.Image = Properties.Resources.layout_dashboard_2;
            ResetSidebarButtons();

            // Mặc định mở Dashboard
            btnSideBarOnClick(btnDashboard);
            name = _nhanVienHienTai?.TenNV ?? _taiKhoanHienTai.HoTen ?? "";
            OpenChildForm(new Dashboard(name)); 

            // --- GỌI HÀM PHÂN QUYỀN & HIỂN THỊ ---
            PhanQuyen();
            HienThiThongTin();
        }

        /// <summary>
        /// Load thông tin nhân viên từ XML dựa trên MaNV của tài khoản hiện tại
        /// </summary>
        private void LoadNhanVien()
        {
            try
            {
                if (_taiKhoanHienTai == null || string.IsNullOrEmpty(_taiKhoanHienTai.MaNV))
                {
                    _nhanVienHienTai = null;
                    return;
                }

                DataTable dtNhanVien = XmlDataService.LoadTable("Nhanvien.xml", "NhanVien");
                DataRow? nvRow = dtNhanVien.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("MaNV") == _taiKhoanHienTai.MaNV);

                if (nvRow != null)
                {
                    _nhanVienHienTai = new NhanVien
                    {
                        MaNV = nvRow["MaNV"]?.ToString() ?? "",
                        TenNV = nvRow["TenNV"]?.ToString() ?? "",
                        ChucVu = nvRow["ChucVu"]?.ToString() ?? "",
                        SoDienThoai = nvRow["SoDienThoai"]?.ToString() ?? ""
                    };
                }
                else
                {
                    _nhanVienHienTai = null;
                }
            }
            catch (Exception ex)
            {
                // Nếu không load được nhân viên, để null
                _nhanVienHienTai = null;
                // Có thể log lỗi ở đây nếu cần
            }
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
            if (_nhanVienHienTai != null)
            {
                // Hiển thị tên nhân viên từ bảng NhanVien
                if (label_name != null) label_name.Text = _nhanVienHienTai.TenNV;

                // Hiển thị chức vụ từ bảng NhanVien
                if (label_role != null) label_role.Text = _nhanVienHienTai.ChucVu;
            }
            else if (_taiKhoanHienTai != null)
            {
                // Fallback: Nếu không có nhân viên, dùng thông tin từ tài khoản
                if (label_name != null) label_name.Text = _taiKhoanHienTai.HoTen ?? "N/A";
                if (label_role != null) label_role.Text = _taiKhoanHienTai.Quyen ?? "N/A";
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
            string userName = _nhanVienHienTai?.TenNV ?? _taiKhoanHienTai?.HoTen ?? "";
            OpenChildForm(new Dashboard(userName));
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