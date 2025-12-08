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
        private readonly string _filePath = "Data\\TaiKhoan.xml";

        // Hàm hỗ trợ ánh xạ từ XElement sang đối tượng TaiKhoan
        private TaiKhoan MapToTaiKhoan(XElement tkElement)
        {
            if (tkElement == null) return null;

            return new TaiKhoan
            {
                MaTK = (string)tkElement.Element("MaTK"),
                TenDangNhap = (string)tkElement.Element("TenDangNhap"),
                MatKhau = (string)tkElement.Element("MatKhau"),
                Quyen = (string)tkElement.Element("Quyen"),
                MaNV = (string)tkElement.Element("MaNV"),
                HoTen = (string)tkElement.Element("HoTen"),
                Email = (string)tkElement.Element("Email")
            };
        }

        // ==========================================================
        // PHƯƠNG THỨC 1: KIỂM TRA ĐĂNG NHẬP (Giữ nguyên)
        // ==========================================================
        public TaiKhoan KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            if (!File.Exists(_filePath)) return null;

            try
            {
                XDocument doc = XDocument.Load(_filePath);
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
        // PHƯƠNG THỨC 2: THÊM TÀI KHOẢN (Giữ nguyên)
        // ==========================================================
        public bool ThemTaiKhoan(TaiKhoan taiKhoanMoi)
        {
            try
            {
                XDocument doc;
                if (!File.Exists(_filePath))
                {
                    doc = new XDocument(new XElement("TaiKhoans"));
                }
                else
                {
                    doc = XDocument.Load(_filePath);
                }

                if (doc.Descendants("TaiKhoan").Any(tk => (string)tk.Element("TenDangNhap") == taiKhoanMoi.TenDangNhap))
                {
                    return false;
                }

                int nextId = doc.Descendants("TaiKhoan").Count() + 1;
                taiKhoanMoi.MaTK = "TK" + nextId.ToString("D3");

                XElement newTaiKhoan = new XElement("TaiKhoan",
                    new XElement("MaTK", taiKhoanMoi.MaTK),
                    new XElement("TenDangNhap", taiKhoanMoi.TenDangNhap),
                    new XElement("MatKhau", taiKhoanMoi.MatKhau),
                    new XElement("Quyen", taiKhoanMoi.Quyen),
                    new XElement("MaNV", taiKhoanMoi.MaNV),
                    new XElement("HoTen", taiKhoanMoi.HoTen),
                    new XElement("Email", taiKhoanMoi.Email)
                );

                doc.Element("TaiKhoans").Add(newTaiKhoan);
                doc.Save(_filePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ==========================================================
        // PHƯƠNG THỨC MỚI 3: LẤY TÀI KHOẢN THEO EMAIL (Hỗ trợ Quên MK)
        // ==========================================================
        public TaiKhoan LayTaiKhoanTheoEmail(string email)
        {
            if (!File.Exists(_filePath)) return null;

            try
            {
                XDocument doc = XDocument.Load(_filePath);
                var element = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk =>
                        (string)tk.Element("Email") == email); // Tìm theo trường Email

                return MapToTaiKhoan(element);
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ==========================================================
        // PHƯƠNG THỨC MỚI 4: CẬP NHẬT MẬT KHẨU (Hỗ trợ Quên MK)
        // ==========================================================
        public bool CapNhatMatKhau(string tenDangNhap, string matKhauMoi)
        {
            if (!File.Exists(_filePath)) return false;

            try
            {
                XDocument doc = XDocument.Load(_filePath);
                var taiKhoanCapNhat = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk => (string)tk.Element("TenDangNhap") == tenDangNhap);

                if (taiKhoanCapNhat != null)
                {
                    // Cập nhật giá trị của thẻ MatKhau
                    taiKhoanCapNhat.Element("MatKhau").Value = matKhauMoi;
                    doc.Save(_filePath);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ... (Các phương thức khác)
    }
}