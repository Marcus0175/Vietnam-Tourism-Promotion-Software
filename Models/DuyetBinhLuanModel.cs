using App.Utilities;
using System.Configuration;
using System.Data.SqlClient;

namespace App.Models
{
    internal class DuyetBinhLuanModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<BinhLuan> layBinhLuan(string maDiaDanh)
        {
            List<BinhLuan> danhSachBinhLuan = new List<BinhLuan>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Email, NoiDung, DanhGia, MaBinhLuan FROM BinhLuan
                                    WHERE MaDiaDanh = @madiadanh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maDiaDanh", maDiaDanh);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var binhLuan = new BinhLuan
                                {
                                    email = reader.GetString(0),
                                    noiDung = reader.GetString(1),
                                    danhGia = reader.GetInt32(2),
                                    maBinhLuan = reader.GetInt32(3)
                                };
                                danhSachBinhLuan.Add(binhLuan);
                            }
                        }
                        conn.Close();
                    }
                    return danhSachBinhLuan;
                }
            }
            catch
            {
                throw;
            }
        }
        public void xoaBinhLuan(int maBinhLuan)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"DELETE FROM BinhLuan
                                    WHERE MaBinhLuan = @mabinhluan";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mabinhluan", maBinhLuan);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
