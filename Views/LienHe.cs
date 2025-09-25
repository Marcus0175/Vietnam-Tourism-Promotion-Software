using App.Views;
using System.Net.Mail;

namespace HoTro
{
    public partial class LienHe : Form
    {
        public LienHe()
        {
            InitializeComponent();
            // Ẩn các trường email và password nếu không cần thiết
          
        }

        private void HoTro_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = this;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng MailMessage
                MailMessage mm = new MailMessage();

                // Cấu hình SMTP client
                SmtpClient sc = new SmtpClient("smtp.gmail.com");

                // Đặt email người gửi và mật khẩu trực tiếp
                mm.From = new MailAddress("phanmemquangbadiadanh@gmail.com");
                mm.To.Add("nguyencaophuchai2004@gmail.com");
                mm.Subject = txtSubject.Text;
                mm.Body = txtContent.Text;

                // Cấu hình SMTP server
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("phanmemquangbadiadanh@gmail.com", "hhjq krfu eymo bjmu");
                sc.EnableSsl = true;

                // Gửi email
                sc.Send(mm);

                MessageBox.Show("Đã gửi phản hồi. Cảm ơn sự góp ý của bạn nhé!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {
            // Có thể bỏ trống hoặc xử lý nếu cần
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Có thể bỏ trống hoặc xử lý nếu cần
        }

        private void lbHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan huongdan = new HuongDan();
            huongdan.Show();
            this.Hide();
        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            // Có thể bỏ trống hoặc xử lý nếu cần
        }
    }
}
