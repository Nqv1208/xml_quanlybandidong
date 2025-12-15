using Guna.UI2.WinForms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLyTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvTaiKhoan;
        private Guna2HtmlLabel lblMaTK;
        private Guna2TextBox txtMaTK;
        private Guna2TextBox txtTenDangNhap;
        private Guna2TextBox txtMatKhau;
        private Guna2ComboBox cboQuyen;
        private Guna2ComboBox cboNhanVien;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnLamMoi;
        private Guna2GroupBox groupBox1;
        private Guna2GroupBox groupBox2;
        private Guna2GroupBox guna2GroupBox1;
        private Guna2Button btn_chuyendoi;
        private Guna2Button guna2Button1;
        private Guna2GroupBox groupBoxSearch;
        private Guna2Button btn_timkiem;
        private Guna2TextBox txtTimKiem;
        private Guna2HtmlLabel lblTenDangNhap;
        private Guna2HtmlLabel lblMatKhau;
        private Guna2HtmlLabel lblQuyen;
        private Guna2HtmlLabel lblNhanVien;
        private Guna2HtmlLabel guna2HtmlLabel2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvTaiKhoan = new Guna2DataGridView();
            lblMaTK = new Guna2HtmlLabel();
            txtMaTK = new Guna2TextBox();
            txtTenDangNhap = new Guna2TextBox();
            txtMatKhau = new Guna2TextBox();
            cboQuyen = new Guna2ComboBox();
            cboNhanVien = new Guna2ComboBox();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnLamMoi = new Guna2Button();
            groupBox1 = new Guna2GroupBox();
            lblNhanVien = new Guna2HtmlLabel();
            lblQuyen = new Guna2HtmlLabel();
            lblMatKhau = new Guna2HtmlLabel();
            lblTenDangNhap = new Guna2HtmlLabel();
            groupBox2 = new Guna2GroupBox();
            guna2GroupBox1 = new Guna2GroupBox();
            btn_chuyendoi = new Guna2Button();
            guna2Button1 = new Guna2Button();
            groupBoxSearch = new Guna2GroupBox();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            btn_timkiem = new Guna2Button();
            txtTimKiem = new Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            guna2GroupBox1.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTaiKhoan.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.GridColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.Location = new Point(0, 40);
            dgvTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 29;
            dgvTaiKhoan.Size = new Size(972, 356);
            dgvTaiKhoan.TabIndex = 0;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 30;
            dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 29;
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            // 
            // lblMaTK
            // 
            lblMaTK.BackColor = Color.Transparent;
            lblMaTK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaTK.ForeColor = Color.FromArgb(149, 165, 166);
            lblMaTK.Location = new Point(20, 61);
            lblMaTK.Name = "lblMaTK";
            lblMaTK.Size = new Size(114, 27);
            lblMaTK.TabIndex = 0;
            lblMaTK.Text = "Mã tài khoản:";
            // 
            // txtMaTK
            // 
            txtMaTK.BorderRadius = 5;
            txtMaTK.CustomizableEdges = customizableEdges1;
            txtMaTK.DefaultText = "";
            txtMaTK.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaTK.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaTK.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaTK.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaTK.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTK.Font = new Font("Segoe UI", 10F);
            txtMaTK.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTK.Location = new Point(140, 54);
            txtMaTK.Margin = new Padding(3, 2, 3, 2);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.PlaceholderText = "";
            txtMaTK.SelectedText = "";
            txtMaTK.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaTK.Size = new Size(300, 43);
            txtMaTK.TabIndex = 2;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderRadius = 5;
            txtTenDangNhap.CustomizableEdges = customizableEdges3;
            txtTenDangNhap.DefaultText = "";
            txtTenDangNhap.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenDangNhap.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenDangNhap.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangNhap.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangNhap.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangNhap.Location = new Point(625, 110);
            txtTenDangNhap.Margin = new Padding(3, 2, 3, 2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "";
            txtTenDangNhap.SelectedText = "";
            txtTenDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTenDangNhap.Size = new Size(300, 43);
            txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderRadius = 5;
            txtMatKhau.CustomizableEdges = customizableEdges5;
            txtMatKhau.DefaultText = "";
            txtMatKhau.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMatKhau.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMatKhau.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Location = new Point(140, 110);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.PlaceholderText = "";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMatKhau.Size = new Size(300, 43);
            txtMatKhau.TabIndex = 8;
            // 
            // cboQuyen
            // 
            cboQuyen.BackColor = Color.Transparent;
            cboQuyen.BorderRadius = 5;
            cboQuyen.CustomizableEdges = customizableEdges7;
            cboQuyen.DrawMode = DrawMode.OwnerDrawFixed;
            cboQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyen.FocusedColor = Color.Empty;
            cboQuyen.Font = new Font("Segoe UI", 10F);
            cboQuyen.ForeColor = Color.FromArgb(68, 88, 112);
            cboQuyen.ItemHeight = 40;
            cboQuyen.Items.AddRange(new object[] { "Admin", "NhanVien" });
            cboQuyen.Location = new Point(625, 54);
            cboQuyen.Margin = new Padding(4);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cboQuyen.Size = new Size(300, 46);
            cboQuyen.TabIndex = 9;
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.Transparent;
            cboNhanVien.BorderRadius = 5;
            cboNhanVien.CustomizableEdges = customizableEdges9;
            cboNhanVien.DrawMode = DrawMode.OwnerDrawFixed;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FocusedColor = Color.Empty;
            cboNhanVien.Font = new Font("Segoe UI", 10F);
            cboNhanVien.ForeColor = Color.FromArgb(68, 88, 112);
            cboNhanVien.ItemHeight = 40;
            cboNhanVien.Location = new Point(140, 168);
            cboNhanVien.Margin = new Padding(4);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cboNhanVien.Size = new Size(300, 46);
            cboNhanVien.TabIndex = 10;
            cboNhanVien.SelectedIndexChanged += cboNhanVien_SelectedIndexChanged;
            // 
            // btnThem
            // 
            btnThem.Animated = true;
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderRadius = 8;
            btnThem.CustomizableEdges = customizableEdges11;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.FromArgb(46, 204, 113);
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.HoverState.FillColor = Color.FromArgb(39, 174, 96);
            btnThem.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThem.HoverState.ForeColor = Color.White;
            btnThem.Location = new Point(472, 167);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 8;
            btnThem.ShadowDecoration.Color = Color.FromArgb(46, 125, 50);
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnThem.ShadowDecoration.Depth = 5;
            btnThem.ShadowDecoration.Enabled = true;
            btnThem.Size = new Size(100, 45);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Animated = true;
            btnSua.BackColor = Color.Transparent;
            btnSua.BorderRadius = 8;
            btnSua.CustomizableEdges = customizableEdges13;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.FromArgb(52, 152, 219);
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.HoverState.FillColor = Color.FromArgb(41, 128, 185);
            btnSua.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.HoverState.ForeColor = Color.White;
            btnSua.Location = new Point(593, 168);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 8;
            btnSua.ShadowDecoration.Color = Color.FromArgb(25, 118, 210);
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSua.ShadowDecoration.Depth = 5;
            btnSua.ShadowDecoration.Enabled = true;
            btnSua.Size = new Size(105, 45);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Animated = true;
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BorderRadius = 8;
            btnXoa.CustomizableEdges = customizableEdges15;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.FromArgb(231, 76, 60);
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnXoa.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoa.HoverState.ForeColor = Color.White;
            btnXoa.Location = new Point(717, 169);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 8;
            btnXoa.ShadowDecoration.Color = Color.FromArgb(211, 47, 47);
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnXoa.ShadowDecoration.Depth = 5;
            btnXoa.ShadowDecoration.Enabled = true;
            btnXoa.Size = new Size(100, 45);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Animated = true;
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.BorderRadius = 8;
            btnLamMoi.CustomizableEdges = customizableEdges17;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.FillColor = Color.FromArgb(52, 73, 94);
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.HoverState.FillColor = Color.FromArgb(44, 62, 80);
            btnLamMoi.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.HoverState.ForeColor = Color.White;
            btnLamMoi.Location = new Point(839, 169);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 8;
            btnLamMoi.ShadowDecoration.Color = Color.FromArgb(158, 158, 158);
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnLamMoi.ShadowDecoration.Depth = 5;
            btnLamMoi.ShadowDecoration.Enabled = true;
            btnLamMoi.Size = new Size(105, 45);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNhanVien);
            groupBox1.Controls.Add(lblQuyen);
            groupBox1.Controls.Add(lblMatKhau);
            groupBox1.Controls.Add(lblTenDangNhap);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(cboQuyen);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtMaTK);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(lblMaTK);
            groupBox1.CustomizableEdges = customizableEdges19;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            groupBox1.Size = new Size(972, 229);
            groupBox1.TabIndex = 0;
            groupBox1.Text = "Thông tin tài khoản";
            // 
            // lblNhanVien
            // 
            lblNhanVien.BackColor = Color.Transparent;
            lblNhanVien.ForeColor = Color.FromArgb(149, 165, 166);
            lblNhanVien.Location = new Point(20, 177);
            lblNhanVien.Margin = new Padding(4);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(86, 27);
            lblNhanVien.TabIndex = 24;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // lblQuyen
            // 
            lblQuyen.BackColor = Color.Transparent;
            lblQuyen.ForeColor = Color.FromArgb(149, 165, 166);
            lblQuyen.Location = new Point(472, 120);
            lblQuyen.Margin = new Padding(4);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(59, 27);
            lblQuyen.TabIndex = 23;
            lblQuyen.Text = "Quyền:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.BackColor = Color.Transparent;
            lblMatKhau.ForeColor = Color.FromArgb(149, 165, 166);
            lblMatKhau.Location = new Point(20, 119);
            lblMatKhau.Margin = new Padding(4);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(81, 27);
            lblMatKhau.TabIndex = 22;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.BackColor = Color.Transparent;
            lblTenDangNhap.ForeColor = Color.FromArgb(149, 165, 166);
            lblTenDangNhap.Location = new Point(472, 63);
            lblTenDangNhap.Margin = new Padding(4);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(126, 27);
            lblTenDangNhap.TabIndex = 21;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // groupBox2
            // 
            groupBox2.BorderRadius = 6;
            groupBox2.Controls.Add(dgvTaiKhoan);
            groupBox2.CustomizableEdges = customizableEdges21;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox2.Location = new Point(15, 388);
            groupBox2.Name = "groupBox2";
            groupBox2.ShadowDecoration.CustomizableEdges = customizableEdges22;
            groupBox2.Size = new Size(972, 396);
            groupBox2.TabIndex = 1;
            groupBox2.Text = "Danh sách tài khoản";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2GroupBox1.BorderRadius = 6;
            guna2GroupBox1.Controls.Add(btn_chuyendoi);
            guna2GroupBox1.Controls.Add(guna2Button1);
            guna2GroupBox1.CustomizableEdges = customizableEdges27;
            guna2GroupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(622, 259);
            guna2GroupBox1.Margin = new Padding(4);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges28;
            guna2GroupBox1.Size = new Size(362, 114);
            guna2GroupBox1.TabIndex = 5;
            guna2GroupBox1.Text = "Chuyển đổi";
            // 
            // btn_chuyendoi
            // 
            btn_chuyendoi.BorderRadius = 6;
            btn_chuyendoi.CustomizableEdges = customizableEdges23;
            btn_chuyendoi.FillColor = Color.FromArgb(52, 73, 94);
            btn_chuyendoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chuyendoi.ForeColor = Color.White;
            btn_chuyendoi.Location = new Point(18, 54);
            btn_chuyendoi.Margin = new Padding(4);
            btn_chuyendoi.Name = "btn_chuyendoi";
            btn_chuyendoi.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btn_chuyendoi.Size = new Size(100, 45);
            btn_chuyendoi.TabIndex = 14;
            btn_chuyendoi.Text = "Html";
            btn_chuyendoi.Click += btn_chuyendoi_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 6;
            guna2Button1.CustomizableEdges = customizableEdges25;
            guna2Button1.FillColor = Color.FromArgb(103, 58, 183);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(1050, 31);
            guna2Button1.Margin = new Padding(4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2Button1.Size = new Size(125, 45);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Tìm kiếm";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.BorderRadius = 6;
            groupBoxSearch.Controls.Add(guna2HtmlLabel2);
            groupBoxSearch.Controls.Add(btn_timkiem);
            groupBoxSearch.Controls.Add(txtTimKiem);
            groupBoxSearch.CustomizableEdges = customizableEdges29;
            groupBoxSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxSearch.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxSearch.Location = new Point(15, 259);
            groupBoxSearch.Margin = new Padding(4);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges30;
            groupBoxSearch.Size = new Size(588, 114);
            groupBoxSearch.TabIndex = 4;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel2.Location = new Point(24, 66);
            guna2HtmlLabel2.Margin = new Padding(4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(116, 27);
            guna2HtmlLabel2.TabIndex = 17;
            guna2HtmlLabel2.Text = "Nhập từ khóa:";
            // 
            // btn_timkiem
            // 
            btn_timkiem.BorderRadius = 6;
            btn_timkiem.CustomizableEdges = customizableEdges7;
            btn_timkiem.FillColor = Color.FromArgb(46, 204, 113);
            btn_timkiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timkiem.ForeColor = Color.White;
            btn_timkiem.HoverState.FillColor = Color.FromArgb(39, 174, 96);
            btn_timkiem.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timkiem.Location = new Point(462, 54);
            btn_timkiem.Margin = new Padding(4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_timkiem.Size = new Size(108, 45);
            btn_timkiem.TabIndex = 15;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 6;
            txtTimKiem.CustomizableEdges = customizableEdges5;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(163, 54);
            txtTimKiem.Margin = new Padding(5, 6, 5, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTimKiem.Size = new Size(281, 45);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // frmQuanLyTaiKhoan
            // 
            BackColor = Color.FromArgb(242, 254, 250);
            ClientSize = new Size(1000, 797);
            Controls.Add(guna2GroupBox1);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(948, 687);
            Name = "frmQuanLyTaiKhoan";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            guna2GroupBox1.ResumeLayout(false);
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
        }
    }
}

