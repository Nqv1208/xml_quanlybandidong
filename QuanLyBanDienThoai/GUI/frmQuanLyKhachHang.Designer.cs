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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.components = new System.ComponentModel.Container();

            // Khởi tạo các đối tượng
            this.groupBoxInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblMaKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoDienThoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();

            this.groupBoxSearch = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTuKhoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_timkiem = new Guna.UI2.WinForms.Guna2Button();

            this.groupBoxConvert = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_chuyendoi = new Guna.UI2.WinForms.Guna2Button();

            this.groupBoxList = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();

            this.groupBoxInfo.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxConvert.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();

            // 
            // --- 1. GROUP BOX: THÔNG TIN KHÁCH HÀNG ---
            // 
            this.groupBoxInfo.Controls.Add(this.btnLamMoi);
            this.groupBoxInfo.Controls.Add(this.btnXoa);
            this.groupBoxInfo.Controls.Add(this.btnSua);
            this.groupBoxInfo.Controls.Add(this.btnThem);
            this.groupBoxInfo.Controls.Add(this.txtSoDienThoai);
            this.groupBoxInfo.Controls.Add(this.lblSoDienThoai);
            this.groupBoxInfo.Controls.Add(this.txtTenKH);
            this.groupBoxInfo.Controls.Add(this.lblTenKH);
            this.groupBoxInfo.Controls.Add(this.txtMaKH);
            this.groupBoxInfo.Controls.Add(this.lblMaKH);
            this.groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(976, 180); // Kích thước rộng để chứa đủ nút
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.Text = "Thông tin khách hàng";

            // lblMaKH
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Location = new System.Drawing.Point(30, 60);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(100, 20);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng:";

            // txtMaKH
            this.txtMaKH.BorderRadius = 5;
            this.txtMaKH.Location = new System.Drawing.Point(150, 50);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(250, 36);
            this.txtMaKH.TabIndex = 1;

            // lblTenKH
            this.lblTenKH.BackColor = System.Drawing.Color.Transparent;
            this.lblTenKH.Location = new System.Drawing.Point(30, 110);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(100, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng:";

            // txtTenKH
            this.txtTenKH.BorderRadius = 5;
            this.txtTenKH.Location = new System.Drawing.Point(150, 100);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(250, 36);
            this.txtTenKH.TabIndex = 3;

            // lblSoDienThoai (Đặt bên phải MaKH)
            this.lblSoDienThoai.BackColor = System.Drawing.Color.Transparent;
            this.lblSoDienThoai.Location = new System.Drawing.Point(450, 60);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(90, 20);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại:";

            // txtSoDienThoai
            this.txtSoDienThoai.BorderRadius = 5;
            this.txtSoDienThoai.Location = new System.Drawing.Point(550, 50);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(250, 36);
            this.txtSoDienThoai.TabIndex = 5;

            // Các nút bấm (Sắp xếp hàng ngang bên dưới phần nhập liệu bên phải)
            // btnThem (Màu xanh lá)
            this.btnThem.BorderRadius = 5;
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(450, 100);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 36);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua (Màu xanh dương)
            this.btnSua.BorderRadius = 5;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(550, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa (Màu đỏ)
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(650, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi (Màu xám/xanh đen)
            this.btnLamMoi.BorderRadius = 5;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(750, 100);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 36);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // 
            // --- 2. GROUP BOX: TÌM KIẾM ---
            // 
            this.groupBoxSearch.Controls.Add(this.btn_timkiem);
            this.groupBoxSearch.Controls.Add(this.txtTimKiem);
            this.groupBoxSearch.Controls.Add(this.lblTuKhoa);
            this.groupBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 210);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(600, 100);
            this.groupBoxSearch.TabIndex = 1;
            this.groupBoxSearch.Text = "Tìm kiếm";

            // lblTuKhoa
            this.lblTuKhoa.BackColor = System.Drawing.Color.Transparent;
            this.lblTuKhoa.Location = new System.Drawing.Point(20, 55);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(80, 20);
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Nhập từ khóa:";

            // txtTimKiem
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Location = new System.Drawing.Point(120, 45);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 36);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // btn_timkiem
            this.btn_timkiem.BorderRadius = 5;
            this.btn_timkiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_timkiem.ForeColor = System.Drawing.Color.White;
            this.btn_timkiem.Location = new System.Drawing.Point(440, 45);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 36);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);

            // 
            // --- 3. GROUP BOX: CHUYỂN ĐỔI ---
            // 
            this.groupBoxConvert.Controls.Add(this.btn_chuyendoi);
            this.groupBoxConvert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxConvert.Location = new System.Drawing.Point(630, 210);
            this.groupBoxConvert.Name = "groupBoxConvert";
            this.groupBoxConvert.Size = new System.Drawing.Size(358, 100);
            this.groupBoxConvert.TabIndex = 2;
            this.groupBoxConvert.Text = "Chuyển đổi";

            // btn_chuyendoi (Html)
            this.btn_chuyendoi.BorderRadius = 5;
            this.btn_chuyendoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_chuyendoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_chuyendoi.ForeColor = System.Drawing.Color.White;
            this.btn_chuyendoi.Location = new System.Drawing.Point(30, 45);
            this.btn_chuyendoi.Name = "btn_chuyendoi";
            this.btn_chuyendoi.Size = new System.Drawing.Size(100, 36);
            this.btn_chuyendoi.TabIndex = 0;
            this.btn_chuyendoi.Text = "Html";
            this.btn_chuyendoi.Click += new System.EventHandler(this.btn_chuyendoi_Click);

            // 
            // --- 4. GROUP BOX: DANH SÁCH KHÁCH HÀNG (DATAGRIDVIEW) ---
            // 
            this.groupBoxList.Controls.Add(this.dgvKhachHang);
            this.groupBoxList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxList.Location = new System.Drawing.Point(12, 330);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(976, 400);
            this.groupBoxList.TabIndex = 3;
            this.groupBoxList.Text = "Danh sách khách hàng";

            // dgvKhachHang
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(3, 40); // Cách top để tránh đè lên tiêu đề GroupBox
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.Size = new System.Drawing.Size(970, 357);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);

            // 
            // --- CẤU HÌNH FORM CHÍNH ---
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxConvert);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyKhachHang";
            this.Text = "Quản lý khách hàng";

            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxConvert.ResumeLayout(false);
            this.groupBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}