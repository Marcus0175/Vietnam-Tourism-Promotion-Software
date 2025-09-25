using App.Utilities;
using System.Configuration;
using System.Data.SqlClient;

namespace App.Models
{
    internal class ThongTinChiTietDiaDanhModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<String> layAnhDiaDanh (string maDiaDanh)
        {
            List<String> danhSachAnh = new List<String>();
            try {
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
                    string query = @"SELECT MaDiaDanh, TenDiaDanh, ThongTin, AmThanh FROM DiaDanh
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
                                    danhSachAnh = layAnhDiaDanh(maDiaDanh),
                                    danhSachBinhLuan = layBinhLuan(maDiaDanh)
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

        public List<BinhLuan> layBinhLuan (string maDiaDanh)
        {
            List<BinhLuan> danhSachBinhLuan = new List<BinhLuan>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Email, NoiDung, DanhGia FROM BinhLuan
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

        public void luuBinhLuan(string maDiaDanh, string noiDung)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO BinhLuan (MaNguoiDung, MaDiaDanh, NoiDung, DanhGia, Email)
                                    Values(@manguoidung, @madiadanh, @noidung, @danhgia, @email)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@manguoidung", NguoiDungHienTai.nguoiDungHienTai.maNguoiDung);
                        cmd.Parameters.AddWithValue("@madiadanh", maDiaDanh);
                        cmd.Parameters.AddWithValue("@noidung", noiDung);
                        cmd.Parameters.AddWithValue("@danhgia", 5);
                        cmd.Parameters.AddWithValue("@email",NguoiDungHienTai.nguoiDungHienTai.email);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
