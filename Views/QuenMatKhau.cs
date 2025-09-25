using App.Controllers;
using System.Runtime.InteropServices;

namespace App.Views
{
    public partial class QuenMatKhau : Form
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
        QuenMatKhauController controller;
        public QuenMatKhau()
        {
            InitializeComponent();
            controller = new QuenMatKhauController(this);
        }

        private void Quenmk_Load(object sender, EventArgs e)
        {
            anThongBao();
            btnGuiMa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGuiMa.Width, btnGuiMa.Height, 20, 20));
            btnXacNhan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnXacNhan.Width, btnXacNhan.Height, 20, 20));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 15, 15));
            textBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox2.Width, textBox2.Height, 15, 15));
        }

        private void anThongBao()
        {
            labelKhongTimThayTaiKhoan.Hide();
            labelDaGuiMaXacNhan.Hide();
            labelMaXacNhanKhongChinhXac.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new DangNhap());
        }

        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            try
            {
                anThongBao();
                controller.guiMaXacNhan(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void hienThongBaoEmail()
        {
            labelKhongTimThayTaiKhoan.Show();
        }

        public void hienThongBaoMaXacNhanKhongChinhXac()
        {
            labelMaXacNhanKhongChinhXac.Show();
        }
        public void hienThongBaoDaGuiMaXacNhan()
        {
            labelDaGuiMaXacNhan.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                controller.xuLiDatMatKhau(textBox2.Text, textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox?.Text.Length > 6)
            {
                textBox.Text = textBox.Text.Substring(0, 6);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }
    }
}
