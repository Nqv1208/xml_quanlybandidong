namespace QuanLyBanDienThoai.GUI
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // --- KHAI BÁO CONTROL GUNA.UI2 ---
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;

        // Panel Bên Phải (Gradient)
        private Guna.UI2.WinForms.Guna2GradientPanel pnlRight;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSlogan;
        private Guna.UI2.WinForms.Guna2ControlBox btnThoat; // Nút X

        // Panel Bên Trái (Form)
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;

        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swGhiNho;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGhiNho;

        // Đổi sang GradientButton cho màu tươi hơn
        private Guna.UI2.WinForms.Guna2GradientButton btnDangNhap;

        private System.Windows.Forms.LinkLabel linkQuenMatKhau;
        private System.Windows.Forms.LinkLabel linkDangKy;

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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            linkDangKy = new LinkLabel();
            linkQuenMatKhau = new LinkLabel();
            btnDangNhap = new Guna.UI2.WinForms.Guna2GradientButton();
            lblGhiNho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            swGhiNho = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            pnlRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblSlogan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnThoat = new Guna.UI2.WinForms.Guna2ControlBox();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // shadowForm
            // 
            shadowForm.TargetForm = this;
            // 
            // dragControl
            // 
            dragControl.DockIndicatorTransparencyValue = 0.6D;
            dragControl.TargetControl = pnlLeft;
            dragControl.UseTransparentDrag = true;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(linkDangKy);
            pnlLeft.Controls.Add(linkQuenMatKhau);
            pnlLeft.Controls.Add(btnDangNhap);
            pnlLeft.Controls.Add(lblGhiNho);
            pnlLeft.Controls.Add(swGhiNho);
            pnlLeft.Controls.Add(txtMatKhau);
            pnlLeft.Controls.Add(txtTenDangNhap);
            pnlLeft.Controls.Add(lblTitle);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Controls.Add(picLogo);
            pnlLeft.CustomizableEdges = customizableEdges11;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(4, 5, 4, 5);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnlLeft.Size = new Size(475, 781);
            pnlLeft.TabIndex = 0;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            linkDangKy.LinkColor = Color.FromArgb(0, 114, 255);
            linkDangKy.Location = new Point(252, 616);
            linkDangKy.Margin = new Padding(4, 0, 4, 0);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new Size(156, 23);
            linkDangKy.TabIndex = 6;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Tạo tài khoản mới";
            // 
            // linkQuenMatKhau
            // 
            linkQuenMatKhau.AutoSize = true;
            linkQuenMatKhau.LinkColor = Color.Gray;
            linkQuenMatKhau.Location = new Point(56, 614);
            linkQuenMatKhau.Margin = new Padding(4, 0, 4, 0);
            linkQuenMatKhau.Name = "linkQuenMatKhau";
            linkQuenMatKhau.Size = new Size(142, 25);
            linkQuenMatKhau.TabIndex = 5;
            linkQuenMatKhau.TabStop = true;
            linkQuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BorderRadius = 20;
            btnDangNhap.CustomizableEdges = customizableEdges1;
            btnDangNhap.FillColor = Color.FromArgb(0, 198, 255);
            btnDangNhap.FillColor2 = Color.FromArgb(0, 114, 255);
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(50, 516);
            btnDangNhap.Margin = new Padding(4, 5, 4, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDangNhap.Size = new Size(375, 70);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lblGhiNho
            // 
            lblGhiNho.BackColor = Color.Transparent;
            lblGhiNho.Font = new Font("Segoe UI", 9F);
            lblGhiNho.Location = new Point(108, 438);
            lblGhiNho.Margin = new Padding(4, 5, 4, 5);
            lblGhiNho.Name = "lblGhiNho";
            lblGhiNho.Size = new Size(156, 27);
            lblGhiNho.TabIndex = 7;
            lblGhiNho.Text = "Ghi nhớ đăng nhập";
            // 
            // swGhiNho
            // 
            swGhiNho.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            swGhiNho.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            swGhiNho.CustomizableEdges = customizableEdges3;
            swGhiNho.Location = new Point(56, 438);
            swGhiNho.Margin = new Padding(4, 5, 4, 5);
            swGhiNho.Name = "swGhiNho";
            swGhiNho.ShadowDecoration.CustomizableEdges = customizableEdges4;
            swGhiNho.Size = new Size(44, 31);
            swGhiNho.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderRadius = 18;
            txtMatKhau.CustomizableEdges = customizableEdges5;
            txtMatKhau.DefaultText = "";
            txtMatKhau.FillColor = Color.FromArgb(240, 242, 245);
            txtMatKhau.Font = new Font("Segoe UI", 9F);
            txtMatKhau.Location = new Point(50, 315);
            txtMatKhau.Margin = new Padding(5, 8, 5, 8);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.PlaceholderText = "Mật khẩu";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMatKhau.Size = new Size(375, 62);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.TextOffset = new Point(10, 0);
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderRadius = 18;
            txtTenDangNhap.CustomizableEdges = customizableEdges7;
            txtTenDangNhap.DefaultText = "";
            txtTenDangNhap.FillColor = Color.FromArgb(240, 242, 245);
            txtTenDangNhap.Font = new Font("Segoe UI", 9F);
            txtTenDangNhap.Location = new Point(50, 221);
            txtTenDangNhap.Margin = new Padding(5, 8, 5, 8);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tên đăng nhập";
            txtTenDangNhap.SelectedText = "";
            txtTenDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTenDangNhap.Size = new Size(375, 62);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.TextOffset = new Point(10, 0);
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 118, 215);
            lblTitle.Location = new Point(192, 50);
            lblTitle.Margin = new Padding(4, 5, 4, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 50);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Mobile Shop";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Gray;
            lblWelcome.Location = new Point(48, 57);
            lblWelcome.Margin = new Padding(4, 5, 4, 5);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(137, 34);
            lblWelcome.TabIndex = 9;
            lblWelcome.Text = "Welcome To";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.CustomizableEdges = customizableEdges9;
            picLogo.ImageRotate = 0F;
            picLogo.Location = new Point(175, 62);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            picLogo.Size = new Size(100, 125);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = SystemColors.ControlLight;
            pnlRight.BackgroundImage = Properties.Resources.phong_cach_thiet_ke_shop_dien_thoai_161;
            pnlRight.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRight.Controls.Add(lblSlogan);
            pnlRight.Controls.Add(btnThoat);
            pnlRight.CustomizableEdges = customizableEdges15;
            pnlRight.Dock = DockStyle.Right;
            pnlRight.ForeColor = SystemColors.ControlLightLight;
            pnlRight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            pnlRight.Location = new Point(473, 0);
            pnlRight.Margin = new Padding(4, 5, 4, 5);
            pnlRight.Name = "pnlRight";
            pnlRight.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlRight.Size = new Size(589, 781);
            pnlRight.TabIndex = 1;
            pnlRight.Paint += pnlRight_Paint;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = false;
            lblSlogan.BackColor = Color.Transparent;
            lblSlogan.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(50, 578);
            lblSlogan.Margin = new Padding(4, 5, 4, 5);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(500, 125);
            lblSlogan.TabIndex = 0;
            lblSlogan.Text = "Smart Phone, <br>Smart Life.";
            lblSlogan.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.BorderColor = Color.Empty;
            btnThoat.BorderRadius = 15;
            btnThoat.CustomizableEdges = customizableEdges13;
            btnThoat.FillColor = Color.FromArgb(255, 100, 100);
            btnThoat.HoverState.FillColor = Color.Red;
            btnThoat.IconColor = Color.White;
            btnThoat.Location = new Point(539, 14);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnThoat.Size = new Size(37, 36);
            btnThoat.TabIndex = 2;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 781);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}