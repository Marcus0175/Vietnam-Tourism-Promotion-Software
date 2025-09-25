using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace App.Models
{
    public class DangKiModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public bool luuTaiKhoan(string email, string matKhau)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ThemNguoiDung", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Matkhau", matKhau);
                        command.Parameters.AddWithValue("@PhanQuyen", 0);
                        int count = command.ExecuteNonQuery();

                        connection.Close();
                        return count > 0;
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool guiMaXacNhan(string email, string maXacNhan)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential("luci.gh.itch.io@gmail.com", "bovh kilj kszq sewy");
                    smtp.EnableSsl = true;

                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress("your-email@gmail.com"),
                        Subject = "Xác nhận đăng kí tài khoản",
                        IsBodyHtml = true,
                        Body = $@"
                        <html>
                        <body style='font-family: Arial, sans-serif;'>
                            <div style='text-align: center; padding: 20px;'>
                                <h1 style='color: #4CAF50;'>Xác nhận đăng ký tài khoản</h1>
                                <p style='font-size: 16px; color: #555;'>Chào bạn,</p>
                                <p style='font-size: 16px; color: #555;'>Cảm ơn bạn đã đăng ký tài khoản. Mã xác nhận của bạn là:</p>
                                <div style='font-size: 20px; font-weight: bold; color: #333; margin: 20px 0;'>{maXacNhan}</div>
                                <p style='font-size: 14px; color: #777;'>Mã xác nhận có hiệu lực trong 30 phút. Vui lòng không chia sẻ mã này với bất kỳ ai.</p>
                                <hr style='margin: 20px 0; border: none; border-top: 1px solid #ccc;'/>
                                <p style='font-size: 12px; color: #aaa;'>Email này được gửi từ hệ thống tự động. Vui lòng không trả lời email này.</p>
                            </div>
                        </body>
                        </html>"
                    };

                    mail.To.Add(email);

                    smtp.Send(mail);
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
