namespace QuanLyBanDienThoai.GUI
{
    partial class FormQuenMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // --- KHAI BÁO CONTROL GUNA.UI2 ---
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;

        // Panel Phải (Branding)
        private Guna.UI2.WinForms.Guna2GradientPanel pnlRight;
        private Guna.UI2.WinForms.Guna2PictureBox picBackground;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSlogan;
        private Guna.UI2.WinForms.Guna2ControlBox btnThoat; // Nút X

        // Panel Trái (Form chính)
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubTitle;

        // Giai đoạn 1: Nhập Email
        private Guna.UI2.WinForms.Guna2TextBox txtNhapEmail;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuiMa;

        // Giai đoạn 2: Panel Đặt Mật Khẩu (Chứa OTP và Pass mới)
        private Guna.UI2.WinForms.Guna2Panel pnlDatMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMaOTP;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiMatKhau;
        private Guna.UI2.WinForms.Guna2GradientButton btnXacNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            dragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            pnlDatMatKhau = new Guna.UI2.WinForms.Guna2Panel();
            btnXacNhan = new Guna.UI2.WinForms.Guna2GradientButton();
            txtNhapLaiMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaOTP = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label4 = new Label();
            btnGuiMa = new Guna.UI2.WinForms.Guna2GradientButton();
            txtNhapEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblSubTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlRight = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblSlogan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnThoat = new Guna.UI2.WinForms.Guna2ControlBox();
            picBackground = new Guna.UI2.WinForms.Guna2PictureBox();
            pnlLeft.SuspendLayout();
            pnlDatMatKhau.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
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
            pnlLeft.Controls.Add(pnlDatMatKhau);
            pnlLeft.Controls.Add(btnGuiMa);
            pnlLeft.Controls.Add(txtNhapEmail);
            pnlLeft.Controls.Add(lblSubTitle);
            pnlLeft.Controls.Add(lblTitle);
            pnlLeft.CustomizableEdges = customizableEdges15;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(4, 5, 4, 5);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pnlLeft.Size = new Size(562, 938);
            pnlLeft.TabIndex = 0;
            // 
            // pnlDatMatKhau
            // 
            pnlDatMatKhau.BackColor = Color.Transparent;
            pnlDatMatKhau.Controls.Add(btnXacNhan);
            pnlDatMatKhau.Controls.Add(txtNhapLaiMatKhau);
            pnlDatMatKhau.Controls.Add(txtMatKhauMoi);
            pnlDatMatKhau.Controls.Add(txtMaOTP);
            pnlDatMatKhau.Controls.Add(label3);
            pnlDatMatKhau.Controls.Add(label4);
            pnlDatMatKhau.CustomizableEdges = customizableEdges9;
            pnlDatMatKhau.Location = new Point(38, 447);
            pnlDatMatKhau.Margin = new Padding(4, 5, 4, 5);
            pnlDatMatKhau.Name = "pnlDatMatKhau";
            pnlDatMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlDatMatKhau.Size = new Size(462, 453);
            pnlDatMatKhau.TabIndex = 3;
            pnlDatMatKhau.Visible = false;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BorderRadius = 20;
            btnXacNhan.CustomizableEdges = customizableEdges1;
            btnXacNhan.FillColor = Color.FromArgb(46, 204, 113);
            btnXacNhan.FillColor2 = Color.FromArgb(39, 174, 96);
            btnXacNhan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnXacNhan.ForeColor = Color.White;
            btnXacNhan.Location = new Point(31, 281);
            btnXacNhan.Margin = new Padding(4, 5, 4, 5);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnXacNhan.Size = new Size(400, 70);
            btnXacNhan.TabIndex = 3;
            btnXacNhan.Text = "XÁC NHẬN ĐỔI MẬT KHẨU";
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.BorderRadius = 15;
            txtNhapLaiMatKhau.CustomizableEdges = customizableEdges3;
            txtNhapLaiMatKhau.DefaultText = "";
            txtNhapLaiMatKhau.FillColor = Color.FromArgb(240, 242, 245);
            txtNhapLaiMatKhau.Font = new Font("Segoe UI", 9F);
            txtNhapLaiMatKhau.Location = new Point(31, 188);
            txtNhapLaiMatKhau.Margin = new Padding(5, 8, 5, 8);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.PasswordChar = '●';
            txtNhapLaiMatKhau.PlaceholderText = "Xác nhận mật khẩu";
            txtNhapLaiMatKhau.SelectedText = "";
            txtNhapLaiMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNhapLaiMatKhau.Size = new Size(400, 62);
            txtNhapLaiMatKhau.TabIndex = 2;
            txtNhapLaiMatKhau.TextOffset = new Point(10, 0);
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.BorderRadius = 15;
            txtMatKhauMoi.CustomizableEdges = customizableEdges5;
            txtMatKhauMoi.DefaultText = "";
            txtMatKhauMoi.FillColor = Color.FromArgb(240, 242, 245);
            txtMatKhauMoi.Font = new Font("Segoe UI", 9F);
            txtMatKhauMoi.Location = new Point(31, 102);
            txtMatKhauMoi.Margin = new Padding(5, 8, 5, 8);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '●';
            txtMatKhauMoi.PlaceholderText = "Mật khẩu mới";
            txtMatKhauMoi.SelectedText = "";
            txtMatKhauMoi.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMatKhauMoi.Size = new Size(400, 62);
            txtMatKhauMoi.TabIndex = 1;
            txtMatKhauMoi.TextOffset = new Point(10, 0);
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtMaOTP
            // 
            txtMaOTP.BorderRadius = 15;
            txtMaOTP.CustomizableEdges = customizableEdges7;
            txtMaOTP.DefaultText = "";
            txtMaOTP.FillColor = Color.FromArgb(240, 242, 245);
            txtMaOTP.Font = new Font("Segoe UI", 9F);
            txtMaOTP.Location = new Point(31, 16);
            txtMaOTP.Margin = new Padding(5, 8, 5, 8);
            txtMaOTP.Name = "txtMaOTP";
            txtMaOTP.PlaceholderText = "Nhập mã OTP (6 số)";
            txtMaOTP.SelectedText = "";
            txtMaOTP.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtMaOTP.Size = new Size(400, 62);
            txtMaOTP.TabIndex = 0;
            txtMaOTP.TextOffset = new Point(10, 0);
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 36);
            label3.TabIndex = 99;
            label3.Visible = false;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 36);
            label4.TabIndex = 99;
            label4.Visible = false;
            // 
            // btnGuiMa
            // 
            btnGuiMa.BorderRadius = 20;
            btnGuiMa.CustomizableEdges = customizableEdges11;
            btnGuiMa.FillColor = Color.FromArgb(0, 198, 255);
            btnGuiMa.FillColor2 = Color.FromArgb(0, 114, 255);
            btnGuiMa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuiMa.ForeColor = Color.White;
            btnGuiMa.Location = new Point(69, 361);
            btnGuiMa.Margin = new Padding(4, 5, 4, 5);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnGuiMa.Size = new Size(400, 70);
            btnGuiMa.TabIndex = 2;
            btnGuiMa.Text = "GỬI MÃ XÁC NHẬN";
            // 
            // txtNhapEmail
            // 
            txtNhapEmail.BorderRadius = 15;
            txtNhapEmail.CustomizableEdges = customizableEdges13;
            txtNhapEmail.DefaultText = "";
            txtNhapEmail.FillColor = Color.FromArgb(240, 242, 245);
            txtNhapEmail.Font = new Font("Segoe UI", 9F);
            txtNhapEmail.Location = new Point(69, 275);
            txtNhapEmail.Margin = new Padding(5, 8, 5, 8);
            txtNhapEmail.Name = "txtNhapEmail";
            txtNhapEmail.PlaceholderText = "Nhập địa chỉ Email...";
            txtNhapEmail.SelectedText = "";
            txtNhapEmail.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtNhapEmail.Size = new Size(400, 62);
            txtNhapEmail.TabIndex = 1;
            txtNhapEmail.TextOffset = new Point(10, 0);
            // 
            // lblSubTitle
            // 
            lblSubTitle.BackColor = Color.Transparent;
            lblSubTitle.Font = new Font("Segoe UI", 9F);
            lblSubTitle.ForeColor = Color.Gray;
            lblSubTitle.Location = new Point(88, 221);
            lblSubTitle.Margin = new Padding(4, 5, 4, 5);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(333, 27);
            lblSubTitle.TabIndex = 4;
            lblSubTitle.Text = "Nhập email của bạn để nhận mã xác nhận";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 118, 215);
            lblTitle.Location = new Point(150, 166);
            lblTitle.Margin = new Padding(4, 5, 4, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 40);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Khôi Phục Mật Khẩu";
            // 
            // pnlRight
            // 
            pnlRight.BackgroundImage = Properties.Resources.phong_cach_thiet_ke_shop_dien_thoai_161;
            pnlRight.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRight.Controls.Add(lblSlogan);
            pnlRight.Controls.Add(btnThoat);
            pnlRight.Controls.Add(picBackground);
            pnlRight.CustomizableEdges = customizableEdges21;
            pnlRight.Dock = DockStyle.Right;
            pnlRight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            pnlRight.Location = new Point(562, 0);
            pnlRight.Margin = new Padding(4, 5, 4, 5);
            pnlRight.Name = "pnlRight";
            pnlRight.ShadowDecoration.CustomizableEdges = customizableEdges22;
            pnlRight.Size = new Size(500, 938);
            pnlRight.TabIndex = 1;
            pnlRight.Paint += pnlRight_Paint;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = false;
            lblSlogan.BackColor = Color.Transparent;
            lblSlogan.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(31, 703);
            lblSlogan.Margin = new Padding(4, 5, 4, 5);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(438, 125);
            lblSlogan.TabIndex = 0;
            lblSlogan.Text = "Secure Account,<br>Safe Data.";
            lblSlogan.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoat.BackColor = Color.Bisque;
            btnThoat.BorderRadius = 15;
            btnThoat.CustomizableEdges = customizableEdges17;
            btnThoat.FillColor = Color.FromArgb(255, 100, 100);
            btnThoat.HoverState.FillColor = Color.Red;
            btnThoat.IconColor = Color.White;
            btnThoat.Location = new Point(454, 14);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnThoat.Size = new Size(33, 31);
            btnThoat.TabIndex = 2;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // picBackground
            // 
            picBackground.BackColor = Color.Transparent;
            picBackground.CustomizableEdges = customizableEdges19;
            picBackground.FillColor = Color.Transparent;
            picBackground.ImageRotate = 0F;
            picBackground.Location = new Point(62, 234);
            picBackground.Margin = new Padding(4, 5, 4, 5);
            picBackground.Name = "picBackground";
            picBackground.ShadowDecoration.CustomizableEdges = customizableEdges20;
            picBackground.Size = new Size(375, 391);
            picBackground.SizeMode = PictureBoxSizeMode.Zoom;
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // FormQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 938);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormQuenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên Mật Khẩu";
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlDatMatKhau.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}