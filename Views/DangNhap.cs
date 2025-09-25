using App.Controllers;
using App.Utilities;
using System.Runtime.InteropServices;

namespace App.Views
{
    public partial class DangNhap : Form
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
        private DangNhapController controller;
        public DangNhap()
        {
            InitializeComponent();
            controller = new DangNhapController(this);
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            anLoiDangNhap();
            tuDongDienThongTin();
            this.ActiveControl = lbDangKy;
            btnDangNhap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangNhap.Width, btnDangNhap.Height, 20, 20));
            textBoxEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxEmail.Width, textBoxEmail.Height, 15, 15));
            textBoxMatKhau.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxMatKhau.Width, textBoxMatKhau.Height, 15, 15));
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            anLoiDangNhap();
            try
            {
                controller.xuLyDangNhap(textBoxEmail.Text, textBoxMatKhau.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void hienThiLoiEmail()
        {
            labelLoiEmail.Show();
        }
        public void hienThiLoiMatKhau()
        {
            labelLoiMatKhau.Show();
        }
        public void anLoiDangNhap()
        {
            labelLoiEmail.Hide();
            labelLoiMatKhau.Hide();
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new DangKi());
        }

        private void checkBoxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHienMatKhau.Checked)
            {
                textBoxMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void tuDongDienThongTin()
        {
            textBoxEmail.Text = Properties.Settings.Default.Email;
            textBoxMatKhau.Text = Properties.Settings.Default.MatKhau;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new QuenMatKhau());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
