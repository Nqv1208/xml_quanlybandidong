using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLyNhaCungCap
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvNCC;
        private Guna2TextBox txtMaNCC;
        private Guna2TextBox txtTenNCC;
        private Guna2TextBox txtDiaChi;
        private Guna2TextBox txtEmail;
        private Guna2TextBox txtTimKiem;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnLamMoi;
        private Guna2Button btnTimKiem;
        private Guna2GroupBox groupBoxInfo;
        private Guna2GroupBox groupBoxSearch;
        private Guna2GroupBox groupBoxGrid;
        private Guna2HtmlLabel lblMaNCC;
        private Guna2HtmlLabel lblTenNCC;
        private Guna2HtmlLabel lblDiaChi;
        private Guna2HtmlLabel lblSoDienThoai;
        private Guna2HtmlLabel lblEmail;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvNCC = new Guna2DataGridView();
            txtMaNCC = new Guna2TextBox();
            txtTenNCC = new Guna2TextBox();
            txtDiaChi = new Guna2TextBox();
            txtEmail = new Guna2TextBox();
            txtTimKiem = new Guna2TextBox();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnLamMoi = new Guna2Button();
            btnTimKiem = new Guna2Button();
            groupBoxInfo = new Guna2GroupBox();
            lblMaNCC = new Guna2HtmlLabel();
            lblTenNCC = new Guna2HtmlLabel();
            lblDiaChi = new Guna2HtmlLabel();
            lblSoDienThoai = new Guna2HtmlLabel();
            txtSoDienThoai = new Guna2TextBox();
            lblEmail = new Guna2HtmlLabel();
            groupBoxSearch = new Guna2GroupBox();
            lblTimKiem = new Guna2HtmlLabel();
            groupBoxGrid = new Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            groupBoxInfo.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxGrid.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNCC
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNCC.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNCC.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNCC.Dock = DockStyle.Fill;
            dgvNCC.GridColor = Color.FromArgb(231, 229, 255);
            dgvNCC.Location = new Point(0, 40);
            dgvNCC.Name = "dgvNCC";
            dgvNCC.ReadOnly = true;
            dgvNCC.RowHeadersVisible = false;
            dgvNCC.RowHeadersWidth = 62;
            dgvNCC.RowTemplate.Height = 33;
            dgvNCC.Size = new Size(776, 257);
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
            // txtMaNCC
            // 
            txtMaNCC.BorderRadius = 6;
            txtMaNCC.CustomizableEdges = customizableEdges1;
            txtMaNCC.DefaultText = "";
            txtMaNCC.Font = new Font("Segoe UI", 9F);
            txtMaNCC.Location = new Point(120, 45);
            txtMaNCC.Margin = new Padding(4, 5, 4, 5);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.PlaceholderText = "";
            txtMaNCC.SelectedText = "";
            txtMaNCC.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaNCC.Size = new Size(188, 36);
            txtMaNCC.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            txtTenNCC.BorderRadius = 6;
            txtTenNCC.CustomizableEdges = customizableEdges3;
            txtTenNCC.DefaultText = "";
            txtTenNCC.Font = new Font("Segoe UI", 9F);
            txtTenNCC.Location = new Point(120, 86);
            txtTenNCC.Margin = new Padding(4, 5, 4, 5);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.PlaceholderText = "";
            txtTenNCC.SelectedText = "";
            txtTenNCC.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTenNCC.Size = new Size(188, 36);
            txtTenNCC.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderRadius = 6;
            txtDiaChi.CustomizableEdges = customizableEdges5;
            txtDiaChi.DefaultText = "";
            txtDiaChi.Font = new Font("Segoe UI", 9F);
            txtDiaChi.Location = new Point(120, 132);
            txtDiaChi.Margin = new Padding(4, 5, 4, 5);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "";
            txtDiaChi.SelectedText = "";
            txtDiaChi.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDiaChi.Size = new Size(188, 36);
            txtDiaChi.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 6;
            txtEmail.CustomizableEdges = customizableEdges7;
            txtEmail.DefaultText = "";
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(482, 77);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEmail.Size = new Size(260, 36);
            txtEmail.TabIndex = 9;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 6;
            txtTimKiem.CustomizableEdges = customizableEdges9;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.Location = new Point(120, 38);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTimKiem.Size = new Size(342, 36);
            txtTimKiem.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BorderRadius = 6;
            btnThem.CustomizableEdges = customizableEdges11;
            btnThem.FillColor = Color.FromArgb(46, 125, 50);
            btnThem.Font = new Font("Segoe UI", 9F);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(354, 132);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnThem.Size = new Size(90, 36);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BorderRadius = 6;
            btnSua.CustomizableEdges = customizableEdges13;
            btnSua.FillColor = Color.FromArgb(25, 118, 210);
            btnSua.Font = new Font("Segoe UI", 9F);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(454, 132);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSua.Size = new Size(90, 36);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 6;
            btnXoa.CustomizableEdges = customizableEdges15;
            btnXoa.FillColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI", 9F);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(554, 132);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnXoa.Size = new Size(90, 36);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BorderRadius = 6;
            btnLamMoi.CustomizableEdges = customizableEdges17;
            btnLamMoi.FillColor = Color.FromArgb(103, 58, 183);
            btnLamMoi.Font = new Font("Segoe UI", 9F);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(654, 132);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnLamMoi.Size = new Size(90, 36);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BorderRadius = 6;
            btnTimKiem.CustomizableEdges = customizableEdges19;
            btnTimKiem.FillColor = Color.FromArgb(103, 58, 183);
            btnTimKiem.Font = new Font("Segoe UI", 9F);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(482, 38);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnTimKiem.Size = new Size(100, 36);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo.BorderRadius = 6;
            groupBoxInfo.Controls.Add(lblMaNCC);
            groupBoxInfo.Controls.Add(txtMaNCC);
            groupBoxInfo.Controls.Add(lblTenNCC);
            groupBoxInfo.Controls.Add(txtTenNCC);
            groupBoxInfo.Controls.Add(lblDiaChi);
            groupBoxInfo.Controls.Add(txtDiaChi);
            groupBoxInfo.Controls.Add(lblSoDienThoai);
            groupBoxInfo.Controls.Add(txtSoDienThoai);
            groupBoxInfo.Controls.Add(lblEmail);
            groupBoxInfo.Controls.Add(txtEmail);
            groupBoxInfo.Controls.Add(btnThem);
            groupBoxInfo.Controls.Add(btnSua);
            groupBoxInfo.Controls.Add(btnXoa);
            groupBoxInfo.Controls.Add(btnLamMoi);
            groupBoxInfo.CustomizableEdges = customizableEdges23;
            groupBoxInfo.Font = new Font("Segoe UI", 9F);
            groupBoxInfo.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxInfo.Location = new Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.ShadowDecoration.CustomizableEdges = customizableEdges24;
            groupBoxInfo.Size = new Size(776, 179);
            groupBoxInfo.TabIndex = 2;
            groupBoxInfo.Text = "Thông tin nhà cung cấp";
            // 
            // lblMaNCC
            // 
            lblMaNCC.BackColor = Color.Transparent;
            lblMaNCC.Location = new Point(20, 51);
            lblMaNCC.Name = "lblMaNCC";
            lblMaNCC.Size = new Size(60, 22);
            lblMaNCC.TabIndex = 0;
            lblMaNCC.Text = "Mã NCC:";
            // 
            // lblTenNCC
            // 
            lblTenNCC.BackColor = Color.Transparent;
            lblTenNCC.Location = new Point(20, 100);
            lblTenNCC.Name = "lblTenNCC";
            lblTenNCC.Size = new Size(63, 22);
            lblTenNCC.TabIndex = 2;
            lblTenNCC.Text = "Tên NCC:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.BackColor = Color.Transparent;
            lblDiaChi.Location = new Point(21, 146);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(52, 22);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.BackColor = Color.Transparent;
            lblSoDienThoai.Location = new Point(362, 40);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(94, 22);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderRadius = 6;
            txtSoDienThoai.CustomizableEdges = customizableEdges21;
            txtSoDienThoai.DefaultText = "";
            txtSoDienThoai.Font = new Font("Segoe UI", 9F);
            txtSoDienThoai.Location = new Point(482, 37);
            txtSoDienThoai.Margin = new Padding(4, 5, 4, 5);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "";
            txtSoDienThoai.SelectedText = "";
            txtSoDienThoai.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtSoDienThoai.Size = new Size(260, 36);
            txtSoDienThoai.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Location = new Point(362, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 22);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.BorderRadius = 6;
            groupBoxSearch.Controls.Add(lblTimKiem);
            groupBoxSearch.Controls.Add(txtTimKiem);
            groupBoxSearch.Controls.Add(btnTimKiem);
            groupBoxSearch.CustomizableEdges = customizableEdges25;
            groupBoxSearch.Font = new Font("Segoe UI", 9F);
            groupBoxSearch.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxSearch.Location = new Point(12, 198);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges26;
            groupBoxSearch.Size = new Size(776, 80);
            groupBoxSearch.TabIndex = 1;
            groupBoxSearch.Text = "Tìm kiếm";
            // 
            // lblTimKiem
            // 
            lblTimKiem.BackColor = Color.Transparent;
            lblTimKiem.Location = new Point(21, 45);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(59, 22);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Từ khóa:";
            // 
            // groupBoxGrid
            // 
            groupBoxGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxGrid.BorderRadius = 6;
            groupBoxGrid.Controls.Add(dgvNCC);
            groupBoxGrid.CustomizableEdges = customizableEdges27;
            groupBoxGrid.Font = new Font("Segoe UI", 9F);
            groupBoxGrid.ForeColor = Color.FromArgb(125, 137, 149);
            groupBoxGrid.Location = new Point(12, 284);
            groupBoxGrid.Name = "groupBoxGrid";
            groupBoxGrid.ShadowDecoration.CustomizableEdges = customizableEdges28;
            groupBoxGrid.Size = new Size(776, 297);
            groupBoxGrid.TabIndex = 0;
            groupBoxGrid.Text = "Danh sách nhà cung cấp";
            // 
            // frmQuanLyNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(groupBoxGrid);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxGrid.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Guna2TextBox txtSoDienThoai;
    }
}

