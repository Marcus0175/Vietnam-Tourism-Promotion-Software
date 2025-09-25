using App.Utilities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace App.Models
{
    public class DangNhapModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public NguoiDung xacThucDangNhap(string email, string matkhau)
        {
            NguoiDung? nguoiDung = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string truyVanXacThucDangNhap = "SELECT * FROM NguoiDung WHERE Email = @email AND Matkhau = @matkhau";

                    using (SqlCommand command = new SqlCommand(truyVanXacThucDangNhap, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@matkhau", matkhau);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            nguoiDung = new NguoiDung()
                            {
                                maNguoiDung = table.Rows[0]["MaNguoiDung"].ToString(),
                                email = table.Rows[0]["Email"].ToString(),
                                phanQuyen = (int)table.Rows[0]["PhanQuyen"],
                            };
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception) 
            {
                throw;
            }
            return nguoiDung;
        }

        public bool xacThucEmail(string email)
        {
            try 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string truyVanXacThucEmail = "SELECT COUNT(1) FROM NguoiDung WHERE Email = @email";

                    using (SqlCommand command = new SqlCommand(truyVanXacThucEmail, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count == 1;
                    }
                }
            }
            catch(Exception) 
            {
                throw;
            }
        }


    }
}
