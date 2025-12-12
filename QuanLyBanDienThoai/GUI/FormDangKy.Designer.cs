namespace QuanLyBanDienThoai.GUI
{
    partial class FormDangKy
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
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            btnDangKy = new Button();
            linkDangNhap = new LinkLabel();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(333, 125);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(277, 31);
            txtHoTen.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(333, 188);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 31);
            txtEmail.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(333, 250);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(277, 31);
            txtTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(333, 312);
            txtMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(277, 31);
            txtMatKhau.TabIndex = 3;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(333, 375);
            txtNhapLaiMatKhau.Margin = new Padding(3, 4, 3, 4);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(277, 31);
            txtNhapLaiMatKhau.TabIndex = 4;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(389, 475);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(167, 50);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = true;
            // 
            // linkDangNhap
            // 
            linkDangNhap.AutoSize = true;
            linkDangNhap.Location = new Point(367, 550);
            linkDangNhap.Name = "linkDangNhap";
            linkDangNhap.Size = new Size(237, 25);
            linkDangNhap.TabIndex = 6;
            linkDangNhap.TabStop = true;
            linkDangNhap.Text = "Đã có tài khoản? Đăng nhập";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(695, 585);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(111, 38);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 131);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 8;
            label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 194);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 9;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 256);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 10;
            label3.Text = "Tên đăng nhập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 312);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 11;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 381);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 12;
            label5.Text = "Nhập lại mật khẩu:";
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 750);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(linkDangNhap);
            Controls.Add(btnDangKy);
            Controls.Add(txtNhapLaiMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDangKy";
            Text = "FormĐăngKý";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // KHAI BÁO BIẾN CONTROL
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.LinkLabel linkDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}