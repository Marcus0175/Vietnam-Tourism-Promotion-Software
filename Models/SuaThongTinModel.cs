using App.Utilities;
using System.Configuration;
using System.Data.SqlClient;

namespace App.Models
{
    internal class SuaThongTinModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<String> layAnhDiaDanh(string maDiaDanh)
        {
            List<String> danhSachAnh = new List<String>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT HinhAnh FROM HinhAnh
                                    WHERE MaDiaDanh = @madiadanh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maDiaDanh", maDiaDanh);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                danhSachAnh.Add(reader.IsDBNull(0) ? null : reader.GetString(0));
                            }
                        }
                    }
                    conn.Close();
                }
                return danhSachAnh;
            }
            catch
            {
                throw;
            }
        }
        public DiaDanhHienTai layThongTinDiaDanh(string maDiaDanh)
        {
            DiaDanhHienTai thongTinDiaDanh = new DiaDanhHienTai();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT MaDiaDanh, TenDiaDanh, ThongTin, AmThanh, XepHang, AnhChuDe FROM DiaDanh
                                    WHERE MaDiaDanh = @madiadanh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maDiaDanh", maDiaDanh);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var diaDanh = new DiaDanhHienTai
                                {
                                    maDiaDanh = reader.GetString(0),
                                    tenDiaDanh = reader.GetString(1),
                                    thongTin = reader.GetString(2),
                                    amThanh = reader.GetString(3),
                                    xepHang = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                    anhChuDe = reader.IsDBNull(5) ? "" : reader.GetString(5),
                                    danhSachAnh = layAnhDiaDanh(maDiaDanh),
                                };
                                thongTinDiaDanh = diaDanh;
                            }
                        }
                    }
                    conn.Close();
                }
                return thongTinDiaDanh;
            }
            catch
            {
                throw;
            }
        }
        public void capNhatThongTinDiaDanh(string maDiaDanh, string xepHang)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE DiaDanh
                                    SET XepHang = @xephang
                                    WHERE MaDiaDanh = @madiadanh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@maDiaDanh", maDiaDanh);
                        cmd.Parameters.AddWithValue("@xephang", xepHang);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
