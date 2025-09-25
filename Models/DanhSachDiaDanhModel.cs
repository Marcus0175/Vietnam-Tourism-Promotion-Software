using System.Data.SqlClient;
using System.Configuration;
using App.Utilities;

namespace App.Models
{
    internal class DanhSachDiaDanhModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private int soLuong;

        public int timKiemTheoTen(string tenDiaDanh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) FROM DiaDanh
                                    WHERE TenDiaDanh COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%' + @tendiadanh + '%'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tendiadanh", tenDiaDanh);
                        soLuong = (int)cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
                return soLuong;
            }
            catch
            {
                throw;
            }
        }

        public int timKiemTatCa()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) FROM DiaDanh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        soLuong = (int)cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
                return soLuong;
            }
            catch
            {
                throw;
            }
        }

        public int timKiemTheoTinhThanh(string maTinh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) FROM DiaDanh
                                    WHERE MaTinh = @matinh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@matinh", maTinh);
                        soLuong = (int)cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
                return soLuong;
            }
            catch
            {
                throw;
            }
        }

        public int timKiemTheoBoLoc(string maTinh, string loaiDiaDanh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) FROM DiaDanh
                                    WHERE MaTinh = @matinh AND LoaiDiaDanh = @loaidiadanh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@matinh", maTinh);
                        cmd.Parameters.AddWithValue("@loaidiadanh", loaiDiaDanh);
                        soLuong = (int)cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
                return soLuong;
            }
            catch
            {
                throw;
            }
        }

        public int timKiemTheoLoai(string loaiDiaDanh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) FROM DiaDanh
                                    WHERE LoaiDiaDanh = @loaidiadanh";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@loaidiadanh", loaiDiaDanh);
                        soLuong = (int)cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
                return soLuong;
            }
            catch
            {
                throw;
            }
        }

        public List<ThongTinDiaDanh> layThongTinDiaDanhTheoBoLoc(int startIndex, int kichThuocTrang, string maTinh, string loaiDiaDanh)
        {
            List<ThongTinDiaDanh> danhSachThongTin = new List<ThongTinDiaDanh>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                                SELECT MaDiaDanh, TenDiaDanh, XepHang, AnhChuDe, LuotXem, ToaDo FROM DiaDanh
                                WHERE MaTinh = @matinh AND LoaiDiaDanh = @loaidiadanh
                                ORDER BY LuotXem DESC
                                OFFSET @StartIndex ROWS FETCH NEXT @kichthuoctrang ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@matinh", maTinh);
                        cmd.Parameters.AddWithValue("@loaidiadanh", loaiDiaDanh);
                        cmd.Parameters.AddWithValue("@StartIndex", startIndex);
                        cmd.Parameters.AddWithValue("@kichthuoctrang", kichThuocTrang);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var diaDanh = new ThongTinDiaDanh
                                {
                                    maDiaDanh = reader.GetString(0),
                                    tenDiaDanh = reader.GetString(1),
                                    xepHang = reader.IsDBNull(2) ? "Chưa có xếp hạng" : reader.GetString(2),
                                    anhChuDe = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    luotXem = reader.GetInt32(4),
                                    toaDo = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };
                                danhSachThongTin.Add(diaDanh);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return danhSachThongTin;
        }

        public List<ThongTinDiaDanh> layThongTinDiaDanhTheoTen(int startIndex, int kichThuocTrang, string tenDiaDanh)
        {
            List<ThongTinDiaDanh> danhSachThongTin = new List<ThongTinDiaDanh>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                                SELECT MaDiaDanh, TenDiaDanh, XepHang, AnhChuDe, LuotXem, ToaDo FROM DiaDanh
                                WHERE TenDiaDanh COLLATE SQL_Latin1_General_CP1_CI_AI LIKE '%' + @tendiadanh + '%'
                                ORDER BY LuotXem DESC
                                OFFSET @StartIndex ROWS FETCH NEXT @kichthuoctrang ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tendiadanh", tenDiaDanh);
                        cmd.Parameters.AddWithValue("@StartIndex", startIndex);
                        cmd.Parameters.AddWithValue("@kichthuoctrang", kichThuocTrang);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var diaDanh = new ThongTinDiaDanh
                                {
                                    maDiaDanh = reader.GetString(0),
                                    tenDiaDanh = reader.GetString(1),
                                    xepHang = reader.IsDBNull(2) ? "Chưa có xếp hạng" : reader.GetString(2),
                                    anhChuDe = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    luotXem = reader.GetInt32(4),
                                    toaDo = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };
                                danhSachThongTin.Add(diaDanh);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return danhSachThongTin;
        }

        public List<ThongTinDiaDanh> layThongTinTatCa(int startIndex, int kichThuocTrang)
        {
            List<ThongTinDiaDanh> danhSachThongTin = new List<ThongTinDiaDanh>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                                SELECT MaDiaDanh, TenDiaDanh, XepHang, AnhChuDe, LuotXem,ToaDo FROM DiaDanh
                                ORDER BY LuotXem DESC
                                OFFSET @StartIndex ROWS FETCH NEXT @kichthuoctrang ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartIndex", startIndex);
                        cmd.Parameters.AddWithValue("@kichthuoctrang", kichThuocTrang);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var diaDanh = new ThongTinDiaDanh
                                {
                                    maDiaDanh = reader.GetString(0),
                                    tenDiaDanh = reader.GetString(1),
                                    xepHang = reader.IsDBNull(2) ? "Chưa có xếp hạng" : reader.GetString(2),
                                    anhChuDe = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    luotXem = reader.GetInt32(4),
                                    toaDo = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };
                                danhSachThongTin.Add(diaDanh);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return danhSachThongTin;
        }

        public List<ThongTinDiaDanh> layThongTinTheoTinhThanh(int startIndex, int kichThuocTrang, string maTinh)
        {
            List<ThongTinDiaDanh> danhSachThongTin = new List<ThongTinDiaDanh>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                                SELECT MaDiaDanh, TenDiaDanh, XepHang, AnhChuDe, LuotXem,ToaDo FROM DiaDanh
                                WHERE MaTinh = @matinh
                                ORDER BY LuotXem DESC
                                OFFSET @StartIndex ROWS FETCH NEXT @kichthuoctrang ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@matinh", maTinh);
                        cmd.Parameters.AddWithValue("@StartIndex", startIndex);
                        cmd.Parameters.AddWithValue("@kichthuoctrang", kichThuocTrang);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var diaDanh = new ThongTinDiaDanh
                                {
                                    maDiaDanh = reader.GetString(0),
                                    tenDiaDanh = reader.GetString(1),
                                    xepHang = reader.IsDBNull(2) ? "Chưa có xếp hạng" : reader.GetString(2),
                                    anhChuDe = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    luotXem = reader.GetInt32(4),
                                    toaDo = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };
                                danhSachThongTin.Add(diaDanh);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return danhSachThongTin;
        }

        public List<ThongTinDiaDanh> layThongTinTheoLoai(int startIndex, int kichThuocTrang, string loaiDiaDanh)
        {
            List<ThongTinDiaDanh> danhSachThongTin = new List<ThongTinDiaDanh>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                                SELECT MaDiaDanh, TenDiaDanh, XepHang, AnhChuDe, LuotXem, ToaDo FROM DiaDanh
                                WHERE LoaiDiaDanh = @loaidiadanh
                                ORDER BY LuotXem DESC
                                OFFSET @StartIndex ROWS FETCH NEXT @kichthuoctrang ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@loaidiadanh", loaiDiaDanh);
                        cmd.Parameters.AddWithValue("@StartIndex", startIndex);
                        cmd.Parameters.AddWithValue("@kichthuoctrang", kichThuocTrang);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var diaDanh = new ThongTinDiaDanh
                                {
                                    maDiaDanh = reader.GetString(0),
                                    tenDiaDanh = reader.GetString(1),
                                    xepHang = reader.IsDBNull(2) ? "Chưa có xếp hạng" : reader.GetString(2),
                                    anhChuDe = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    luotXem = reader.GetInt32(4),
                                    toaDo = reader.IsDBNull(5) ? null : reader.GetString(5)
                                };
                                danhSachThongTin.Add(diaDanh);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return danhSachThongTin;
        }

        public void capNhatLuotXem(string maDiaDanh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                                UPDATE DiaDanh
                                SET LuotXem = LuotXem + 1
                                WHERE MaDiaDanh = @madiadanh";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@madiadanh", maDiaDanh);
                           cmd.ExecuteNonQuery();
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
