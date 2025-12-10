using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace QuanLyBanDienThoai.GUI
{
    public partial class frmMain : Form  // ✅ Kế thừa từ Form
    {
        private Form? currentForm = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            img_header.Image = Properties.Resources.layout_dashboard_2;
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

        private void btn_hangsanxuat_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Hãng Sản Xuất";
            //img_header.Image = Properties.Resources.image;
            OpenChildForm(new frmQuanLyHangSanXuat());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Sản Phẩm";
            img_header.Image = Properties.Resources.package_open_2;
            OpenChildForm(new frmQuanLySanPham());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Khách Hàng";
            img_header.Image = Properties.Resources.users_2;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Hóa Đơn";
            img_header.Image = Properties.Resources.clipboard_list_2;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Phiếu Nhập";
            img_header.Image = Properties.Resources.file_bar_chart_;
            OpenChildForm(new frmQuanLyPhieuNhap(this));
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            label_header.Text = "Quản Lý Nhà Cung Cấp";
            img_header.Image = Properties.Resources.store_2;
            OpenChildForm(new frmQuanLyNhaCungCap());
        }
    }
}