using App.Controllers;
using Chatbot;
using HoTro;
using System.Runtime.InteropServices;

namespace App.Views
{
    public partial class KhamPha : Form
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
        private KhamPhaController controller;
        public KhamPha()
        {
            InitializeComponent();
            controller = new KhamPhaController(this);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            controller.chuyenFormClick("HCM");
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new Home());
        }

        private void Diadanh_Load(object sender, EventArgs e)
        {
            label2.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            btnXemTatCa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnXemTatCa.Width, btnXemTatCa.Height, 20, 20));
            btnTrangChu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTrangChu.Width, btnTrangChu.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 10, 10));
            btnChatBot.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnChatBot.Width, btnChatBot.Height, 40, 40));
            btnTroGiup.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTroGiup.Width, btnTroGiup.Height, 20, 20));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new DanhSachDiaDanh());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            controller.chuyenFormClick("BD");
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            controller.chuyenFormClick("BP");
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            controller.chuyenFormClick("TN");
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            controller.chuyenFormClick("DN");
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            controller.chuyenFormClick("BRVT");
            this.Hide();
        }

        private void DanhSachDiaDanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")
            {
                try
                {
                    controller.soLuongDiaDanhTheoTen(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new DanhSachDiaDanh());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnChatBot_Click(object sender, EventArgs e)
        {
            ChatBot chatbot = new ChatBot();
            chatbot.Show();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            LienHe lienhe = new LienHe();
            lienhe.Show();
        }
    }
}
