using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLyPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvPhieuNhap;
        private Guna2TextBox txtMaPN;
        private Guna2ComboBox cboMaNCC;
        private Guna2TextBox txtMaNV;
        private Guna2DateTimePicker dtNgayNhap;
        private Guna2TextBox txtTongTien;
        private Guna2TextBox txtTimKiem;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnLamMoi;
        private Guna2GroupBox groupBoxInfo;
        private Guna2GroupBox groupBoxSearch;
        private Guna2GroupBox groupBoxGrid;
        private Guna2HtmlLabel lblMaPN;
        private Guna2HtmlLabel lblMaNCC;
        private Guna2HtmlLabel lblMaNV;
        private Guna2HtmlLabel lblNgayNhap;
        private Guna2HtmlLabel lblTongTien;
        private Guna2HtmlLabel lblTimKiem;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvPhieuNhap = new Guna2DataGridView();
            txtMaPN = new Guna2TextBox();
            cboMaNCC = new Guna2ComboBox();
            txtMaNV = new Guna2TextBox();
            dtNgayNhap = new Guna2DateTimePicker();
            txtTongTien = new Guna2TextBox();
            txtTimKiem = new Guna2TextBox();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnLamMoi = new Guna2Button();
            groupBoxInfo = new Guna2GroupBox();
            lblMaPN = new Guna2HtmlLabel();
            lblMaNCC = new Guna2HtmlLabel();
            lblMaNV = new Guna2HtmlLabel();
            lblNgayNhap = new Guna2HtmlLabel();
            lblTongTien = new Guna2HtmlLabel();
            groupBoxSearch = new Guna2GroupBox();
            btn_timkiem = new Guna2Button();
            lblTimKiem = new Guna2HtmlLabel();
            groupBoxGrid = new Guna2GroupBox();
            guna2GroupBox1 = new Guna2GroupBox();
            btn_chuyendoi = new Guna2Button();
            guna2Button1 = new Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            groupBoxInfo.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxGrid.SuspendLayout();
            guna2GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvPhieuNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuNhap.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.GridColor = Color.FromArgb(231, 229, 255);
            dgvPhieuNhap.Location = new Point(0, 40);
            dgvPhieuNhap.Margin = new Padding(4);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.Size = new Size(970, 275);
            dgvPhieuNhap.TabIndex = 0;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvPhieuNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvPhieuNhap.ThemeStyle.BackColor = Color.White;
            dgvPhieuNhap.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvPhieuNhap.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvPhieuNhap.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPhieuNhap.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvPhieuNhap.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvPhieuNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhieuNhap.ThemeStyle.HeaderStyle.Height = 30;
            dgvPhieuNhap.ThemeStyle.ReadOnly = true;
            dgvPhieuNhap.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvPhieuNhap.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPhieuNhap.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvPhieuNhap.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvPhieuNhap.ThemeStyle.RowsStyle.Height = 33;
            dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvPhieuNhap.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            dgvPhieuNhap.CellDoubleClick += dgvPhieuNhap_CellDoubleClick;
            // 
            // txtMaPN
            // 
            txtMaPN.BorderRadius = 6;
            txtMaPN.CustomizableEdges = customizableEdges1;
            txtMaPN.DefaultText = "";
            txtMaPN.Font = new Font("Segoe UI", 9F);
            txtMaPN.Location = new Point(150, 46);
            txtMaPN.Margin = new Padding(5, 6, 5, 6);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.PlaceholderText = "";
            txtMaPN.SelectedText = "";
            txtMaPN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaPN.Size = new Size(275, 45);
            txtMaPN.TabIndex = 1;
            // 
            // cboMaNCC
            // 
            cboMaNCC.BackColor = Color.Transparent;
            cboMaNCC.BorderRadius = 6;
            cboMaNCC.CustomizableEdges = customizableEdges3;
            cboMaNCC.DrawMode = DrawMode.OwnerDrawFixed;
            cboMaNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaNCC.FocusedColor = Color.Empty;
            cboMaNCC.Font = new Font("Segoe UI", 10F);
            cboMaNCC.ForeColor = Color.FromArgb(68, 88, 112);
            cboMaNCC.ItemHeight = 40;
            cboMaNCC.Location = new Point(150, 101);
            cboMaNCC.Margin = new Padding(4);
            cboMaNCC.Name = "cboMaNCC";
            cboMaNCC.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboMaNCC.Size = new Size(275, 46);
            cboMaNCC.TabIndex = 3;
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 6;
            txtMaNV.CustomizableEdges = customizableEdges5;
            txtMaNV.DefaultText = "";
            txtMaNV.Font = new Font("Segoe UI", 9F);
            txtMaNV.Location = new Point(150, 158);
            txtMaNV.Margin = new Padding(5, 6, 5, 6);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMaNV.Size = new Size(275, 45);
            txtMaNV.TabIndex = 5;
            // 
            // dtNgayNhap
            // 
            dtNgayNhap.BorderRadius = 6;
            dtNgayNhap.Checked = true;
            dtNgayNhap.CustomFormat = "dd/MM/yyyy HH:mm";
            dtNgayNhap.CustomizableEdges = customizableEdges7;
            dtNgayNhap.FillColor = Color.FromArgb(236, 240, 241);
            dtNgayNhap.Font = new Font("Segoe UI", 9F);
            dtNgayNhap.Format = DateTimePickerFormat.Custom;
            dtNgayNhap.Location = new Point(626, 46);
            dtNgayNhap.Margin = new Padding(4);
            dtNgayNhap.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtNgayNhap.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtNgayNhap.Size = new Size(312, 45);
            dtNgayNhap.TabIndex = 7;
            dtNgayNhap.Value = new DateTime(2025, 12, 8, 21, 20, 55, 602);
            // 
            // txtTongTien
            // 
            txtTongTien.BorderRadius = 6;
            txtTongTien.CustomizableEdges = customizableEdges9;
            txtTongTien.DefaultText = "";
            txtTongTien.Font = new Font("Segoe UI", 9F);
            txtTongTien.Location = new Point(626, 101);
            txtTongTien.Margin = new Padding(5, 6, 5, 6);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.PlaceholderText = "";
            txtTongTien.SelectedText = "";
            txtTongTien.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTongTien.Size = new Size(312, 45);
            txtTongTien.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 6;
            txtTimKiem.CustomizableEdges = customizableEdges11;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(150, 54);
            txtTimKiem.Margin = new Padding(5, 6, 5, 6);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtTimKiem.Size = new Size(275, 45);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Animated = true;
            btnThem.BorderRadius = 6;
            btnThem.CustomizableEdges = customizableEdges13;
            btnThem.FillColor = Color.FromArgb(46, 204, 113);
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.HoverState.FillColor = Color.FromArgb(46, 204, 113);
            btnThem.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.HoverState.ForeColor = Color.White;
            btnThem.Location = new Point(500, 158);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnThem.Size = new Size(100, 45);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Animated = true;
            btnSua.BorderRadius = 6;
            btnSua.CustomizableEdges = customizableEdges15;
            btnSua.FillColor = Color.FromArgb(52, 152, 219);
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.HoverState.FillColor = Color.FromArgb(41, 128, 185);
            btnSua.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.HoverState.ForeColor = Color.White;
            btnSua.Location = new Point(608, 158);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnSua.Size = new Size(100, 45);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Animated = true;
            btnXoa.BorderRadius = 6;
            btnXoa.CustomizableEdges = customizableEdges17;
            btnXoa.FillColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnXoa.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.HoverState.ForeColor = Color.White;
            btnXoa.Location = new Point(716, 158);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnXoa.Size = new Size(100, 45);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Animated = true;
            btnLamMoi.BorderRadius = 6;
            btnLamMoi.CustomizableEdges = customizableEdges19;
            btnLamMoi.FillColor = Color.FromArgb(52, 73, 94);
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.HoverState.FillColor = Color.FromArgb(44, 62, 80);
            btnLamMoi.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.HoverState.ForeColor = Color.White;
            btnLamMoi.Location = new Point(825, 158);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnLamMoi.Size = new Size(112, 45);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo.BorderRadius = 6;
            groupBoxInfo.Controls.Add(lblMaPN);
            groupBoxInfo.Controls.Add(txtMaPN);
            groupBoxInfo.Controls.Add(lblMaNCC);
            groupBoxInfo.Controls.Add(cboMaNCC);
            groupBoxInfo.Controls.Add(lblMaNV);
            groupBoxInfo.Controls.Add(txtMaNV);
            groupBoxInfo.Controls.Add(lblNgayNhap);
            groupBoxInfo.Controls.Add(dtNgayNhap);
            groupBoxInfo.Controls.Add(lblTongTien);
            groupBoxInfo.Controls.Add(txtTongTien);
            groupBoxInfo.Controls.Add(btnThem);
            groupBoxInfo.Controls.Add(btnSua);
            groupBoxInfo.Controls.Add(btnXoa);
            groupBoxInfo.Controls.Add(btnLamMoi);
            groupBoxInfo.CustomizableEdges = customizableEdges21;
            groupBoxInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxInfo.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxInfo.Location = new Point(15, 15);
            groupBoxInfo.Margin = new Padding(4);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.ShadowDecoration.CustomizableEdges = customizableEdges22;
            groupBoxInfo.Size = new Size(972, 215);
            groupBoxInfo.TabIndex = 2;
            groupBoxInfo.Text = "Thông tin phiếu nhập";
            // 
            // lblMaPN
            // 
            lblMaPN.BackColor = Color.Transparent;
            lblMaPN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMaPN.ForeColor = Color.FromArgb(149, 165, 166);
            lblMaPN.Location = new Point(25, 54);
            lblMaPN.Margin = new Padding(4);
            lblMaPN.Name = "lblMaPN";
            lblMaPN.Size = new Size(63, 27);
            lblMaPN.TabIndex = 0;
            lblMaPN.Text = "Mã PN:";
            // 
            // lblMaNCC
            // 
            lblMaNCC.BackColor = Color.Transparent;
            lblMaNCC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMaNCC.ForeColor = Color.FromArgb(149, 165, 166);
            lblMaNCC.Location = new Point(25, 112);
            lblMaNCC.Margin = new Padding(4);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(119, 27);
            lblMaNCC.TabIndex = 2;
            lblMaNCC.Text = "Nhà cung cấp:";
            // 
            // lblMaNV
            // 
            lblMaNV.BackColor = Color.Transparent;
            lblMaNV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMaNV.ForeColor = Color.FromArgb(149, 165, 166);
            lblMaNV.Location = new Point(25, 168);
            lblMaNV.Margin = new Padding(4);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(64, 27);
            lblMaNV.TabIndex = 4;
            lblMaNV.Text = "Mã NV:";
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.BackColor = Color.Transparent;
            lblNgayNhap.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNgayNhap.ForeColor = Color.FromArgb(149, 165, 166);
            lblNgayNhap.Location = new Point(501, 50);
            lblNgayNhap.Margin = new Padding(4);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(96, 27);
            lblNgayNhap.TabIndex = 6;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.Transparent;
            lblTongTien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(149, 165, 166);
            lblTongTien.Location = new Point(501, 106);
            lblTongTien.Margin = new Padding(4);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(88, 27);
            lblTongTien.TabIndex = 8;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.BorderRadius = 6;
            groupBoxSearch.Controls.Add(btn_timkiem);
            groupBoxSearch.Controls.Add(lblTimKiem);
            groupBoxSearch.Controls.Add(txtTimKiem);
            groupBoxSearch.CustomizableEdges = customizableEdges25;
            groupBoxSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxSearch.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxSearch.Location = new Point(15, 244);
            groupBoxSearch.Margin = new Padding(4);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges26;
            groupBoxSearch.Size = new Size(594, 114);
            groupBoxSearch.TabIndex = 1;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            btn_timkiem.Animated = true;
            btn_timkiem.BorderRadius = 6;
            btn_timkiem.CustomizableEdges = customizableEdges23;
            btn_timkiem.FillColor = Color.FromArgb(46, 204, 113);
            btn_timkiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_timkiem.ForeColor = SystemColors.Window;
            btn_timkiem.HoverState.FillColor = Color.FromArgb(46, 204, 113);
            btn_timkiem.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timkiem.HoverState.ForeColor = Color.White;
            btn_timkiem.Location = new Point(448, 54);
            btn_timkiem.Margin = new Padding(4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.ShadowDecoration.BorderRadius = 8;
            btn_timkiem.ShadowDecoration.Color = Color.FromArgb(25, 118, 210);
            btn_timkiem.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btn_timkiem.Size = new Size(108, 45);
            btn_timkiem.TabIndex = 15;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.BackColor = Color.Transparent;
            lblTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTimKiem.ForeColor = Color.FromArgb(149, 165, 166);
            lblTimKiem.Location = new Point(25, 62);
            lblTimKiem.Margin = new Padding(4);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(72, 27);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Từ khóa:";
            // 
            // groupBoxGrid
            // 
            groupBoxGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGrid.BorderRadius = 6;
            groupBoxGrid.Controls.Add(dgvPhieuNhap);
            groupBoxGrid.CustomizableEdges = customizableEdges27;
            groupBoxGrid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxGrid.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxGrid.Location = new Point(15, 373);
            groupBoxGrid.Margin = new Padding(4);
            groupBoxGrid.Name = "groupBoxGrid";
            groupBoxGrid.ShadowDecoration.CustomizableEdges = customizableEdges28;
            groupBoxGrid.Size = new Size(970, 315);
            groupBoxGrid.TabIndex = 0;
            groupBoxGrid.Text = "Danh sách phiếu nhập";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2GroupBox1.BorderRadius = 6;
            guna2GroupBox1.Controls.Add(btn_chuyendoi);
            guna2GroupBox1.Controls.Add(guna2Button1);
            guna2GroupBox1.CustomizableEdges = customizableEdges33;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(622, 244);
            guna2GroupBox1.Margin = new Padding(4);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges34;
            guna2GroupBox1.Size = new Size(362, 114);
            guna2GroupBox1.TabIndex = 3;
            guna2GroupBox1.Text = "Chuyển đổi";
            guna2GroupBox1.Click += guna2GroupBox1_Click;
            // 
            // btn_chuyendoi
            // 
            btn_chuyendoi.Animated = true;
            btn_chuyendoi.BorderRadius = 6;
            btn_chuyendoi.CustomizableEdges = customizableEdges29;
            btn_chuyendoi.FillColor = Color.FromArgb(46, 204, 113);
            btn_chuyendoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_chuyendoi.ForeColor = SystemColors.Window;
            btn_chuyendoi.HoverState.FillColor = Color.FromArgb(46, 204, 113);
            btn_chuyendoi.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chuyendoi.HoverState.ForeColor = Color.White;
            btn_chuyendoi.Location = new Point(18, 54);
            btn_chuyendoi.Margin = new Padding(4);
            btn_chuyendoi.Name = "btn_chuyendoi";
            btn_chuyendoi.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btn_chuyendoi.Size = new Size(100, 45);
            btn_chuyendoi.TabIndex = 14;
            btn_chuyendoi.Text = "Html";
            btn_chuyendoi.Click += btn_chuyendoi_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 6;
            guna2Button1.CustomizableEdges = customizableEdges31;
            guna2Button1.FillColor = Color.FromArgb(103, 58, 183);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(1050, 31);
            guna2Button1.Margin = new Padding(4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges32;
            guna2Button1.Size = new Size(125, 45);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Tìm kiếm";
            // 
            // frmQuanLyPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 701);
            Controls.Add(guna2GroupBox1);
            Controls.Add(groupBoxGrid);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmQuanLyPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý phiếu nhập";
            Load += frmQuanLyPhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxGrid.ResumeLayout(false);
            guna2GroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Guna2Button btn_timkiem;
        private Guna2GroupBox guna2GroupBox1;
        private Guna2Button btn_chuyendoi;
        private Guna2Button guna2Button1;
    }
}

