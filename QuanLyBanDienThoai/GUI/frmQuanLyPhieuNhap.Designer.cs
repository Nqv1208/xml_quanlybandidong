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
        private Guna2Button btnTimKiem;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            btnTimKiem = new Guna2Button();
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
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.RowTemplate.Height = 33;
            dgvPhieuNhap.Size = new Size(776, 221);
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
            txtMaPN.Location = new Point(120, 37);
            txtMaPN.Margin = new Padding(4, 5, 4, 5);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.PlaceholderText = "";
            txtMaPN.SelectedText = "";
            txtMaPN.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaPN.Size = new Size(220, 36);
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
            cboMaNCC.Location = new Point(120, 81);
            cboMaNCC.Name = "cboMaNCC";
            cboMaNCC.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboMaNCC.Size = new Size(221, 46);
            cboMaNCC.TabIndex = 3;
            // 
            // txtMaNV
            // 
            txtMaNV.BorderRadius = 6;
            txtMaNV.CustomizableEdges = customizableEdges5;
            txtMaNV.DefaultText = "";
            txtMaNV.Font = new Font("Segoe UI", 9F);
            txtMaNV.Location = new Point(120, 126);
            txtMaNV.Margin = new Padding(4, 5, 4, 5);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.PlaceholderText = "";
            txtMaNV.SelectedText = "";
            txtMaNV.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMaNV.Size = new Size(220, 36);
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
            dtNgayNhap.Location = new Point(501, 37);
            dtNgayNhap.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtNgayNhap.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtNgayNhap.Name = "dtNgayNhap";
            dtNgayNhap.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtNgayNhap.Size = new Size(250, 36);
            dtNgayNhap.TabIndex = 7;
            dtNgayNhap.Value = new DateTime(2025, 12, 8, 21, 20, 55, 602);
            // 
            // txtTongTien
            // 
            txtTongTien.BorderRadius = 6;
            txtTongTien.CustomizableEdges = customizableEdges9;
            txtTongTien.DefaultText = "";
            txtTongTien.Font = new Font("Segoe UI", 9F);
            txtTongTien.Location = new Point(501, 81);
            txtTongTien.Margin = new Padding(4, 5, 4, 5);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.PlaceholderText = "";
            txtTongTien.SelectedText = "";
            txtTongTien.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTongTien.Size = new Size(250, 36);
            txtTongTien.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 6;
            txtTimKiem.CustomizableEdges = customizableEdges11;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(120, 43);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtTimKiem.Size = new Size(220, 36);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.BorderRadius = 6;
            btnThem.CustomizableEdges = customizableEdges13;
            btnThem.FillColor = Color.FromArgb(46, 204, 113);
            btnThem.Font = new Font("Segoe UI", 9F);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(400, 126);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnThem.Size = new Size(80, 36);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BorderRadius = 6;
            btnSua.CustomizableEdges = customizableEdges15;
            btnSua.FillColor = Color.FromArgb(52, 152, 219);
            btnSua.Font = new Font("Segoe UI", 9F);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(486, 126);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnSua.Size = new Size(80, 36);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 6;
            btnXoa.CustomizableEdges = customizableEdges17;
            btnXoa.FillColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI", 9F);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(573, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnXoa.Size = new Size(80, 36);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BorderRadius = 6;
            btnLamMoi.CustomizableEdges = customizableEdges19;
            btnLamMoi.FillColor = Color.FromArgb(52, 73, 94);
            btnLamMoi.Font = new Font("Segoe UI", 9F);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(660, 126);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnLamMoi.Size = new Size(90, 36);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BorderRadius = 6;
            btnTimKiem.CustomizableEdges = customizableEdges21;
            btnTimKiem.FillColor = Color.FromArgb(103, 58, 183);
            btnTimKiem.Font = new Font("Segoe UI", 9F);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(840, 25);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnTimKiem.Size = new Size(100, 36);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
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
            groupBoxInfo.CustomizableEdges = customizableEdges23;
            groupBoxInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxInfo.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.ShadowDecoration.CustomizableEdges = customizableEdges24;
            groupBoxInfo.Size = new Size(778, 172);
            groupBoxInfo.TabIndex = 2;
            groupBoxInfo.Text = "Thông tin phiếu nhập";
            // 
            // lblMaPN
            // 
            lblMaPN.BackColor = Color.Transparent;
            lblMaPN.Location = new Point(20, 43);
            lblMaPN.Name = "lblMaPN";
            lblMaPN.Size = new Size(50, 22);
            lblMaPN.TabIndex = 0;
            lblMaPN.Text = "Mã PN:";
            // 
            // lblMaNCC
            // 
            lblMaNCC.BackColor = Color.Transparent;
            lblMaNCC.Location = new Point(20, 90);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(97, 22);
            lblMaNCC.TabIndex = 2;
            lblMaNCC.Text = "Nhà cung cấp:";
            // 
            // lblMaNV
            // 
            lblMaNV.BackColor = Color.Transparent;
            lblMaNV.Location = new Point(20, 134);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(51, 22);
            lblMaNV.TabIndex = 4;
            lblMaNV.Text = "Mã NV:";
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.BackColor = Color.Transparent;
            lblNgayNhap.Location = new Point(401, 40);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(78, 22);
            lblNgayNhap.TabIndex = 6;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.Transparent;
            lblTongTien.Location = new Point(401, 85);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(69, 22);
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
            groupBoxSearch.Controls.Add(btnTimKiem);
            groupBoxSearch.CustomizableEdges = customizableEdges27;
            groupBoxSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBoxSearch.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxSearch.Location = new Point(12, 190);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges28;
            groupBoxSearch.Size = new Size(475, 91);
            groupBoxSearch.TabIndex = 1;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            btn_timkiem.BorderRadius = 6;
            btn_timkiem.CustomizableEdges = customizableEdges25;
            btn_timkiem.FillColor = Color.FromArgb(46, 204, 113);
            btn_timkiem.Font = new Font("Segoe UI", 9F);
            btn_timkiem.ForeColor = Color.White;
            btn_timkiem.Location = new Point(358, 43);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btn_timkiem.Size = new Size(86, 36);
            btn_timkiem.TabIndex = 15;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.BackColor = Color.Transparent;
            lblTimKiem.Location = new Point(20, 50);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(59, 22);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Từ khóa:";
            // 
            // groupBoxGrid
            // 
            groupBoxGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGrid.BorderRadius = 6;
            groupBoxGrid.Controls.Add(dgvPhieuNhap);
            groupBoxGrid.CustomizableEdges = customizableEdges29;
            groupBoxGrid.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupBoxGrid.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxGrid.Location = new Point(12, 288);
            groupBoxGrid.Name = "groupBoxGrid";
            groupBoxGrid.ShadowDecoration.CustomizableEdges = customizableEdges30;
            groupBoxGrid.Size = new Size(776, 261);
            groupBoxGrid.TabIndex = 0;
            groupBoxGrid.Text = "Danh sách phiếu nhập";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2GroupBox1.BorderRadius = 6;
            guna2GroupBox1.Controls.Add(btn_chuyendoi);
            guna2GroupBox1.Controls.Add(guna2Button1);
            guna2GroupBox1.CustomizableEdges = customizableEdges35;
            guna2GroupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(498, 190);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges36;
            guna2GroupBox1.Size = new Size(290, 91);
            guna2GroupBox1.TabIndex = 3;
            guna2GroupBox1.Text = "Chuyển đổi";
         
            // 
            // btn_chuyendoi
            // 
            btn_chuyendoi.BorderRadius = 6;
            btn_chuyendoi.CustomizableEdges = customizableEdges31;
            btn_chuyendoi.FillColor = Color.FromArgb(46, 204, 113);
            btn_chuyendoi.Font = new Font("Segoe UI", 9F);
            btn_chuyendoi.ForeColor = Color.White;
            btn_chuyendoi.Location = new Point(14, 43);
            btn_chuyendoi.Name = "btn_chuyendoi";
            btn_chuyendoi.ShadowDecoration.CustomizableEdges = customizableEdges32;
            btn_chuyendoi.Size = new Size(80, 36);
            btn_chuyendoi.TabIndex = 14;
            btn_chuyendoi.Text = "Html";
            btn_chuyendoi.Click += btn_chuyendoi_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 6;
            guna2Button1.CustomizableEdges = customizableEdges33;
            guna2Button1.FillColor = Color.FromArgb(103, 58, 183);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(840, 25);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges34;
            guna2Button1.Size = new Size(100, 36);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Tìm kiếm";
            // 
            // frmQuanLyPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(guna2GroupBox1);
            Controls.Add(groupBoxGrid);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxInfo);
            FormBorderStyle = FormBorderStyle.None;
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

