
using App.Controllers;
using System.Runtime.InteropServices;

namespace App.Views
{
    public partial class DatMatKhauMoi : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeft,
               int nTop,
               int nRight,
               int nBottom,
               int nWidthEllipse,
               int nHeightEllipse
           );
        private string email;
        private DatMatKhauMoiController controller;
        public DatMatKhauMoi(string email)
        {
            InitializeComponent();
            this.email = email;
            controller = new DatMatKhauMoiController(this);
        }

        private void DatMatKhauMoi_Load(object sender, EventArgs e)
        {
            labelMatKhauKhongKhop.Hide();
            btnDatLaiMatKhau.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDatLaiMatKhau.Width, btnDatLaiMatKhau.Height, 20, 20));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 15, 15));
            textBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox2.Width, textBox2.Height, 15, 15));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text)
            {
                labelMatKhauKhongKhop.Show();
            }
            else
            {
                labelMatKhauKhongKhop.Hide();
            }
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != textBox2.Text)
                {
                    return;
                }
                else
                {
                    controller.datLaiMatKhau(textBox1.Text, email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
