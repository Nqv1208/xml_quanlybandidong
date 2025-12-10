using Guna.UI2.WinForms;

namespace QuanLyBanDienThoai.GUI
{
    partial class frmQuanLyHangSanXuat
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2DataGridView dgvHangSanXuat;
        private Guna2HtmlLabel lblMaHang;
        private Guna2HtmlLabel lblTenHang;
        private Guna2TextBox txtMaHang;
        private Guna2TextBox txtTenHang;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnLamMoi;
        private Guna2GroupBox groupBox1;
        private Guna2GroupBox groupBox2;
        private Guna2Panel panelButtons;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvHangSanXuat = new Guna2DataGridView();
            lblMaHang = new Guna2HtmlLabel();
            lblTenHang = new Guna2HtmlLabel();
            txtMaHang = new Guna2TextBox();
            txtTenHang = new Guna2TextBox();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnLamMoi = new Guna2Button();
            groupBox1 = new Guna2GroupBox();
            panelButtons = new Guna2Panel();
            groupBox2 = new Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvHangSanXuat).BeginInit();
            groupBox1.SuspendLayout();
            panelButtons.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHangSanXuat
            // 
            dgvHangSanXuat.AllowUserToAddRows = false;
            dgvHangSanXuat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvHangSanXuat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHangSanXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHangSanXuat.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHangSanXuat.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHangSanXuat.Dock = DockStyle.Fill;
            dgvHangSanXuat.GridColor = Color.FromArgb(231, 229, 255);
            dgvHangSanXuat.Location = new Point(0, 40);
            dgvHangSanXuat.Margin = new Padding(3, 2, 3, 2);
            dgvHangSanXuat.Name = "dgvHangSanXuat";
            dgvHangSanXuat.ReadOnly = true;
            dgvHangSanXuat.RowHeadersVisible = false;
            dgvHangSanXuat.RowHeadersWidth = 51;
            dgvHangSanXuat.RowTemplate.Height = 29;
            dgvHangSanXuat.Size = new Size(972, 437);
            dgvHangSanXuat.TabIndex = 0;
            dgvHangSanXuat.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHangSanXuat.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHangSanXuat.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHangSanXuat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHangSanXuat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHangSanXuat.ThemeStyle.BackColor = Color.White;
            dgvHangSanXuat.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHangSanXuat.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHangSanXuat.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHangSanXuat.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F);
            dgvHangSanXuat.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHangSanXuat.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHangSanXuat.ThemeStyle.HeaderStyle.Height = 30;
            dgvHangSanXuat.ThemeStyle.ReadOnly = true;
            dgvHangSanXuat.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHangSanXuat.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHangSanXuat.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F);
            dgvHangSanXuat.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHangSanXuat.ThemeStyle.RowsStyle.Height = 29;
            dgvHangSanXuat.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHangSanXuat.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvHangSanXuat.CellClick += dgvHangSanXuat_CellClick;
            // 
            // lblMaHang
            // 
            lblMaHang.BackColor = Color.Transparent;
            lblMaHang.Font = new Font("Segoe UI", 10F);
            lblMaHang.ForeColor = Color.Black;
            lblMaHang.Location = new Point(20, 54);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(84, 30);
            lblMaHang.TabIndex = 0;
            lblMaHang.Text = "Mã hãng:";
            // 
            // lblTenHang
            // 
            lblTenHang.BackColor = Color.Transparent;
            lblTenHang.Font = new Font("Segoe UI", 10F);
            lblTenHang.ForeColor = Color.Black;
            lblTenHang.Location = new Point(20, 110);
            lblTenHang.Name = "lblTenHang";
            lblTenHang.Size = new Size(87, 30);
            lblTenHang.TabIndex = 1;
            lblTenHang.Text = "Tên hãng:";
            lblTenHang.Click += lblTenHang_Click;
            // 
            // txtMaHang
            // 
            txtMaHang.BorderRadius = 5;
            txtMaHang.CustomizableEdges = customizableEdges1;
            txtMaHang.DefaultText = "";
            txtMaHang.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaHang.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaHang.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaHang.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaHang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaHang.Font = new Font("Segoe UI", 10F);
            txtMaHang.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaHang.Location = new Point(130, 53);
            txtMaHang.Margin = new Padding(3, 2, 3, 2);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.PlaceholderText = "";
            txtMaHang.SelectedText = "";
            txtMaHang.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMaHang.Size = new Size(300, 43);
            txtMaHang.TabIndex = 2;
            txtMaHang.TextChanged += txtMaHang_TextChanged;
            // 
            // txtTenHang
            // 
            txtTenHang.BorderRadius = 5;
            txtTenHang.CustomizableEdges = customizableEdges3;
            txtTenHang.DefaultText = "";
            txtTenHang.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenHang.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenHang.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenHang.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenHang.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenHang.Font = new Font("Segoe UI", 10F);
            txtTenHang.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenHang.Location = new Point(130, 110);
            txtTenHang.Margin = new Padding(3, 2, 3, 2);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.PlaceholderText = "";
            txtTenHang.SelectedText = "";
            txtTenHang.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTenHang.Size = new Size(450, 43);
            txtTenHang.TabIndex = 3;
            // 
            // btnThem
            // 
            btnThem.Animated = true;
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderRadius = 8;
            btnThem.CustomizableEdges = customizableEdges5;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.FromArgb(46, 125, 50);
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(10, 10);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.BorderRadius = 8;
            btnThem.ShadowDecoration.Color = Color.FromArgb(46, 125, 50);
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnThem.ShadowDecoration.Depth = 5;
            btnThem.ShadowDecoration.Enabled = true;
            btnThem.Size = new Size(125, 45);
            btnThem.TabIndex = 4;
            btnThem.Text = "➕ Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Animated = true;
            btnSua.BackColor = Color.Transparent;
            btnSua.BorderRadius = 8;
            btnSua.CustomizableEdges = customizableEdges7;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.FromArgb(25, 118, 210);
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(175, 10);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.BorderRadius = 8;
            btnSua.ShadowDecoration.Color = Color.FromArgb(25, 118, 210);
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSua.ShadowDecoration.Depth = 5;
            btnSua.ShadowDecoration.Enabled = true;
            btnSua.Size = new Size(125, 45);
            btnSua.TabIndex = 5;
            btnSua.Text = "✏️ Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Animated = true;
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BorderRadius = 8;
            btnXoa.CustomizableEdges = customizableEdges9;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(10, 67);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.BorderRadius = 8;
            btnXoa.ShadowDecoration.Color = Color.FromArgb(211, 47, 47);
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnXoa.ShadowDecoration.Depth = 5;
            btnXoa.ShadowDecoration.Enabled = true;
            btnXoa.Size = new Size(125, 45);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Animated = true;
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.BorderRadius = 8;
            btnLamMoi.CustomizableEdges = customizableEdges11;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.FillColor = Color.FromArgb(158, 158, 158);
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(175, 67);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.BorderRadius = 8;
            btnLamMoi.ShadowDecoration.Color = Color.FromArgb(158, 158, 158);
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLamMoi.ShadowDecoration.Depth = 5;
            btnLamMoi.ShadowDecoration.Enabled = true;
            btnLamMoi.Size = new Size(125, 45);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelButtons);
            groupBox1.Controls.Add(txtTenHang);
            groupBox1.Controls.Add(txtMaHang);
            groupBox1.Controls.Add(lblTenHang);
            groupBox1.Controls.Add(lblMaHang);
            groupBox1.CustomizableEdges = customizableEdges15;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            groupBox1.Size = new Size(972, 180);
            groupBox1.TabIndex = 0;
            groupBox1.Text = "Thông tin hãng sản xuất";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnLamMoi);
            panelButtons.Controls.Add(btnXoa);
            panelButtons.Controls.Add(btnSua);
            panelButtons.Controls.Add(btnThem);
            panelButtons.CustomizableEdges = customizableEdges13;
            panelButtons.Location = new Point(639, 43);
            panelButtons.Name = "panelButtons";
            panelButtons.ShadowDecoration.CustomizableEdges = customizableEdges14;
            panelButtons.Size = new Size(310, 130);
            panelButtons.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHangSanXuat);
            groupBox2.CustomizableEdges = customizableEdges17;
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(125, 137, 149);
            groupBox2.Location = new Point(15, 211);
            groupBox2.Name = "groupBox2";
            groupBox2.ShadowDecoration.CustomizableEdges = customizableEdges18;
            groupBox2.Size = new Size(972, 477);
            groupBox2.TabIndex = 1;
            groupBox2.Text = "Danh sách hãng sản xuất";
            // 
            // frmQuanLyHangSanXuat
            // 
            BackColor = Color.FromArgb(242, 254, 250);
            ClientSize = new Size(1000, 701);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(948, 687);
            Name = "frmQuanLyHangSanXuat";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hãng sản xuất";
            Load += frmQuanLyHangSanXuat_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHangSanXuat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelButtons.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
