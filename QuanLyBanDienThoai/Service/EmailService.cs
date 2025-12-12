using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyBanDienThoai.Service
{
    public class EmailService
    {
        // Cấu hình SMTP (Thay thế bằng thông tin của bạn)
        private const string SMTPEmail = "tn6642455@gmail.com"; // Ví dụ: myappsupport@gmail.com
        private const string SMTPPassword = "kkut urro tkan bcpf"; // Đây phải là Mật khẩu ứng dụng (App Password) nếu dùng Gmail
        private const string SMTPServer = "smtp.gmail.com"; // Ví dụ cho Gmail
        private const int SMTPPort = 587; // Port chuẩn cho TLS/STARTTLS

        /// <summary>
        /// Gửi email đến người nhận với tiêu đề và nội dung.
        /// </summary>
        /// <returns>True nếu gửi thành công, ngược lại False.</returns>
        public bool GuiMail(string toEmail, string subject, string body)
        {
            try
            {
                var mail = new MailMessage();
                mail.From = new MailAddress(SMTPEmail, "Hỗ Trợ Quản Lý Điện Thoại");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;

                using (var smtp = new SmtpClient(SMTPServer, SMTPPort))
                {
                    smtp.Credentials = new NetworkCredential(SMTPEmail, SMTPPassword);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi gửi email: Vui lòng kiểm tra cài đặt SMTP và mật khẩu ứng dụng. Chi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}