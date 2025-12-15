using System.Data;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace QuanLyBanDienThoai.DAL;

/// <summary>
/// Dịch vụ thao tác dữ liệu với các file XML và XSLT.
/// </summary>
public static class XmlDataService
{
    /// <summary>
    /// Đường dẫn gốc tới thư mục Data chứa các file XML và XSLT.
    /// </summary>
    private static readonly string BasePath =
        Path.Combine(AppContext.BaseDirectory, "Data");

    /// <summary>
    /// Đọc dữ liệu từ file XML vào DataTable.
    /// </summary>
    /// <param name="fileName">Tên file (ví dụ: Sanpham.xml)</param>
    /// <param name="tableName">Tên bảng gốc trong XML (ví dụ: Sanphams)</param>
    public static DataTable LoadTable(string fileName, string tableName)
    {
        string path = Path.Combine(BasePath, fileName);
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Không tìm thấy file XML: {path}");
        }

        DataSet ds = new();
        ds.ReadXml(path);
        if (!ds.Tables.Contains(tableName))
        {
            throw new InvalidDataException(
                $"File {fileName} không chứa bảng {tableName}");
        }

        return ds.Tables[tableName];
    }

    /// <summary>
    /// Ghi DataTable ra file XML (ghi đè).
    /// </summary>
    /// <param name="table">DataTable cần ghi</param>
    /// <param name="fileName">Tên file (ví dụ: Sanpham.xml)</param>
    /// <param name="tableName">Tên bảng gốc trong XML (ví dụ: Sanphams)</param>
    public static void SaveTable(DataTable table, string fileName, string tableName)
    {
        string path = Path.Combine(BasePath, fileName);

        // Đảm bảo tên bảng đúng để ghi XML có root/table hợp lệ
        table.TableName = tableName;

        DataSet ds = new();
        ds.Tables.Add(table.Copy());

        // Ghi kèm schema để giữ kiểu dữ liệu
        ds.WriteXml(path, XmlWriteMode.WriteSchema);
    }

    /// <summary>
    /// Đồng bộ: kéo dữ liệu từ database xuống file XML.
    /// </summary>
    /// <param name="sql">Câu lệnh SELECT</param>
    /// <param name="fileName">Tên file XML đích</param>
    /// <param name="tableName">Tên bảng gốc trong XML</param>
    public static void SyncFromDatabase(string sql, string fileName, string tableName)
    {
        DataTable dt = DatabaseHelper.ExecuteQuery(sql);
        SaveTable(dt, fileName, tableName);
    }

    /// <summary>
    /// Đồng bộ: đẩy dữ liệu từ file XML lên database.
    /// Ở đây trả về DataTable để caller tự xử lý insert/update tùy logic nghiệp vụ.
    /// </summary>
    /// <param name="fileName">Tên file XML nguồn</param>
    /// <param name="tableName">Tên bảng gốc trong XML</param>
    public static DataTable LoadForSyncToDatabase(string fileName, string tableName)
    {
        return LoadTable(fileName, tableName);
    }

    /// <summary>
    /// Chuyển đổi DataTable sang HTML sử dụng file XSLT từ thư mục Data.
    /// </summary>
    /// <param name="table">DataTable cần chuyển đổi</param>
    /// <param name="xsltFileName">Tên file XSLT (ví dụ: "Taikhoan.xslt")</param>
    /// <param name="tableName">Tên bảng để tạo XML (ví dụ: "TaiKhoan")</param>
    /// <returns>Chuỗi HTML đã được chuyển đổi</returns>
    public static string ConvertDataTableToHtml(DataTable table, string xsltFileName, string tableName)
    {
        if (table == null || table.Rows.Count == 0)
        {
            throw new ArgumentException("DataTable không được null hoặc rỗng", nameof(table));
        }

        // Đường dẫn đến file XSLT trong thư mục Data
        string xsltPath = Path.Combine(BasePath, xsltFileName);
        if (!File.Exists(xsltPath))
        {
            throw new FileNotFoundException($"Không tìm thấy file XSLT: {xsltPath}");
        }

        // Chuyển DataTable thành XML trong memory
        DataSet ds = new();
        DataTable tableCopy = table.Copy();
        tableCopy.TableName = tableName;
        ds.Tables.Add(tableCopy);

        string xmlString;
        using (StringWriter sw = new())
        {
            ds.WriteXml(sw, XmlWriteMode.IgnoreSchema);
            xmlString = sw.ToString();
        }

        // Thực hiện chuyển đổi XSLT
        using (StringReader xmlReader = new(xmlString))
        using (XmlReader xr = XmlReader.Create(xmlReader))
        using (XmlReader xsltReader = XmlReader.Create(xsltPath))
        using (StringWriter htmlWriter = new())
        {
            XslCompiledTransform xslt = new();
            xslt.Load(xsltReader);
            xslt.Transform(xr, null, htmlWriter);
            return htmlWriter.ToString();
        }
    }

    /// <summary>
    /// Chuyển đổi chi tiết hóa đơn/phiếu nhập sang HTML sử dụng file XSLT.
    /// </summary>
    /// <param name="headerInfo">Dictionary chứa thông tin header (MaHD, TenKH, TenNV, NgayLap, etc.)</param>
    /// <param name="chiTietTable">DataTable chứa chi tiết (phải có cột TenSP)</param>
    /// <param name="xsltFileName">Tên file XSLT (ví dụ: "Chitiethoadon.xslt")</param>
    /// <param name="rootElementName">Tên root element (ví dụ: "HoaDonInfo" hoặc "PhieuNhapInfo")</param>
    /// <param name="chiTietElementName">Tên element cho chi tiết (ví dụ: "ChiTietHoaDon" hoặc "ChiTietPhieuNhap")</param>
    /// <returns>Chuỗi HTML đã được chuyển đổi</returns>
    public static string ConvertChiTietToHtml(
        Dictionary<string, string> headerInfo,
        DataTable chiTietTable,
        string xsltFileName,
        string rootElementName,
        string chiTietElementName)
    {
        if (chiTietTable == null || chiTietTable.Rows.Count == 0)
        {
            throw new ArgumentException("DataTable chi tiết không được null hoặc rỗng", nameof(chiTietTable));
        }

        // Đường dẫn đến file XSLT
        string xsltPath = Path.Combine(BasePath, xsltFileName);
        if (!File.Exists(xsltPath))
        {
            throw new FileNotFoundException($"Không tìm thấy file XSLT: {xsltPath}");
        }

        // Tạo XML structure phù hợp với XSLT
        XmlDocument xmlDoc = new();
        XmlElement root = xmlDoc.CreateElement("Root");
        xmlDoc.AppendChild(root);

        // Tạo element header info
        XmlElement headerElement = xmlDoc.CreateElement(rootElementName);
        foreach (var kvp in headerInfo)
        {
            XmlElement elem = xmlDoc.CreateElement(kvp.Key);
            elem.InnerText = kvp.Value ?? "";
            headerElement.AppendChild(elem);
        }
        root.AppendChild(headerElement);

        // Tạo element chi tiết
        foreach (DataRow row in chiTietTable.Rows)
        {
            XmlElement chiTietElement = xmlDoc.CreateElement(chiTietElementName);
            foreach (DataColumn col in chiTietTable.Columns)
            {
                XmlElement fieldElement = xmlDoc.CreateElement(col.ColumnName);
                object? value = row[col];
                fieldElement.InnerText = value?.ToString() ?? "";
                chiTietElement.AppendChild(fieldElement);
            }
            root.AppendChild(chiTietElement);
        }

        // Chuyển đổi XML sang string
        string xmlString;
        using (StringWriter sw = new())
        {
            xmlDoc.Save(sw);
            xmlString = sw.ToString();
        }

        // Thực hiện chuyển đổi XSLT
        using (StringReader xmlReader = new(xmlString))
        using (XmlReader xr = XmlReader.Create(xmlReader))
        using (XmlReader xsltReader = XmlReader.Create(xsltPath))
        using (StringWriter htmlWriter = new())
        {
            XslCompiledTransform xslt = new();
            xslt.Load(xsltReader);
            xslt.Transform(xr, null, htmlWriter);
            return htmlWriter.ToString();
        }
    }
}

