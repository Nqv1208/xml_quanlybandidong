using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLyNhaCungCap
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvNCC;
        private Guna2TextBox txtTimKiem;
        private Guna2Button btnTimKiem;
        private Guna2GroupBox groupBoxSearch;
        private Guna2GroupBox groupBoxGrid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvNCC = new Guna2DataGridView();
            txtTimKiem = new Guna2TextBox();
            btnTimKiem = new Guna2Button();
            groupBoxInfo = new Guna2GroupBox();
            guna2HtmlLabel5 = new Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna2HtmlLabel();
            txtMaNCC = new Guna2TextBox();
            txtTenNCC = new Guna2TextBox();
            txtDiaChi = new Guna2TextBox();
            txtSoDienThoai = new Guna2TextBox();
            txtEmail = new Guna2TextBox();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnLamMoi = new Guna2Button();
            lblMaNCC = new Guna2HtmlLabel();
            lblTenNCC = new Guna2HtmlLabel();
            lblDiaChi = new Guna2HtmlLabel();
            lblSoDienThoai = new Guna2HtmlLabel();
            lblEmail = new Guna2HtmlLabel();
            groupBoxSearch = new Guna2GroupBox();
            guna2HtmlLabel6 = new Guna2HtmlLabel();
            groupBoxGrid = new Guna2GroupBox();
            groupBoxConvert = new Guna2GroupBox();
            guna2Button1 = new Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            groupBoxInfo.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxGrid.SuspendLayout();
            groupBoxConvert.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNCC
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNCC.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNCC.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNCC.Dock = DockStyle.Fill;
            dgvNCC.GridColor = Color.FromArgb(231, 229, 255);
            dgvNCC.Location = new Point(0, 40);
            dgvNCC.Margin = new Padding(8);
            dgvNCC.Name = "dgvNCC";
            dgvNCC.ReadOnly = true;
            dgvNCC.RowHeadersVisible = false;
            dgvNCC.RowHeadersWidth = 62;
            dgvNCC.Size = new Size(966, 321);
            dgvNCC.TabIndex = 0;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvNCC.ThemeStyle.BackColor = Color.White;
            dgvNCC.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvNCC.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvNCC.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNCC.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvNCC.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNCC.ThemeStyle.HeaderStyle.Height = 30;
            dgvNCC.ThemeStyle.ReadOnly = true;
            dgvNCC.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvNCC.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNCC.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvNCC.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvNCC.ThemeStyle.RowsStyle.Height = 33;
            dgvNCC.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvNCC.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvNCC.CellClick += dgvNCC_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 6;
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(147, 54);
            txtTimKiem.Margin = new Padding(5, 6, 5, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(265, 45);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BorderRadius = 8;
            btnTimKiem.CustomizableEdges = customizableEdges3;
            btnTimKiem.FillColor = Color.FromArgb(46, 204, 113);
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(472, 54);
            btnTimKiem.Margin = new Padding(8);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTimKiem.Size = new Size(117, 45);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo.BorderRadius = 6;
            groupBoxInfo.Controls.Add(guna2HtmlLabel5);
            groupBoxInfo.Controls.Add(guna2HtmlLabel4);
            groupBoxInfo.Controls.Add(guna2HtmlLabel3);
            groupBoxInfo.Controls.Add(guna2HtmlLabel2);
            groupBoxInfo.Controls.Add(guna2HtmlLabel1);
            groupBoxInfo.Controls.Add(txtMaNCC);
            groupBoxInfo.Controls.Add(txtTenNCC);
            groupBoxInfo.Controls.Add(txtDiaChi);
            groupBoxInfo.Controls.Add(txtSoDienThoai);
            groupBoxInfo.Controls.Add(txtEmail);
            groupBoxInfo.Controls.Add(btnThem);
            groupBoxInfo.Controls.Add(btnSua);
            groupBoxInfo.Controls.Add(btnXoa);
            groupBoxInfo.Controls.Add(btnLamMoi);
            groupBoxInfo.CustomizableEdges = customizableEdges21;
            groupBoxInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBoxInfo.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxInfo.Location = new Point(17, 17);
            groupBoxInfo.Margin = new Padding(8);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.ShadowDecoration.CustomizableEdges = customizableEdges22;
            groupBoxInfo.Size = new Size(966, 253);
            groupBoxInfo.TabIndex = 2;
            groupBoxInfo.Text = "Thông tin nhà cung cấp";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel5.Location = new Point(472, 118);
            guna2HtmlLabel5.Margin = new Padding(8);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(51, 27);
            guna2HtmlLabel5.TabIndex = 17;
            guna2HtmlLabel5.Text = "Email:";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel4.Location = new Point(472, 61);
            guna2HtmlLabel4.Margin = new Padding(8);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(117, 27);
            guna2HtmlLabel4.TabIndex = 16;
            guna2HtmlLabel4.Text = "Số điện thoại:";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel3.Location = new Point(30, 177);
            guna2HtmlLabel3.Margin = new Padding(8);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(62, 27);
            guna2HtmlLabel3.TabIndex = 15;
            guna2HtmlLabel3.Text = "Địa chỉ:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel2.Location = new Point(30, 118);
            guna2HtmlLabel2.Margin = new Padding(8);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(152, 27);
            guna2HtmlLabel2.TabIndex = 14;
            guna2HtmlLabel2.Text = "Tên nhà cung cấp:";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel1.Location = new Point(30, 61);
            guna2HtmlLabel1.Margin = new Padding(8);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(147, 27);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Mã nhà cung cấp:";
            // 
            // txtMaNCC
            // 
            txtMaNCC.BorderRadius = 6;
            txtMaNCC.CustomizableEdges = customizableEdges5;
            txtMaNCC.DefaultText = "";
            txtMaNCC.Font = new Font("Segoe UI", 9F);
            txtMaNCC.Location = new Point(190, 51);
            txtMaNCC.Margin = new Padding(5, 6, 5, 6);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.PlaceholderText = "";
            txtMaNCC.SelectedText = "";
            txtMaNCC.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMaNCC.Size = new Size(235, 45);
            txtMaNCC.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            txtTenNCC.BorderRadius = 6;
            txtTenNCC.CustomizableEdges = customizableEdges7;
            txtTenNCC.DefaultText = "";
            txtTenNCC.Font = new Font("Segoe UI", 9F);
            txtTenNCC.Location = new Point(190, 108);
            txtTenNCC.Margin = new Padding(5, 6, 5, 6);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.PlaceholderText = "";
            txtTenNCC.SelectedText = "";
            txtTenNCC.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTenNCC.Size = new Size(235, 45);
            txtTenNCC.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderRadius = 6;
            txtDiaChi.CustomizableEdges = customizableEdges9;
            txtDiaChi.DefaultText = "";
            txtDiaChi.Font = new Font("Segoe UI", 9F);
            txtDiaChi.Location = new Point(190, 165);
            txtDiaChi.Margin = new Padding(5, 6, 5, 6);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "";
            txtDiaChi.SelectedText = "";
            txtDiaChi.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtDiaChi.Size = new Size(235, 45);
            txtDiaChi.TabIndex = 5;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderRadius = 6;
            txtSoDienThoai.CustomizableEdges = customizableEdges9;
            txtSoDienThoai.DefaultText = "";
            txtSoDienThoai.Font = new Font("Segoe UI", 9F);
            txtSoDienThoai.Location = new Point(602, 51);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "";
            txtSoDienThoai.SelectedText = "";
            txtSoDienThoai.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSoDienThoai.Size = new Size(325, 45);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 6;
            txtEmail.CustomizableEdges = customizableEdges11;
            txtEmail.DefaultText = "";
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(602, 108);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtEmail.Size = new Size(325, 45);
            txtEmail.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.BorderRadius = 8;
            btnThem.CustomizableEdges = customizableEdges13;
            btnThem.FillColor = Color.FromArgb(46, 204, 113);
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(472, 184);
            btnThem.Margin = new Padding(8);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnThem.Size = new Size(100, 45);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BorderRadius = 8;
            btnSua.CustomizableEdges = customizableEdges15;
            btnSua.FillColor = Color.FromArgb(25, 118, 210);
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(588, 184);
            btnSua.Margin = new Padding(8);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnSua.Size = new Size(100, 45);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 8;
            btnXoa.CustomizableEdges = customizableEdges17;
            btnXoa.FillColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(704, 184);
            btnXoa.Margin = new Padding(8);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnXoa.Size = new Size(100, 45);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BorderRadius = 8;
            btnLamMoi.CustomizableEdges = customizableEdges19;
            btnLamMoi.FillColor = Color.FromArgb(52, 73, 94);
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(820, 184);
            btnLamMoi.Margin = new Padding(8);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnLamMoi.Size = new Size(107, 45);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblMaNCC
            // 
            lblMaNCC.BackColor = Color.Transparent;
            lblMaNCC.Location = new Point(49, 125);
            lblMaNCC.Margin = new Padding(8);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(72, 27);
            lblMaNCC.TabIndex = 0;
            lblMaNCC.Text = "Mã NCC:";
            // 
            // lblTenNCC
            // 
            lblTenNCC.BackColor = Color.Transparent;
            lblTenNCC.Location = new Point(49, 244);
            lblTenNCC.Margin = new Padding(8);
            lblTenNCC.Name = "lblTenNCC";
            lblTenNCC.Size = new Size(75, 27);
            lblTenNCC.TabIndex = 2;
            lblTenNCC.Text = "Tên NCC:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.BackColor = Color.Transparent;
            lblDiaChi.Location = new Point(50, 356);
            lblDiaChi.Margin = new Padding(8);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(60, 27);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.BackColor = Color.Transparent;
            lblSoDienThoai.Location = new Point(882, 98);
            lblSoDienThoai.Margin = new Padding(8);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(112, 27);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Location = new Point(882, 195);
            lblEmail.Margin = new Padding(8);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 27);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.BorderRadius = 6;
            groupBoxSearch.Controls.Add(guna2HtmlLabel6);
            groupBoxSearch.Controls.Add(txtTimKiem);
            groupBoxSearch.Controls.Add(btnTimKiem);
            groupBoxSearch.CustomizableEdges = customizableEdges23;
            groupBoxSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBoxSearch.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxSearch.Location = new Point(17, 286);
            groupBoxSearch.Margin = new Padding(8);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges24;
            groupBoxSearch.Size = new Size(609, 115);
            groupBoxSearch.TabIndex = 1;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2HtmlLabel6.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel6.Location = new Point(30, 63);
            guna2HtmlLabel6.Margin = new Padding(8);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(68, 27);
            guna2HtmlLabel6.TabIndex = 18;
            guna2HtmlLabel6.Text = "Từ khóa";
            // 
            // groupBoxGrid
            // 
            groupBoxGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGrid.BorderRadius = 6;
            groupBoxGrid.Controls.Add(dgvNCC);
            groupBoxGrid.CustomizableEdges = customizableEdges25;
            groupBoxGrid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBoxGrid.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxGrid.Location = new Point(17, 417);
            groupBoxGrid.Margin = new Padding(8);
            groupBoxGrid.Name = "groupBoxGrid";
            groupBoxGrid.ShadowDecoration.CustomizableEdges = customizableEdges26;
            groupBoxGrid.Size = new Size(966, 361);
            groupBoxGrid.TabIndex = 0;
            groupBoxGrid.Text = "Danh sách nhà cung cấp";
            // 
            // groupBoxConvert
            // 
            groupBoxConvert.BorderRadius = 6;
            groupBoxConvert.Controls.Add(guna2Button1);
            groupBoxConvert.CustomizableEdges = customizableEdges29;
            groupBoxConvert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxConvert.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxConvert.Location = new Point(637, 286);
            groupBoxConvert.Name = "groupBoxConvert";
            groupBoxConvert.ShadowDecoration.CustomizableEdges = customizableEdges30;
            groupBoxConvert.Size = new Size(346, 115);
            groupBoxConvert.TabIndex = 3;
            groupBoxConvert.Text = "Chuyển đổi";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 8;
            guna2Button1.CustomizableEdges = customizableEdges27;
            guna2Button1.FillColor = Color.FromArgb(52, 73, 94);
            guna2Button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(23, 54);
            guna2Button1.Margin = new Padding(8);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2Button1.Size = new Size(117, 45);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "Html";
            // 
            // frmQuanLyNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 795);
            Controls.Add(groupBoxConvert);
            Controls.Add(groupBoxGrid);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmQuanLyNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxGrid.ResumeLayout(false);
            groupBoxConvert.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Guna2Button btnLamMoi;
        private Guna2Button btnXoa;
        private Guna2Button btnSua;
        private Guna2Button btnThem;
        private Guna2TextBox txtEmail;
        private Guna2TextBox txtSoDienThoai;
        private Guna2TextBox txtDiaChi;
        private Guna2TextBox txtTenNCC;
        private Guna2TextBox txtMaNCC;
        private Guna2GroupBox groupBoxInfo;
        private Guna2HtmlLabel lblEmail;
        private Guna2HtmlLabel lblSoDienThoai;
        private Guna2HtmlLabel lblDiaChi;
        private Guna2HtmlLabel lblTenNCC;
        private Guna2HtmlLabel lblMaNCC;
        private Guna2HtmlLabel guna2HtmlLabel2;
        private Guna2HtmlLabel guna2HtmlLabel1;
        private Guna2HtmlLabel guna2HtmlLabel5;
        private Guna2HtmlLabel guna2HtmlLabel4;
        private Guna2HtmlLabel guna2HtmlLabel3;
        private Guna2HtmlLabel guna2HtmlLabel6;
        private Guna2GroupBox groupBoxConvert;
        private Guna2Button guna2Button1;
    }
}

