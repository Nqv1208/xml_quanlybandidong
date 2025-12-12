namespace QuanLyBanDienThoai.GUI
{
    partial class FormQuenMatKhau
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
            txtNhapEmail = new TextBox();
            label1 = new Label();
            btnGuiMa = new Button();
            pnlDatMatKhau = new Panel();
            btnXacNhan = new Button();
            txtNhapLaiMatKhau = new TextBox();
            txtMatKhauMoi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaOTP = new TextBox();
            btnThoat = new Button();
            pnlDatMatKhau.SuspendLayout();
            SuspendLayout();
            // 
            // txtNhapEmail
            // 
            txtNhapEmail.Location = new Point(401, 116);
            txtNhapEmail.Name = "txtNhapEmail";
            txtNhapEmail.Size = new Size(318, 31);
            txtNhapEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 119);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập email:";
            // 
            // btnGuiMa
            // 
            btnGuiMa.Location = new Point(775, 114);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.Size = new Size(112, 34);
            btnGuiMa.TabIndex = 2;
            btnGuiMa.Text = "Gửi Mã";
            btnGuiMa.UseVisualStyleBackColor = true;
            // 
            // pnlDatMatKhau
            // 
            pnlDatMatKhau.Controls.Add(btnXacNhan);
            pnlDatMatKhau.Controls.Add(txtNhapLaiMatKhau);
            pnlDatMatKhau.Controls.Add(txtMatKhauMoi);
            pnlDatMatKhau.Controls.Add(label4);
            pnlDatMatKhau.Controls.Add(label3);
            pnlDatMatKhau.Controls.Add(label2);
            pnlDatMatKhau.Controls.Add(txtMaOTP);
            pnlDatMatKhau.Location = new Point(306, 184);
            pnlDatMatKhau.Name = "pnlDatMatKhau";
            pnlDatMatKhau.Size = new Size(601, 353);
            pnlDatMatKhau.TabIndex = 3;
            pnlDatMatKhau.Visible = false;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(255, 261);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(112, 34);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(272, 182);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(238, 31);
            txtNhapLaiMatKhau.TabIndex = 5;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(272, 123);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(238, 31);
            txtMatKhauMoi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 182);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 3;
            label4.Text = "Nhập lại mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 129);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 2;
            label3.Text = "Nhập mật khẩu mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 70);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "Nhập mã OTP:";
            // 
            // txtMaOTP
            // 
            txtMaOTP.Location = new Point(272, 64);
            txtMaOTP.Name = "txtMaOTP";
            txtMaOTP.Size = new Size(238, 31);
            txtMaOTP.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1030, 534);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 34);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FormQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 599);
            Controls.Add(btnThoat);
            Controls.Add(pnlDatMatKhau);
            Controls.Add(btnGuiMa);
            Controls.Add(label1);
            Controls.Add(txtNhapEmail);
            Name = "FormQuenMatKhau";
            Text = "FormQuenMatKhau";
            pnlDatMatKhau.ResumeLayout(false);
            pnlDatMatKhau.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNhapEmail;
        private Label label1;
        private Button btnGuiMa;
        private Panel pnlDatMatKhau;
        private TextBox txtMaOTP;
        private Button btnXacNhan;
        private TextBox txtNhapLaiMatKhau;
        private TextBox txtMatKhauMoi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThoat;
    }
}