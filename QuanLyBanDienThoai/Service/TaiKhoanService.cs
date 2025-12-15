using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using QuanLyBanDienThoai.Models;

namespace QuanLyBanDienThoai.Service
{
    public class TaiKhoanService
    {
        // Đường dẫn đến 2 file dữ liệu
        private readonly string _pathTaiKhoan = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Taikhoan.xml");
        private readonly string _pathNhanVien = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Nhanvien.xml");

        // --- HÀM HỖ TRỢ: ÁNH XẠ XML SANG MODEL ---
        private TaiKhoan MapToTaiKhoan(XElement tkElement)
        {
            if (tkElement == null) return null;

            return new TaiKhoan
            {
                // Dùng ép kiểu (string) và toán tử ?? "" để tránh lỗi null nếu file XML cũ thiếu trường
                MaTK = (string)tkElement.Element("MaTk") ?? (string)tkElement.Element("MaTK") ?? "",
                TenDangNhap = (string)tkElement.Element("TenDangNhap") ?? "",
                MatKhau = (string)tkElement.Element("MatKhau") ?? "",
                Quyen = (string)tkElement.Element("Quyen") ?? "NhanVien",
                MaNV = (string)tkElement.Element("MaNV") ?? "",
                HoTen = (string)tkElement.Element("HoTen") ?? "",
                Email = (string)tkElement.Element("Email") ?? ""
            };
        }

        // --- HÀM HỖ TRỢ: SINH MÃ TỰ ĐỘNG (VD: NV001, NV002...) ---
        private string TaoMaTuDong(string filePath, string rootName, string elementName, string prefix)
        {
            if (!File.Exists(filePath)) return prefix + "001";

            try
            {
                XDocument doc = XDocument.Load(filePath);

                // Lấy danh sách các mã hiện có
                var maxId = doc.Descendants(elementName)
                    .Select(x => (string)x.Element(prefix == "TK" ? "MaTk" : "MaNV")) // Lấy giá trị mã
                    .Where(v => !string.IsNullOrEmpty(v) && v.StartsWith(prefix))       // Lọc mã đúng định dạng
                    .Select(v => int.TryParse(v.Substring(prefix.Length), out int id) ? id : 0) // Tách số
                    .DefaultIfEmpty(0)
                    .Max(); // Lấy số lớn nhất

                return prefix + (maxId + 1).ToString("D3"); // Cộng 1 và định dạng 3 số (001)
            }
            catch
            {
                return prefix + "001"; // Fallback nếu lỗi
            }
        }

        // ==========================================================
        // 1. ĐĂNG NHẬP
        // ==========================================================
        public TaiKhoan KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            if (!File.Exists(_pathTaiKhoan)) return null;

            try
            {
                XDocument doc = XDocument.Load(_pathTaiKhoan);
                // Tìm kiếm bất kể cấu trúc lồng nhau (NewDataSet hay TaiKhoans đều được)
                var element = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk =>
                        (string)tk.Element("TenDangNhap") == tenDangNhap &&
                        (string)tk.Element("MatKhau") == matKhau);

                return MapToTaiKhoan(element);
            }
            catch
            {
                return null;
            }
        }

        // ==========================================================
        // 2. THÊM TÀI KHOẢN (KÈM TẠO NHÂN VIÊN MỚI)
        // ==========================================================
        public bool ThemTaiKhoan(TaiKhoan taiKhoanMoi)
        {
            try
            {
                // A. CHUẨN BỊ FILE TÀI KHOẢN
                XDocument docTK;
                if (!File.Exists(_pathTaiKhoan))
                    docTK = new XDocument(new XElement("NewDataSet"));
                else
                    docTK = XDocument.Load(_pathTaiKhoan);

                // Kiểm tra trùng tên đăng nhập
                if (docTK.Descendants("TaiKhoan").Any(tk => (string)tk.Element("TenDangNhap") == taiKhoanMoi.TenDangNhap))
                {
                    return false; // Đã tồn tại
                }

                // Sinh mã Tài khoản mới
                taiKhoanMoi.MaTK = TaoMaTuDong(_pathTaiKhoan, "NewDataSet", "TaiKhoan", "TK");


                // B. XỬ LÝ TẠO NHÂN VIÊN MỚI (Để lấy MaNV)
                XDocument docNV;
                if (!File.Exists(_pathNhanVien))
                    docNV = new XDocument(new XElement("NewDataSet"));
                else
                    docNV = XDocument.Load(_pathNhanVien);

                // Sinh mã Nhân viên mới
                string maNVMoi = TaoMaTuDong(_pathNhanVien, "NewDataSet", "NhanVien", "NV");
                taiKhoanMoi.MaNV = maNVMoi;

                // Tạo dữ liệu Nhân Viên
                XElement newNhanVien = new XElement("NhanVien",
                    new XElement("MaNV", maNVMoi),
                    new XElement("TenNV", taiKhoanMoi.HoTen),
                    new XElement("ChucVu", "Nhân Viên"),
                    new XElement("SoDienThoai", "")
                );

                // Lưu Nhân viên vào XML
                var rootNV = docNV.Element("NewDataSet");
                if (rootNV == null) { rootNV = new XElement("NewDataSet"); docNV.Add(rootNV); }
                rootNV.Add(newNhanVien);
                docNV.Save(_pathNhanVien);


                // C. LƯU TÀI KHOẢN VÀO XML
                XElement newTaiKhoan = new XElement("TaiKhoan",
                    new XElement("MaTk", taiKhoanMoi.MaTK),
                    new XElement("TenDangNhap", taiKhoanMoi.TenDangNhap),
                    new XElement("MatKhau", taiKhoanMoi.MatKhau),
                    new XElement("Quyen", "NhanVien"),
                    new XElement("MaNV", taiKhoanMoi.MaNV), // Mã NV vừa tạo
                    new XElement("HoTen", taiKhoanMoi.HoTen),
                    new XElement("Email", taiKhoanMoi.Email)
                );

                var rootTK = docTK.Element("NewDataSet");
                if (rootTK == null) { rootTK = new XElement("NewDataSet"); docTK.Add(rootTK); }
                rootTK.Add(newTaiKhoan);
                docTK.Save(_pathTaiKhoan);

                return true;
            }
            catch
            {
                return false;
            }
        }

        // ==========================================================
        // 3. CÁC HÀM PHỤ TRỢ (QUÊN MẬT KHẨU)
        // ==========================================================
        public TaiKhoan LayTaiKhoanTheoEmail(string email)
        {
            if (!File.Exists(_pathTaiKhoan)) return null;
            try
            {
                XDocument doc = XDocument.Load(_pathTaiKhoan);
                var element = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk => (string)tk.Element("Email") == email);
                return MapToTaiKhoan(element);
            }
            catch { return null; }
        }

        public bool CapNhatMatKhau(string tenDangNhap, string matKhauMoi)
        {
            if (!File.Exists(_pathTaiKhoan)) return false;
            try
            {
                XDocument doc = XDocument.Load(_pathTaiKhoan);
                var tkElement = doc.Descendants("TaiKhoan")
                    .FirstOrDefault(tk => (string)tk.Element("TenDangNhap") == tenDangNhap);

                if (tkElement != null)
                {
                    tkElement.SetElementValue("MatKhau", matKhauMoi);
                    doc.Save(_pathTaiKhoan);
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
    }
}