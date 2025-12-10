using Guna.UI2.WinForms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLySanPham
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvSanPham;
        private Guna2HtmlLabel lblMaSP;
        private Guna2HtmlLabel lblTenSP;
        private Guna2HtmlLabel lblMaHang;
        private Guna2HtmlLabel lblGiaBan;
        private Guna2HtmlLabel lblSoLuongTon;
        private Guna2HtmlLabel lblMoTa;
        private Guna2HtmlLabel lblTimKiem;
        private Guna2TextBox txtMaSP;
        private Guna2TextBox txtTenSP;
        private Guna2ComboBox cboMaHang;
        private Guna2TextBox txtGiaBan;
        private Guna2TextBox txtSoLuongTon;
        private Guna2TextBox txtMoTa;
        private Guna2TextBox txtTimKiem;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnTimKiem;
        private Guna2Button btnLamMoi;
        private Guna2GroupBox groupBox1;
        private Guna2GroupBox groupBox2;
        private Guna2GroupBox groupBox3;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvSanPham = new Guna2DataGridView();
            lblMaSP = new Guna2HtmlLabel();
            lblTenSP = new Guna2HtmlLabel();
            lblMaHang = new Guna2HtmlLabel();
            lblGiaBan = new Guna2HtmlLabel();
            lblSoLuongTon = new Guna2HtmlLabel();
            lblMoTa = new Guna2HtmlLabel();
            lblTimKiem = new Guna2HtmlLabel();
            txtMaSP = new Guna2TextBox();
            txtTenSP = new Guna2TextBox();
            cboMaHang = new Guna2ComboBox();
            txtGiaBan = new Guna2TextBox();
            txtSoLuongTon = new Guna2TextBox();
            txtMoTa = new Guna2TextBox();
            txtTimKiem = new Guna2TextBox();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnTimKiem = new Guna2Button();
            btnLamMoi = new Guna2Button();
            groupBox1 = new Guna2GroupBox();
            groupBox2 = new Guna2GroupBox();
            groupBox3 = new Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSanPham.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.GridColor = Color.FromArgb(231, 229, 255);
            dgvSanPham.Location = new Point(0, 40);
            dgvSanPham.Margin = new Padding(3, 2, 3, 2);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 29;
            dgvSanPham.Size = new Size(972, 190);
            dgvSanPham.TabIndex = 0;
            dgvSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSanPham.ThemeStyle.BackColor = Color.White;
            dgvSanPham.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvSanPham.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvSanPham.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSanPham.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F);
            dgvSanPham.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSanPham.ThemeStyle.HeaderStyle.Height = 30;
            dgvSanPham.ThemeStyle.ReadOnly = true;
            dgvSanPham.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSanPham.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSanPham.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            dgvSanPham.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSanPham.ThemeStyle.RowsStyle.Height = 29;
            dgvSanPham.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSanPham.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // lblMaSP
            // 
            lblMaSP.BackColor = Color.Transparent;
            lblMaSP.Font = new Font("Segoe UI", 10F);
            lblMaSP.ForeColor = Color.Black;
            lblMaSP.Location = new Point(18, 58);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(124, 30);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã sản phẩm:";
            // 
            // lblTenSP
            // 
            lblTenSP.BackColor = Color.Transparent;
            lblTenSP.Font = new Font("Segoe UI", 10F);
            lblTenSP.ForeColor = Color.Black;
            lblTenSP.Location = new Point(20, 116);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(127, 30);
            lblTenSP.TabIndex = 1;
            lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblMaHang
            // 
            lblMaHang.BackColor = Color.Transparent;
            lblMaHang.Font = new Font("Segoe UI", 10F);
            lblMaHang.ForeColor = Color.Black;
            lblMaHang.Location = new Point(24, 175);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(82, 30);
            lblMaHang.TabIndex = 2;
            lblMaHang.Text = "Hãng SX:";
            // 
            // lblGiaBan
            // 
            lblGiaBan.BackColor = Color.Transparent;
            lblGiaBan.Font = new Font("Segoe UI", 10F);
            lblGiaBan.ForeColor = Color.Black;
            lblGiaBan.Location = new Point(510, 59);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(74, 30);
            lblGiaBan.TabIndex = 3;
            lblGiaBan.Text = "Giá bán:";
            // 
            // lblSoLuongTon
            // 
            lblSoLuongTon.BackColor = Color.Transparent;
            lblSoLuongTon.Font = new Font("Segoe UI", 10F);
            lblSoLuongTon.ForeColor = Color.Black;
            lblSoLuongTon.Location = new Point(510, 116);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Size = new Size(122, 30);
            lblSoLuongTon.TabIndex = 4;
            lblSoLuongTon.Text = "Số lượng tồn:";
            // 
            // lblMoTa
            // 
            lblMoTa.BackColor = Color.Transparent;
            lblMoTa.Font = new Font("Segoe UI", 10F);
            lblMoTa.ForeColor = Color.Black;
            lblMoTa.Location = new Point(510, 179);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(59, 30);
            lblMoTa.TabIndex = 5;
            lblMoTa.Text = "Mô tả:";
            // 
            // lblTimKiem
            // 
            lblTimKiem.BackColor = Color.Transparent;
            lblTimKiem.Font = new Font("Segoe UI", 10F);
            lblTimKiem.ForeColor = Color.Black;
            lblTimKiem.Location = new Point(20, 59);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(86, 30);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtMaSP
            // 
            txtMaSP.BorderRadius = 5;
            txtMaSP.CustomizableEdges = customizableEdges1;
            txtMaSP.DefaultText = "";
            txtMaSP.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaSP.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaSP.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaSP.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaSP.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaSP.Font = new Font("Segoe UI", 10F);
            txtMaSP.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaSP.Location = new Point(160, 50);
            txtMaSP.Margin = new Padding(3, 2, 3, 2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.PlaceholderText = "";
            txtMaSP.SelectedText = "";
            txtMaSP.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaSP.Size = new Size(250, 45);
            txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            txtTenSP.BorderRadius = 5;
            txtTenSP.CustomizableEdges = customizableEdges3;
            txtTenSP.DefaultText = "";
            txtTenSP.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenSP.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenSP.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenSP.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenSP.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenSP.Font = new Font("Segoe UI", 10F);
            txtTenSP.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenSP.Location = new Point(160, 108);
            txtTenSP.Margin = new Padding(3, 2, 3, 2);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.PlaceholderText = "";
            txtTenSP.SelectedText = "";
            txtTenSP.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTenSP.Size = new Size(250, 45);
            txtTenSP.TabIndex = 7;
            // 
            // cboMaHang
            // 
            cboMaHang.BackColor = Color.Transparent;
            cboMaHang.BorderRadius = 5;
            cboMaHang.CustomizableEdges = customizableEdges5;
            cboMaHang.DrawMode = DrawMode.OwnerDrawFixed;
            cboMaHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaHang.FocusedColor = Color.FromArgb(94, 148, 255);
            cboMaHang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboMaHang.Font = new Font("Segoe UI", 10F);
            cboMaHang.ForeColor = Color.FromArgb(68, 88, 112);
            cboMaHang.ItemHeight = 40;
            cboMaHang.Location = new Point(160, 166);
            cboMaHang.Margin = new Padding(3, 2, 3, 2);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cboMaHang.Size = new Size(250, 46);
            cboMaHang.TabIndex = 8;
            // 
            // txtGiaBan
            // 
            txtGiaBan.BorderRadius = 5;
            txtGiaBan.CustomizableEdges = customizableEdges7;
            txtGiaBan.DefaultText = "";
            txtGiaBan.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtGiaBan.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtGiaBan.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtGiaBan.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtGiaBan.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGiaBan.Font = new Font("Segoe UI", 10F);
            txtGiaBan.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtGiaBan.Location = new Point(650, 50);
            txtGiaBan.Margin = new Padding(3, 2, 3, 2);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.PlaceholderText = "";
            txtGiaBan.SelectedText = "";
            txtGiaBan.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtGiaBan.Size = new Size(212, 45);
            txtGiaBan.TabIndex = 9;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.BorderRadius = 5;
            txtSoLuongTon.CustomizableEdges = customizableEdges9;
            txtSoLuongTon.DefaultText = "";
            txtSoLuongTon.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSoLuongTon.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSoLuongTon.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSoLuongTon.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSoLuongTon.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoLuongTon.Font = new Font("Segoe UI", 10F);
            txtSoLuongTon.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoLuongTon.Location = new Point(650, 108);
            txtSoLuongTon.Margin = new Padding(3, 2, 3, 2);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.PlaceholderText = "";
            txtSoLuongTon.SelectedText = "";
            txtSoLuongTon.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSoLuongTon.Size = new Size(212, 45);
            txtSoLuongTon.TabIndex = 10;
            // 
            // txtMoTa
            // 
            txtMoTa.BorderRadius = 5;
            txtMoTa.CustomizableEdges = customizableEdges11;
            txtMoTa.DefaultText = "";
            txtMoTa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMoTa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMoTa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMoTa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMoTa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMoTa.Font = new Font("Segoe UI", 10F);
            txtMoTa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMoTa.Location = new Point(650, 166);
            txtMoTa.Margin = new Padding(3, 2, 3, 2);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.PlaceholderText = "";
            txtMoTa.SelectedText = "";
            txtMoTa.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtMoTa.Size = new Size(212, 63);
            txtMoTa.TabIndex = 11;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 5;
            txtTimKiem.CustomizableEdges = customizableEdges13;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(112, 59);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã, tên sản phẩm hoặc hãng sản xuất...";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtTimKiem.Size = new Size(472, 41);
            txtTimKiem.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Animated = true;
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderRadius = 8;
            btnThem.CustomizableEdges = customizableEdges15;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.FromArgb(46, 125, 50);
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(162, 248);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 8;
            btnThem.ShadowDecoration.Color = Color.FromArgb(46, 125, 50);
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnThem.ShadowDecoration.Depth = 5;
            btnThem.ShadowDecoration.Enabled = true;
            btnThem.Size = new Size(120, 45);
            btnThem.TabIndex = 12;
            btnThem.Text = "➕ Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Animated = true;
            btnSua.BackColor = Color.Transparent;
            btnSua.BorderRadius = 8;
            btnSua.CustomizableEdges = customizableEdges17;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.FromArgb(25, 118, 210);
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(302, 248);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 8;
            btnSua.ShadowDecoration.Color = Color.FromArgb(25, 118, 210);
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnSua.ShadowDecoration.Depth = 5;
            btnSua.ShadowDecoration.Enabled = true;
            btnSua.Size = new Size(120, 45);
            btnSua.TabIndex = 13;
            btnSua.Text = "✏️ Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Animated = true;
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BorderRadius = 8;
            btnXoa.CustomizableEdges = customizableEdges19;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(442, 248);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 8;
            btnXoa.ShadowDecoration.Color = Color.FromArgb(211, 47, 47);
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnXoa.ShadowDecoration.Depth = 5;
            btnXoa.ShadowDecoration.Enabled = true;
            btnXoa.Size = new Size(120, 45);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Animated = true;
            btnTimKiem.BackColor = Color.Transparent;
            btnTimKiem.BorderRadius = 8;
            btnTimKiem.CustomizableEdges = customizableEdges21;
            btnTimKiem.DisabledState.BorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTimKiem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTimKiem.FillColor = Color.FromArgb(103, 58, 183);
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(618, 59);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.BorderRadius = 8;
            btnTimKiem.ShadowDecoration.Color = Color.FromArgb(103, 58, 183);
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnTimKiem.ShadowDecoration.Depth = 5;
            btnTimKiem.ShadowDecoration.Enabled = true;
            btnTimKiem.Size = new Size(180, 41);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Animated = true;
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.BorderRadius = 8;
            btnLamMoi.CustomizableEdges = customizableEdges23;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.FillColor = Color.FromArgb(158, 158, 158);
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(582, 248);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 8;
            btnLamMoi.ShadowDecoration.Color = Color.FromArgb(158, 158, 158);
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnLamMoi.ShadowDecoration.Depth = 5;
            btnLamMoi.ShadowDecoration.Enabled = true;
            btnLamMoi.Size = new Size(150, 45);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtSoLuongTon);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(cboMaHang);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(lblMoTa);
            groupBox1.Controls.Add(lblSoLuongTon);
            groupBox1.Controls.Add(lblGiaBan);
            groupBox1.Controls.Add(lblMaHang);
            groupBox1.Controls.Add(lblTenSP);
            groupBox1.Controls.Add(lblMaSP);
            groupBox1.CustomizableEdges = customizableEdges25;
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.ShadowDecoration.CustomizableEdges = customizableEdges26;
            groupBox1.Size = new Size(972, 307);
            groupBox1.TabIndex = 0;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(lblTimKiem);
            groupBox2.CustomizableEdges = customizableEdges27;
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox2.Location = new Point(15, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.ShadowDecoration.CustomizableEdges = customizableEdges28;
            groupBox2.Size = new Size(972, 109);
            groupBox2.TabIndex = 1;
            groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSanPham);
            groupBox3.CustomizableEdges = customizableEdges29;
            groupBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox3.Location = new Point(15, 458);
            groupBox3.Name = "groupBox3";
            groupBox3.ShadowDecoration.CustomizableEdges = customizableEdges30;
            groupBox3.Size = new Size(972, 230);
            groupBox3.TabIndex = 2;
            groupBox3.Text = "Danh sách sản phẩm";
            // 
            // frmQuanLySanPham
            // 
            BackColor = Color.FromArgb(242, 254, 250);
            ClientSize = new Size(1000, 701);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1000, 701);
            Name = "frmQuanLySanPham";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += frmQuanLySanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
