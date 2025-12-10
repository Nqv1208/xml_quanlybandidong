using System.Data;
using System.IO;
using System.Xml;
using QuanLyBanDienThoai.DAL;

namespace QuanLyBanDienThoai.Data;

/// <summary>
/// Dịch vụ thao tác dữ liệu với các file XML trong thư mục Data.
/// </summary>
public static class XmlDataService
{
    /// <summary>
    /// Đường dẫn gốc tới thư mục Data chứa các file XML.
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
}

