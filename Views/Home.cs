using App.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Controllers;
using App.Utilities;
using System.Runtime.InteropServices;
using Chatbot;
using HoTro;

namespace App.Views
{
    public partial class Home : Form
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
        HomeController controller;
        public Home()
        {
            InitializeComponent();
            controller = new HomeController(this);
        }

        private void Home_Load(object sender, EventArgs e)
        {

            if (NguoiDungHienTai.nguoiDungHienTai != null)
            {
                btnDangNhap.Text = NguoiDungHienTai.nguoiDungHienTai.email;
                btnDangNhap.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btnDangKy.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btnDangKy.Text = "Đăng Xuất";
            }
            btnKhamPha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnKhamPha.Width, btnKhamPha.Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Helpers.chuyenForm(new DangNhap());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Helpers.chuyenForm(new KhamPha());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (NguoiDungHienTai.nguoiDungHienTai == null)
            {
                Helpers.chuyenForm(new DangKi());
            }
            else
            {
                controller.dangXuatTaiKhoan();
            }
        }

        private void btnChatBot_Click(object sender, EventArgs e)
        {
            ChatBot chatbot = new ChatBot();
            chatbot.Show();
        }
        private void lbTroGiup_Click_1(object sender, EventArgs e)
        {
            LienHe lienHe = new LienHe();
            lienHe.Show();
        }

        private void chatbot_Click(object sender, EventArgs e)
        {
            ChatBot chatbot = new ChatBot();
            chatbot.Show();
        }
    }
}
