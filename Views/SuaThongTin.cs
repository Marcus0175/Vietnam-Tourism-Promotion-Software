using App.Controllers;
using System.Runtime.InteropServices;

namespace App.Views
{

    public partial class SuaThongTin : Form
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
        private SuaThongTinController controller;
        private string maDiaDanh;
        public SuaThongTin(string maDiaDanh)
        {
            InitializeComponent();
            this.maDiaDanh = maDiaDanh;
            controller = new SuaThongTinController(this);
        }

        public void SuaThongTin_Load(object sender, EventArgs e)
        {
            controller.thongTinDiaDanhHienTai(maDiaDanh);
            textBox1.Enabled = false;
            voHieuHoaNutBam();
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));
            button16.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button16.Width, button16.Height, 20, 20));
            button17.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button17.Width, button17.Height, 20, 20));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new Admin());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            controller.thongTinDiaDanhHienTai(maDiaDanh);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            controller.loadTxt();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            controller.loadMp3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.loadJpg("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.loadJpg("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.loadJpg("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            controller.loadJpg("4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            controller.loadJpg("5");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            controller.luuThongTin(maDiaDanh, textBox4.Text);
        }
        private void voHieuHoaNutBam()
        {
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
