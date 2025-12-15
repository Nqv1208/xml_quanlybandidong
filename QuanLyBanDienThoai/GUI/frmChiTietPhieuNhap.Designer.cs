using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmChiTietPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2GroupBox groupBoxInfo;
        private Guna2GroupBox groupBoxChiTiet;
        private Guna2DataGridView dgvChiTiet;
        private Guna2HtmlLabel lblMaPN;
        private Guna2HtmlLabel lblTenNCC;
        private Guna2HtmlLabel lblMaNV;
        private Guna2HtmlLabel lblNgayNhap;
        private Guna2HtmlLabel lblTongTien;
        private Guna2Button btnDong;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBoxInfo = new Guna2GroupBox();
            lblTongTien = new Guna2HtmlLabel();
            lblNgayNhap = new Guna2HtmlLabel();
            lblMaNV = new Guna2HtmlLabel();
            lblTenNCC = new Guna2HtmlLabel();
            lblMaPN = new Guna2HtmlLabel();
            groupBoxChiTiet = new Guna2GroupBox();
            dgvChiTiet = new Guna2DataGridView();
            btnDong = new Guna2Button();
            btnHtml = new Guna2Button();
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
            groupBoxInfo.Controls.Add(lblNgayNhap);
            groupBoxInfo.Controls.Add(lblMaNV);
            groupBoxInfo.Controls.Add(lblTenNCC);
            groupBoxInfo.Controls.Add(lblMaPN);
            groupBoxInfo.CustomizableEdges = customizableEdges1;
            groupBoxInfo.Font = new Font("Segoe UI", 9F);
            groupBoxInfo.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxInfo.Location = new Point(15, 15);
            groupBoxInfo.Margin = new Padding(4);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            groupBoxInfo.Size = new Size(970, 120);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.Text = "Thông tin phiếu nhập";
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.Transparent;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(211, 47, 47);
            lblTongTien.Location = new Point(612, 50);
            lblTongTien.Margin = new Padding(4);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(163, 34);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.BackColor = Color.Transparent;
            lblNgayNhap.Font = new Font("Segoe UI", 10F);
            lblNgayNhap.Location = new Point(364, 80);
            lblNgayNhap.Margin = new Padding(4);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(144, 30);
            lblNgayNhap.TabIndex = 3;
            lblNgayNhap.Text = "Ngày nhập: N/A";
            // 
            // lblMaNV
            // 
            lblMaNV.BackColor = Color.Transparent;
            lblMaNV.Font = new Font("Segoe UI", 10F);
            lblMaNV.Location = new Point(364, 50);
            lblMaNV.Margin = new Padding(4);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(165, 30);
            lblMaNV.TabIndex = 2;
            lblMaNV.Text = "Mã nhân viên: N/A";
            // 
            // lblTenNCC
            // 
            lblTenNCC.BackColor = Color.Transparent;
            lblTenNCC.Font = new Font("Segoe UI", 10F);
            lblTenNCC.Location = new Point(25, 80);
            lblTenNCC.Margin = new Padding(4);
            lblTenNCC.Name = "lblTenNCC";
            lblTenNCC.Size = new Size(168, 30);
            lblTenNCC.TabIndex = 1;
            lblTenNCC.Text = "Nhà cung cấp: N/A";
            // 
            // lblMaPN
            // 
            lblMaPN.BackColor = Color.Transparent;
            lblMaPN.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMaPN.ForeColor = Color.FromArgb(100, 88, 255);
            lblMaPN.Location = new Point(25, 50);
            lblMaPN.Margin = new Padding(4);
            lblMaPN.Name = "lblMaPN";
            lblMaPN.Size = new Size(220, 30);
            lblMaPN.TabIndex = 0;
            lblMaPN.Text = "Mã phiếu nhập: PN001";
            // 
            // groupBoxChiTiet
            // 
            groupBoxChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxChiTiet.BorderRadius = 6;
            groupBoxChiTiet.Controls.Add(dgvChiTiet);
            groupBoxChiTiet.CustomizableEdges = customizableEdges3;
            groupBoxChiTiet.Font = new Font("Segoe UI", 9F);
            groupBoxChiTiet.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxChiTiet.Location = new Point(15, 145);
            groupBoxChiTiet.Margin = new Padding(4);
            groupBoxChiTiet.Name = "groupBoxChiTiet";
            groupBoxChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges4;
            groupBoxChiTiet.Size = new Size(970, 580);
            groupBoxChiTiet.TabIndex = 1;
            groupBoxChiTiet.Text = "Chi tiết phiếu nhập";
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
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.GridColor = Color.FromArgb(231, 229, 255);
            dgvChiTiet.Location = new Point(0, 40);
            dgvChiTiet.Margin = new Padding(4);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 62;
            dgvChiTiet.Size = new Size(970, 540);
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
            btnDong.BorderRadius = 6;
            btnDong.CustomizableEdges = customizableEdges5;
            btnDong.FillColor = Color.FromArgb(52, 73, 94);
            btnDong.Font = new Font("Segoe UI", 9F);
            btnDong.ForeColor = Color.White;
            btnDong.HoverState.FillColor = Color.FromArgb(44, 62, 80);
            btnDong.Location = new Point(850, 737);
            btnDong.Margin = new Padding(4);
            btnDong.Name = "btnDong";
            btnDong.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDong.Size = new Size(135, 45);
            btnDong.TabIndex = 2;
            btnDong.Text = "Đóng";
            btnDong.Click += btnDong_Click;
            // 
            // btnHtml
            // 
            btnHtml.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnHtml.BorderRadius = 6;
            btnHtml.CustomizableEdges = customizableEdges7;
            btnHtml.FillColor = Color.FromArgb(52, 73, 94);
            btnHtml.Font = new Font("Segoe UI", 9F);
            btnHtml.ForeColor = Color.White;
            btnHtml.HoverState.FillColor = Color.FromArgb(44, 62, 80);
            btnHtml.Location = new Point(691, 737);
            btnHtml.Margin = new Padding(4);
            btnHtml.Name = "btnHtml";
            btnHtml.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnHtml.Size = new Size(135, 45);
            btnHtml.TabIndex = 3;
            btnHtml.Text = "Html";
            btnHtml.Click += btnHtml_Click;
            // 
            // frmChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 795);
            Controls.Add(btnHtml);
            Controls.Add(btnDong);
            Controls.Add(groupBoxChiTiet);
            Controls.Add(groupBoxInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmChiTietPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }
        private Guna2Button btnHtml;
    }
}

