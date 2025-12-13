using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmMain : Form  // ✅ Kế thừa từ Form
    {
        private Form? currentForm = null;
        private Dictionary<Guna2Button, Image> _originalImages = new Dictionary<Guna2Button, Image>();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmMain()
        {
            InitializeComponent();
            label_header.Text = "Tổng quan";
            img_header.Image = Properties.Resources.layout_dashboard_2;
            ResetSidebarButtons();
            btnSideBarOnClick(btnDashboard);
            OpenChildForm(new DashBoard());

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            img_header.Image = Properties.Resources.layout_dashboard_2;

            // Lưu Image ban đầu của các button sidebar
            SaveOriginalButtonStates();
        }

        private void SaveOriginalButtonStates()
        {
            foreach (Control c in guna2Panel_sidebar.Controls)
            {
                if (c is Guna2Button btn)
                {
                    // Lưu Image ban đầu vào Dictionary
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
            fm.Dock = DockStyle.Fill;
            guna2Panel_Container.Controls.Add(fm);
            guna2Panel_Container.Tag = fm;
            fm.Show();
        }

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
            // Áp dụng trạng thái hover khi button được click
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
                    // Reset về trạng thái ban đầu
                    b.FillColor = Color.Transparent;
                    b.ForeColor = Color.Black;
                    b.BorderColor = Color.Transparent;

                    // Khôi phục Image ban đầu nếu đã lưu
                    if (_originalImages.ContainsKey(b))
                    {
                        b.Image = _originalImages[b];
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}