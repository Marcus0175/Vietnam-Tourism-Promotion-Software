using App.Controllers;
using App.Utilities;
using System.Runtime.InteropServices;

namespace App.Views
{
    public partial class DangKi : Form
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
        private DangKiController controller;
        public DangKi()
        {
            InitializeComponent();
            controller = new DangKiController(this);
        }

        private void dangKiLoad(object sender, EventArgs e)
        {
            anThongBao();
            this.ActiveControl = lbDangNhap;
            btnGuiMa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnGuiMa.Width, btnGuiMa.Height, 20, 20));
            btnDangKy.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangKy.Width, btnDangKy.Height, 20, 20));
            textBoxEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxEmail.Width, textBoxEmail.Height, 10, 10));
            textBoxMatKhau.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxMatKhau.Width, textBoxMatKhau.Height, 15, 15));
            textBoxXacNhanMatKhau.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxXacNhanMatKhau.Width, textBoxXacNhanMatKhau.Height, 15, 15));
            textBoxMaXacNhan.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxMaXacNhan.Width, textBoxMaXacNhan.Height, 15, 15));
        }

        public void hienThiEmailKhongHopLe()
        {
            labelEmailKhongHopLe.Show();
        }

        public void anEmailKhongHopLe()
        {
            labelEmailKhongHopLe.Hide();
        }
        public void hienThiMatKhauTrong()
        {
            labelMatKhauTrong.Show();
        }

        public void hienThiMatKhauKhongKhop()
        {
            labelMatKhauKhongTrungKhop.Show();
        }
        public void anHienThiMatKhauKhongKhop()
        {
            labelMatKhauKhongTrungKhop.Hide();
        }

        public void hienThiMaXacNhanKhongChinhXac()
        {
            labelMaXacNhanKhongChinhXac.Show();
        }

        public void hienThiMaXacNhanGuiThanhCong()
        {
            labelMaXacNhanDaGui.Show();
        }

        private void checkBoxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMatKhau.UseSystemPasswordChar = !checkBoxHienMatKhau.Checked;
            textBoxXacNhanMatKhau.UseSystemPasswordChar = !checkBoxHienMatKhau.Checked;
        }

        public void anThongBao()
        {
            labelMatKhauTrong.Hide();
            labelEmailKhongHopLe.Hide();
            labelMatKhauKhongTrungKhop.Hide();
            labelMaXacNhanDaGui.Hide();
            labelMaXacNhanKhongChinhXac.Hide();
        }

        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            try
            {
                anThongBao();
                controller.guiMaXacNhan(textBoxEmail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            anThongBao();
            try
            {
                controller.xuLiDangKi(textBoxEmail.Text, textBoxMatKhau.Text, textBoxXacNhanMatKhau.Text, textBoxMaXacNhan.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxMaXacNhan_TextChanged(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox?.Text.Length > 6)
            {
                textBox.Text = textBox.Text.Substring(0, 6);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void textBoxMaXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void dangKiThanhCong()
        {
            MessageBox.Show("Đăng kí tài khoản thành công. Quay về trang đăng nhập để tiếp tục");
        }

        private void textBoxXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text != textBoxXacNhanMatKhau.Text)
            {
                hienThiMatKhauKhongKhop();
            }
            else
            {
                anHienThiMatKhauKhongKhop();
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Helpers.kiemTraEmailHopLe(textBoxEmail.Text))
            {
                hienThiEmailKhongHopLe();
            }
            else
            {
                anEmailKhongHopLe();
            }
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            Helpers.chuyenForm(dangNhap);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
