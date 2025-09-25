using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace App.Models
{
    internal class DatMatKhauMoiModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public void luuMatKhauMoi(string email, string matKhau)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string truyVanLuuMatKhauMoi = @"UPDATE NguoiDung
                                                    SET MatKhau = @matkhau
                                                    WHERE Email = @email";

                    using (SqlCommand command = new SqlCommand(truyVanLuuMatKhauMoi, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@matkhau", matKhau);
                        command.ExecuteNonQuery();
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
