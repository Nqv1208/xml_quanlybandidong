namespace QuanLyBanDienThoai.GUI
{
    partial class FormDangNhap
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
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            linkQuenMatKhau = new LinkLabel();
            linkDangKy = new LinkLabel();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(444, 152);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(260, 31);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(444, 233);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(260, 31);
            txtMatKhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(480, 348);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(166, 50);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // linkQuenMatKhau
            // 
            linkQuenMatKhau.AutoSize = true;
            linkQuenMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkQuenMatKhau.Location = new Point(491, 419);
            linkQuenMatKhau.Name = "linkQuenMatKhau";
            linkQuenMatKhau.Size = new Size(137, 25);
            linkQuenMatKhau.TabIndex = 3;
            linkQuenMatKhau.TabStop = true;
            linkQuenMatKhau.Text = "Quên Mật Khẩu";
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkDangKy.Location = new Point(458, 468);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new Size(217, 25);
            linkDangKy.TabIndex = 4;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Đã có tài khoản? Đăng ký";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(903, 518);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(166, 50);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 158);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 6;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 233);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu:";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 620);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(linkDangKy);
            Controls.Add(linkQuenMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private LinkLabel linkQuenMatKhau;
        private LinkLabel linkDangKy;
        private Button btnThoat;
        private Label label1;
        private Label label2;
    }
}