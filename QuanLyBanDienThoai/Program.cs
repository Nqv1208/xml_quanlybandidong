using QuanLyBanDienThoai.GUI;

namespace QuanLyBanDienThoai
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Seed XML từ database nếu file chưa tồn tại
            Data.XmlSeeder.SeedFromDatabase();

            Application.Run(new FormDangKy());
        }
    }
}