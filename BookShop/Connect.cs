using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BookShop
{
    internal class Connect
    {
        // Chuỗi kết nối
        private readonly string connectionString;

        // Constructor: Khởi tạo chuỗi kết nối
        public Connect()
        {
            // Đường dẫn tới file .mdf trong dự án
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\3 - 1\dot NET\BookShop\BookShop\Database\BookShop_Database.mdf;Integrated Security=True;Connect Timeout=30";
        }

        // Hàm trả về kết nối
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Hàm kiểm tra kết nối 
        public bool TestConnection()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connect Successful!");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Connection Error: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
