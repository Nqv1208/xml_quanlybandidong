using Guna.UI2.WinForms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLyNhanVien
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvNhanVien;
        private Guna2HtmlLabel lblMaNV;
        private Guna2TextBox txtMaNV;
        private Guna2TextBox txtTenNV;
        private Guna2TextBox txtChucVu;
        private Guna2TextBox txtSoDienThoai;
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
        private Guna2HtmlLabel lblTenNV;
        private Guna2HtmlLabel lblChucVu;
        private Guna2HtmlLabel lblSoDienThoai;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvNhanVien = new Guna2DataGridView();
            lblMaNV = new Guna2HtmlLabel();
            txtMaNV = new Guna2TextBox();
            txtTenNV = new Guna2TextBox();
            txtChucVu = new Guna2TextBox();
            txtSoDienThoai = new Guna2TextBox();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnLamMoi = new Guna2Button();
            groupBox1 = new Guna2GroupBox();
            lblSoDienThoai = new Guna2HtmlLabel();
            lblChucVu = new Guna2HtmlLabel();
            lblTenNV = new Guna2HtmlLabel();
            groupBox2 = new Guna2GroupBox();
            guna2GroupBox1 = new Guna2GroupBox();
            btn_chuyendoi = new Guna2Button();
            guna2Button1 = new Guna2Button();
            groupBoxSearch = new Guna2GroupBox();
            guna2HtmlLabel2 = new Guna2HtmlLabel();
            btn_timkiem = new Guna2Button();
            txtTimKiem = new Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            guna2GroupBox1.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.GridColor = Color.FromArgb(231, 229, 255);
            dgvNhanVien.Location = new Point(0, 40);
            dgvNhanVien.Margin = new Padding(3, 2, 3, 2);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(969, 347);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvNhanVien.ThemeStyle.BackColor = Color.White;
            dgvNhanVien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvNhanVien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvNhanVien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F);
            dgvNhanVien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.ThemeStyle.HeaderStyle.Height = 30;
            dgvNhanVien.ThemeStyle.ReadOnly = true;
            dgvNhanVien.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvNhanVien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            dgvNhanVien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvNhanVien.ThemeStyle.RowsStyle.Height = 29;
            dgvNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // lblMaNV
            // 
            lblMaNV.BackColor = Color.Transparent;
            lblMaNV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaNV.ForeColor = Color.FromArgb(149, 165, 166);
            lblMaNV.Location = new Point(20, 54);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(119, 27);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 5;
            txtMaNV.CustomizableEdges = customizableEdges1;
            txtMaNV.DefaultText = "";
            txtMaNV.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaNV.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaNV.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaNV.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaNV.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaNV.Font = new Font("Segoe UI", 10F);
            txtMaNV.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaNV.Location = new Point(145, 53);
            txtMaNV.Margin = new Padding(3, 2, 3, 2);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaNV.Size = new Size(240, 43);
            txtMaNV.TabIndex = 2;
            // 
            // txtTenNV
            // 
            txtTenNV.BorderRadius = 5;
            txtTenNV.CustomizableEdges = customizableEdges3;
            txtTenNV.DefaultText = "";
            txtTenNV.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenNV.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenNV.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenNV.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenNV.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenNV.Font = new Font("Segoe UI", 10F);
            txtTenNV.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenNV.Location = new Point(607, 54);
            txtTenNV.Margin = new Padding(3, 2, 3, 2);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.PlaceholderText = "";
            txtTenNV.SelectedText = "";
            txtTenNV.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTenNV.Size = new Size(300, 43);
            txtTenNV.TabIndex = 3;
            // 
            // txtChucVu
            // 
            txtChucVu.BorderRadius = 5;
            txtChucVu.CustomizableEdges = customizableEdges5;
            txtChucVu.DefaultText = "";
            txtChucVu.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtChucVu.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtChucVu.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtChucVu.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtChucVu.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChucVu.Font = new Font("Segoe UI", 10F);
            txtChucVu.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChucVu.Location = new Point(145, 110);
            txtChucVu.Margin = new Padding(3, 2, 3, 2);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.PlaceholderText = "";
            txtChucVu.SelectedText = "";
            txtChucVu.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtChucVu.Size = new Size(240, 43);
            txtChucVu.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderRadius = 5;
            txtSoDienThoai.CustomizableEdges = customizableEdges7;
            txtSoDienThoai.DefaultText = "";
            txtSoDienThoai.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSoDienThoai.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSoDienThoai.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSoDienThoai.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSoDienThoai.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSoDienThoai.Location = new Point(607, 110);
            txtSoDienThoai.Margin = new Padding(3, 2, 3, 2);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "";
            txtSoDienThoai.SelectedText = "";
            txtSoDienThoai.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSoDienThoai.Size = new Size(300, 43);
            txtSoDienThoai.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Animated = true;
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderRadius = 8;
            btnThem.CustomizableEdges = customizableEdges9;
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
            btnThem.Location = new Point(449, 176);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 8;
            btnThem.ShadowDecoration.Color = Color.FromArgb(46, 125, 50);
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            btnSua.CustomizableEdges = customizableEdges11;
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
            btnSua.Location = new Point(566, 176);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 8;
            btnSua.ShadowDecoration.Color = Color.FromArgb(25, 118, 210);
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            btnXoa.CustomizableEdges = customizableEdges13;
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
            btnXoa.Location = new Point(686, 176);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 8;
            btnXoa.ShadowDecoration.Color = Color.FromArgb(211, 47, 47);
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges14;
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
            btnLamMoi.CustomizableEdges = customizableEdges15;
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
            btnLamMoi.Location = new Point(802, 176);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 8;
            btnLamMoi.ShadowDecoration.Color = Color.FromArgb(158, 158, 158);
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnLamMoi.ShadowDecoration.Depth = 5;
            btnLamMoi.ShadowDecoration.Enabled = true;
            btnLamMoi.Size = new Size(105, 45);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSoDienThoai);
            groupBox1.Controls.Add(lblChucVu);
            groupBox1.Controls.Add(lblTenNV);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtChucVu);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(lblMaNV);
            groupBox1.CustomizableEdges = customizableEdges17;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.ShadowDecoration.CustomizableEdges = customizableEdges18;
            groupBox1.Size = new Size(972, 236);
            groupBox1.TabIndex = 0;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.BackColor = Color.Transparent;
            lblSoDienThoai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSoDienThoai.ForeColor = Color.FromArgb(149, 165, 166);
            lblSoDienThoai.Location = new Point(476, 120);
            lblSoDienThoai.Margin = new Padding(4);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(117, 27);
            lblSoDienThoai.TabIndex = 20;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblChucVu
            // 
            lblChucVu.BackColor = Color.Transparent;
            lblChucVu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblChucVu.ForeColor = Color.FromArgb(149, 165, 166);
            lblChucVu.Location = new Point(20, 119);
            lblChucVu.Margin = new Padding(4);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(72, 27);
            lblChucVu.TabIndex = 19;
            lblChucVu.Text = "Chức vụ:";
            // 
            // lblTenNV
            // 
            lblTenNV.BackColor = Color.Transparent;
            lblTenNV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTenNV.ForeColor = Color.FromArgb(149, 165, 166);
            lblTenNV.Location = new Point(472, 61);
            lblTenNV.Margin = new Padding(4);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(124, 27);
            lblTenNV.TabIndex = 18;
            lblTenNV.Text = "Tên nhân viên:";
            // 
            // groupBox2
            // 
            groupBox2.BorderRadius = 6;
            groupBox2.Controls.Add(dgvNhanVien);
            groupBox2.CustomizableEdges = customizableEdges19;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox2.Location = new Point(15, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.ShadowDecoration.CustomizableEdges = customizableEdges20;
            groupBox2.Size = new Size(969, 387);
            groupBox2.TabIndex = 1;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2GroupBox1.BorderRadius = 6;
            guna2GroupBox1.Controls.Add(btn_chuyendoi);
            guna2GroupBox1.Controls.Add(guna2Button1);
            guna2GroupBox1.CustomizableEdges = customizableEdges25;
            guna2GroupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(622, 267);
            guna2GroupBox1.Margin = new Padding(4);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges26;
            guna2GroupBox1.Size = new Size(362, 114);
            guna2GroupBox1.TabIndex = 5;
            guna2GroupBox1.Text = "Chuyển đổi";
            // 
            // btn_chuyendoi
            // 
            btn_chuyendoi.BorderRadius = 6;
            btn_chuyendoi.CustomizableEdges = customizableEdges21;
            btn_chuyendoi.FillColor = Color.FromArgb(52, 73, 94);
            btn_chuyendoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chuyendoi.ForeColor = Color.White;
            btn_chuyendoi.Location = new Point(18, 54);
            btn_chuyendoi.Margin = new Padding(4);
            btn_chuyendoi.Name = "btn_chuyendoi";
            btn_chuyendoi.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btn_chuyendoi.Size = new Size(100, 45);
            btn_chuyendoi.TabIndex = 14;
            btn_chuyendoi.Text = "Html";
            btn_chuyendoi.Click += btn_chuyendoi_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 6;
            guna2Button1.CustomizableEdges = customizableEdges23;
            guna2Button1.FillColor = Color.FromArgb(103, 58, 183);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(1050, 31);
            guna2Button1.Margin = new Padding(4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges24;
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
            groupBoxSearch.Location = new Point(15, 267);
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
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(149, 165, 166);
            guna2HtmlLabel2.Location = new Point(24, 66);
            guna2HtmlLabel2.Margin = new Padding(4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(118, 27);
            guna2HtmlLabel2.TabIndex = 17;
            guna2HtmlLabel2.Text = "Nhập từ khóa:";
            // 
            // btn_timkiem
            // 
            btn_timkiem.BorderRadius = 6;
            btn_timkiem.CustomizableEdges = customizableEdges27;
            btn_timkiem.FillColor = Color.FromArgb(46, 204, 113);
            btn_timkiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timkiem.ForeColor = Color.White;
            btn_timkiem.HoverState.FillColor = Color.FromArgb(39, 174, 96);
            btn_timkiem.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timkiem.Location = new Point(462, 54);
            btn_timkiem.Margin = new Padding(4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btn_timkiem.Size = new Size(108, 45);
            btn_timkiem.TabIndex = 15;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 6;
            txtTimKiem.CustomizableEdges = customizableEdges7;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(163, 54);
            txtTimKiem.Margin = new Padding(5, 6, 5, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTimKiem.Size = new Size(281, 45);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // frmQuanLyNhanVien
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
            MinimumSize = new Size(1000, 797);
            Name = "frmQuanLyNhanVien";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
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

