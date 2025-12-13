using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using QuanLyBanDienThoai.Model;
using System.IO;

namespace QuanLyBanDienThoai.Service
{
    public class TaiKhoanService
    {
        // Đường dẫn tương đối đến thư mục bin/Debug/Data
        private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Taikhoan.xml");

        // Hàm hỗ trợ ánh xạ từ XElement sang đối tượng TaiKhoan
        private TaiKhoan MapToTaiKhoan(XElement tkElement)
        {
            if (tkElement == null) return null;

            return new TaiKhoan
            {
                // Sử dụng ép kiểu (string) để tránh lỗi nếu thẻ không tồn tại
                MaTK = (string)tkElement.Element("MaTk") ?? (string)tkElement.Element("MaTK"), // Hỗ trợ cả 2 cách viết hoa thường
                TenDangNhap = (string)tkElement.Element("TenDangNhap"),
                MatKhau = (string)tkElement.Element("MatKhau"),
                Quyen = (string)tkElement.Element("Quyen"),
                MaNV = (string)tkElement.Element("MaNV"),
                HoTen = (string)tkElement.Element("HoTen") ?? "", // Nếu null thì trả về rỗng
                Email = (string)tkElement.Element("Email") ?? ""
            };
        }

        // ==========================================================
        // 1. KIỂM TRA ĐĂNG NHẬP
        // ==========================================================
        public TaiKhoan KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            if (!File.Exists(_filePath)) return null;

            try
            {
                XDocument doc = XDocument.Load(_filePath);

                // Tìm trong thẻ gốc NewDataSet
                var element = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk =>
                        (string)tk.Element("TenDangNhap") == tenDangNhap &&
                        (string)tk.Element("MatKhau") == matKhau);

                return MapToTaiKhoan(element);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ==========================================================
        // 2. THÊM TÀI KHOẢN (Đã sửa để khớp XML NewDataSet)
        // ==========================================================
        public bool ThemTaiKhoan(TaiKhoan taiKhoanMoi)
        {
            try
            {
                XDocument doc;
                if (!File.Exists(_filePath))
                {
                    // Nếu chưa có file, tạo mới với root là NewDataSet
                    doc = new XDocument(new XElement("NewDataSet"));
                }
                else
                {
                    doc = XDocument.Load(_filePath);
                }

                // Kiểm tra trùng tên đăng nhập
                if (doc.Descendants("TaiKhoan").Any(tk => (string)tk.Element("TenDangNhap") == taiKhoanMoi.TenDangNhap))
                {
                    return false;
                }

                // Lấy thẻ gốc (Root)
                XElement root = doc.Element("NewDataSet");
                if (root == null)
                {
                    // Trường hợp file XML lỗi cấu trúc, tự thêm root
                    root = new XElement("NewDataSet");
                    doc.Add(root);
                }

                // Sinh mã tài khoản tự động (Ví dụ: TK003)
                int count = root.Elements("TaiKhoan").Count() + 1;
                taiKhoanMoi.MaTK = "TK" + count.ToString("D3");

                // Tạo phần tử XML mới khớp với cấu trúc file của bạn
                XElement newTaiKhoan = new XElement("TaiKhoan",
                    new XElement("MaTk", taiKhoanMoi.MaTK), // XML của bạn dùng MaTk (chữ k thường)
                    new XElement("TenDangNhap", taiKhoanMoi.TenDangNhap),
                    new XElement("MatKhau", taiKhoanMoi.MatKhau),
                    new XElement("Quyen", taiKhoanMoi.Quyen),
                    new XElement("MaNV", taiKhoanMoi.MaNV),
                    // Thêm 2 trường mới (Code sẽ tự chèn thêm vào dòng mới, không ảnh hưởng dòng cũ)
                    new XElement("HoTen", taiKhoanMoi.HoTen),
                    new XElement("Email", taiKhoanMoi.Email)
                );

                // Thêm vào root NewDataSet
                root.Add(newTaiKhoan);
                doc.Save(_filePath);
                return true;
            }
            catch (Exception ex)
            {
                // Bạn có thể debug lỗi tại đây: Console.WriteLine(ex.Message);
                return false;
            }
        }

        // ==========================================================
        // 3. LẤY TÀI KHOẢN THEO EMAIL
        // ==========================================================
        public TaiKhoan LayTaiKhoanTheoEmail(string email)
        {
            if (!File.Exists(_filePath)) return null;

            try
            {
                XDocument doc = XDocument.Load(_filePath);
                var element = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk => (string)tk.Element("Email") == email);

                return MapToTaiKhoan(element);
            }
            catch
            {
                return null;
            }
        }

        // ==========================================================
        // 4. CẬP NHẬT MẬT KHẨU
        // ==========================================================
        public bool CapNhatMatKhau(string tenDangNhap, string matKhauMoi)
        {
            if (!File.Exists(_filePath)) return false;

            try
            {
                XDocument doc = XDocument.Load(_filePath);
                var tkElement = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk => (string)tk.Element("TenDangNhap") == tenDangNhap);

                if (tkElement != null)
                {
                    tkElement.SetElementValue("MatKhau", matKhauMoi);
                    doc.Save(_filePath);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}