using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
using System.Security.Permissions;

namespace App.Utilities
{
    public class Helpers
    {
        public static void chuyenForm(Form formChuyenToi)
        {
            Form? formHienTai = Application.OpenForms[Application.OpenForms.Count - 1];
            formHienTai?.Hide();
            formChuyenToi.Show();
        }

        public static bool kiemTraEmailHopLe(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static string taoMaXacNhan()
        {
            return new Random().Next(100000, 999999).ToString();
        }

        public static string maHoaMatKhau(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }

        public static void luuThongTin(string email, string matKhau)
        {
            Properties.Settings.Default.MatKhau = matKhau;
            Properties.Settings.Default.Email = email;
            Properties.Settings.Default.Save();
        }
    }
}
