namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // --- KHAI BÁO CÁC CONTROL (Dựa trên hình ảnh bạn gửi) ---
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxInfo; // GroupBox: Thông tin khách hàng
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDienThoai;

        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;

        private Guna.UI2.WinForms.Guna2GroupBox groupBoxSearch; // GroupBox: Tìm kiếm
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTuKhoa;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btn_timkiem;

        private Guna.UI2.WinForms.Guna2GroupBox groupBoxConvert; // GroupBox: Chuyển đổi
        private Guna.UI2.WinForms.Guna2Button btn_chuyendoi;

        private Guna.UI2.WinForms.Guna2GroupBox groupBoxList; // GroupBox: Danh sách khách hàng
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBoxInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            lblSoDienThoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            lblTenKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            lblMaKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBoxSearch = new Guna.UI2.WinForms.Guna2GroupBox();
            btn_timkiem = new Guna.UI2.WinForms.Guna2Button();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            lblTuKhoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBoxConvert = new Guna.UI2.WinForms.Guna2GroupBox();
            btn_chuyendoi = new Guna.UI2.WinForms.Guna2Button();
            groupBoxList = new Guna.UI2.WinForms.Guna2GroupBox();
            dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            groupBoxInfo.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxConvert.SuspendLayout();
            groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(btnLamMoi);
            groupBoxInfo.Controls.Add(btnXoa);
            groupBoxInfo.Controls.Add(btnSua);
            groupBoxInfo.Controls.Add(btnThem);
            groupBoxInfo.Controls.Add(txtSoDienThoai);
            groupBoxInfo.Controls.Add(lblSoDienThoai);
            groupBoxInfo.Controls.Add(txtTenKH);
            groupBoxInfo.Controls.Add(lblTenKH);
            groupBoxInfo.Controls.Add(txtMaKH);
            groupBoxInfo.Controls.Add(lblMaKH);
            groupBoxInfo.CustomizableEdges = customizableEdges15;
            groupBoxInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxInfo.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxInfo.Location = new Point(15, 19);
            groupBoxInfo.Margin = new Padding(4, 5, 4, 5);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.ShadowDecoration.CustomizableEdges = customizableEdges16;
            groupBoxInfo.Size = new Size(972, 188);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.Text = "Thông tin khách hàng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Animated = true;
            btnLamMoi.BorderRadius = 8;
            btnLamMoi.CustomizableEdges = customizableEdges1;
            btnLamMoi.FillColor = Color.FromArgb(52, 73, 94);
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(855, 117);
            btnLamMoi.Margin = new Padding(4, 5, 4, 5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLamMoi.Size = new Size(105, 45);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Animated = true;
            btnXoa.BorderRadius = 8;
            btnXoa.CustomizableEdges = customizableEdges3;
            btnXoa.FillColor = Color.FromArgb(231, 76, 60);
            btnXoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(736, 117);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoa.Size = new Size(100, 45);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Animated = true;
            btnSua.BorderRadius = 8;
            btnSua.CustomizableEdges = customizableEdges5;
            btnSua.FillColor = Color.FromArgb(52, 152, 219);
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(618, 117);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSua.Size = new Size(100, 45);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Animated = true;
            btnThem.BorderRadius = 8;
            btnThem.CustomizableEdges = customizableEdges7;
            btnThem.FillColor = Color.FromArgb(46, 204, 113);
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(501, 117);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnThem.Size = new Size(100, 45);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderRadius = 5;
            txtSoDienThoai.CustomizableEdges = customizableEdges9;
            txtSoDienThoai.DefaultText = "";
            txtSoDienThoai.Font = new Font("Segoe UI", 9F);
            txtSoDienThoai.Location = new Point(634, 56);
            txtSoDienThoai.Margin = new Padding(5, 8, 5, 8);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "";
            txtSoDienThoai.SelectedText = "";
            txtSoDienThoai.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSoDienThoai.Size = new Size(275, 45);
            txtSoDienThoai.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.BackColor = Color.Transparent;
            lblSoDienThoai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSoDienThoai.ForeColor = Color.FromArgb(149, 165, 166);
            lblSoDienThoai.Location = new Point(508, 67);
            lblSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(117, 27);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtTenKH
            // 
            txtTenKH.BorderRadius = 5;
            txtTenKH.CustomizableEdges = customizableEdges11;
            txtTenKH.DefaultText = "";
            txtTenKH.Font = new Font("Segoe UI", 9F);
            txtTenKH.Location = new Point(188, 117);
            txtTenKH.Margin = new Padding(5, 8, 5, 8);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.PlaceholderText = "";
            txtTenKH.SelectedText = "";
            txtTenKH.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtTenKH.Size = new Size(275, 45);
            txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            lblTenKH.BackColor = Color.Transparent;
            lblTenKH.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTenKH.ForeColor = Color.FromArgb(149, 165, 166);
            lblTenKH.Location = new Point(38, 128);
            lblTenKH.Margin = new Padding(4, 5, 4, 5);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(135, 27);
            lblTenKH.TabIndex = 2;
            lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtMaKH
            // 
            txtMaKH.BorderRadius = 5;
            txtMaKH.CustomizableEdges = customizableEdges13;
            txtMaKH.DefaultText = "";
            txtMaKH.Font = new Font("Segoe UI", 9F);
            txtMaKH.Location = new Point(188, 56);
            txtMaKH.Margin = new Padding(5, 8, 5, 8);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.PlaceholderText = "";
            txtMaKH.SelectedText = "";
            txtMaKH.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtMaKH.Size = new Size(275, 45);
            txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            lblMaKH.BackColor = Color.Transparent;
            lblMaKH.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMaKH.ForeColor = Color.FromArgb(149, 165, 166);
            lblMaKH.Location = new Point(38, 65);
            lblMaKH.Margin = new Padding(4, 5, 4, 5);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(130, 27);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã khách hàng:";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(btn_timkiem);
            groupBoxSearch.Controls.Add(txtTimKiem);
            groupBoxSearch.Controls.Add(lblTuKhoa);
            groupBoxSearch.CustomizableEdges = customizableEdges21;
            groupBoxSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxSearch.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxSearch.Location = new Point(15, 227);
            groupBoxSearch.Margin = new Padding(4, 5, 4, 5);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges22;
            groupBoxSearch.Size = new Size(641, 134);
            groupBoxSearch.TabIndex = 1;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // btn_timkiem
            // 
            btn_timkiem.BorderRadius = 8;
            btn_timkiem.CustomizableEdges = customizableEdges17;
            btn_timkiem.FillColor = Color.FromArgb(46, 204, 113);
            btn_timkiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_timkiem.ForeColor = Color.White;
            btn_timkiem.Location = new Point(501, 59);
            btn_timkiem.Margin = new Padding(4, 5, 4, 5);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btn_timkiem.Size = new Size(113, 45);
            btn_timkiem.TabIndex = 2;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 5;
            txtTimKiem.CustomizableEdges = customizableEdges19;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(188, 59);
            txtTimKiem.Margin = new Padding(5, 8, 5, 8);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtTimKiem.Size = new Size(275, 45);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.BackColor = Color.Transparent;
            lblTuKhoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTuKhoa.ForeColor = Color.FromArgb(149, 165, 166);
            lblTuKhoa.Location = new Point(38, 69);
            lblTuKhoa.Margin = new Padding(4, 5, 4, 5);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(118, 27);
            lblTuKhoa.TabIndex = 0;
            lblTuKhoa.Text = "Nhập từ khóa:";
            // 
            // groupBoxConvert
            // 
            groupBoxConvert.Controls.Add(btn_chuyendoi);
            groupBoxConvert.CustomizableEdges = customizableEdges25;
            groupBoxConvert.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxConvert.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxConvert.Location = new Point(673, 227);
            groupBoxConvert.Margin = new Padding(4, 5, 4, 5);
            groupBoxConvert.Name = "groupBoxConvert";
            groupBoxConvert.ShadowDecoration.CustomizableEdges = customizableEdges26;
            groupBoxConvert.Size = new Size(314, 134);
            groupBoxConvert.TabIndex = 2;
            groupBoxConvert.Text = "Chuyển đổi";
            // 
            // btn_chuyendoi
            // 
            btn_chuyendoi.BorderRadius = 8;
            btn_chuyendoi.CustomizableEdges = customizableEdges23;
            btn_chuyendoi.FillColor = Color.FromArgb(52, 73, 94);
            btn_chuyendoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_chuyendoi.ForeColor = Color.White;
            btn_chuyendoi.Location = new Point(21, 59);
            btn_chuyendoi.Margin = new Padding(4, 5, 4, 5);
            btn_chuyendoi.Name = "btn_chuyendoi";
            btn_chuyendoi.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btn_chuyendoi.Size = new Size(100, 45);
            btn_chuyendoi.TabIndex = 0;
            btn_chuyendoi.Text = "Html";
            btn_chuyendoi.Click += btn_chuyendoi_Click;
            // 
            // groupBoxList
            // 
            groupBoxList.Controls.Add(dgvKhachHang);
            groupBoxList.CustomizableEdges = customizableEdges27;
            groupBoxList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxList.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxList.Location = new Point(15, 380);
            groupBoxList.Margin = new Padding(4, 5, 4, 5);
            groupBoxList.Name = "groupBoxList";
            groupBoxList.ShadowDecoration.CustomizableEdges = customizableEdges28;
            groupBoxList.Size = new Size(972, 401);
            groupBoxList.TabIndex = 3;
            groupBoxList.Text = "Danh sách khách hàng";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.Location = new Point(0, 40);
            dgvKhachHang.Margin = new Padding(4, 5, 4, 5);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.Size = new Size(972, 361);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvKhachHang.ThemeStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvKhachHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhachHang.ThemeStyle.HeaderStyle.Height = 30;
            dgvKhachHang.ThemeStyle.ReadOnly = true;
            dgvKhachHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhachHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvKhachHang.ThemeStyle.RowsStyle.Height = 33;
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // frmQuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 254, 250);
            ClientSize = new Size(1000, 795);
            Controls.Add(groupBoxList);
            Controls.Add(groupBoxConvert);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmQuanLyKhachHang";
            Text = "Quản lý khách hàng";
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxConvert.ResumeLayout(false);
            groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}