namespace QuanLyBanDienThoai.GUI
{
    partial class frmChiTietHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBoxInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            lblTongTien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNgayLap = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNhanVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblKhach = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblMaHD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            groupBoxChiTiet = new Guna.UI2.WinForms.Guna2GroupBox();
            dgvChiTiet = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDong = new Guna.UI2.WinForms.Guna2Button();
            groupBoxInfo.SuspendLayout();
            groupBoxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo.BorderRadius = 6;
            groupBoxInfo.Controls.Add(lblTongTien);
            groupBoxInfo.Controls.Add(lblNgayLap);
            groupBoxInfo.Controls.Add(lblNhanVien);
            groupBoxInfo.Controls.Add(lblKhach);
            groupBoxInfo.Controls.Add(lblMaHD);
            groupBoxInfo.CustomizableEdges = customizableEdges1;
            groupBoxInfo.Font = new Font("Segoe UI", 9F);
            groupBoxInfo.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            groupBoxInfo.Size = new Size(776, 96);
            groupBoxInfo.TabIndex = 3;
            groupBoxInfo.Text = "Thông tin hoá đơn";
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.Transparent;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(211, 47, 47);
            lblTongTien.Location = new Point(516, 43);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(136, 30);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // lblNgayLap
            // 
            lblNgayLap.BackColor = Color.Transparent;
            lblNgayLap.Font = new Font("Segoe UI", 10F);
            lblNgayLap.Location = new Point(291, 64);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(127, 25);
            lblNgayLap.TabIndex = 3;
            lblNgayLap.Text = "Ngày nhập: N/A";
            // 
            // lblNhanVien
            // 
            lblNhanVien.BackColor = Color.Transparent;
            lblNhanVien.Font = new Font("Segoe UI", 10F);
            lblNhanVien.Location = new Point(291, 40);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(147, 25);
            lblNhanVien.TabIndex = 2;
            lblNhanVien.Text = "Mã nhân viên: N/A";
            // 
            // lblKhach
            // 
            lblKhach.BackColor = Color.Transparent;
            lblKhach.Font = new Font("Segoe UI", 10F);
            lblKhach.ForeColor = Color.Black;
            lblKhach.Location = new Point(20, 64);
            lblKhach.Name = "lblKhach";
            lblKhach.Size = new Size(165, 25);
            lblKhach.TabIndex = 1;
            lblKhach.Text = "Tên khách hàng: N/A";
            // 
            // lblMaHD
            // 
            lblMaHD.BackColor = Color.Transparent;
            lblMaHD.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaHD.ForeColor = Color.FromArgb(100, 88, 255);
            lblMaHD.Location = new Point(20, 40);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(165, 25);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã hoá đơn: HD001";
            // 
            // groupBoxChiTiet
            // 
            groupBoxChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxChiTiet.BorderRadius = 6;
            groupBoxChiTiet.Controls.Add(dgvChiTiet);
            groupBoxChiTiet.CustomizableEdges = customizableEdges3;
            groupBoxChiTiet.Font = new Font("Segoe UI", 9F);
            groupBoxChiTiet.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxChiTiet.Location = new Point(12, 116);
            groupBoxChiTiet.Name = "groupBoxChiTiet";
            groupBoxChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges4;
            groupBoxChiTiet.Size = new Size(776, 297);
            groupBoxChiTiet.TabIndex = 4;
            groupBoxChiTiet.Text = "Chi tiết hoá đơn";
            // 
            // dgvChiTiet
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTiet.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.GridColor = Color.FromArgb(231, 229, 255);
            dgvChiTiet.Location = new Point(0, 40);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 62;
            dgvChiTiet.RowTemplate.Height = 33;
            dgvChiTiet.Size = new Size(776, 257);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvChiTiet.ThemeStyle.BackColor = Color.White;
            dgvChiTiet.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvChiTiet.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvChiTiet.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChiTiet.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvChiTiet.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvChiTiet.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChiTiet.ThemeStyle.HeaderStyle.Height = 30;
            dgvChiTiet.ThemeStyle.ReadOnly = true;
            dgvChiTiet.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvChiTiet.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiTiet.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvChiTiet.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvChiTiet.ThemeStyle.RowsStyle.Height = 33;
            dgvChiTiet.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvChiTiet.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDong.Animated = true;
            btnDong.BorderRadius = 6;
            btnDong.CustomizableEdges = customizableEdges5;
            btnDong.FillColor = Color.FromArgb(52, 73, 94);
            btnDong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.ForeColor = Color.White;
            btnDong.HoverState.FillColor = Color.FromArgb(44, 62, 80);
            btnDong.HoverState.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.HoverState.ForeColor = Color.White;
            btnDong.Location = new Point(680, 435);
            btnDong.Name = "btnDong";
            btnDong.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDong.Size = new Size(108, 36);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.Click += btnDong_Click;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 511);
            Controls.Add(groupBoxInfo);
            Controls.Add(groupBoxChiTiet);
            Controls.Add(btnDong);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChiTietHoaDon";
            Text = "frmChiTietHoaDon";
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBoxInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayLap;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKhach;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaHD;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxChiTiet;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTiet;
        private Guna.UI2.WinForms.Guna2Button btnDong;
    }
}