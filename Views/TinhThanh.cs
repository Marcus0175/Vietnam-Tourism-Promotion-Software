using App.Controllers;
using App.Utilities;
using HoTro;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace App.Views
{
    public partial class TinhThanh : Form
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
        private TinhThanhController controller;
        public TinhThanh()
        {
            InitializeComponent();
            controller = new TinhThanhController(this);
        }

        private void HCM_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 10, 10));
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "2";
            chonTinhThanh(button6);
            controller.hienThongTin("BD.jpeg", "BD.txt");
        }

        private void chonTinhThanh(Button button)
        {
            button10.ForeColor = Color.Black;
            button4.ForeColor = Color.Black;
            button6.ForeColor = Color.Black;
            button7.ForeColor = Color.Black;
            button8.ForeColor = Color.Black;
            button9.ForeColor = Color.Black;

            button.ForeColor = Color.DodgerBlue;
        }

        private void btnDiemDen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDiTich_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBaoTang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new Home());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "0";
            chonTinhThanh(button4);
            controller.hienThongTin("TpHCM.jpg", "HCM.txt");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "1";
            chonTinhThanh(button10);
            controller.hienThongTin("BR-VT.jpg", "BRVT.txt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "3";
            chonTinhThanh(button7);
            controller.hienThongTin("BinhPhuoc.jpg", "BP.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "5";
            chonTinhThanh(button8);
            controller.hienThongTin("DongNai.jpg", "DN.txt");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "4";
            chonTinhThanh(button9);
            controller.hienThongTin("TayNinh.jpg", "TN.txt");
        }

        public void clickTrigger(Button button)
        {
            button.PerformClick();
        }

        private void btnDiemDen_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            KhamPha kp = new KhamPha();
            kp.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LienHe lienHe = new LienHe();
            lienHe.Show();
        }
    }
}
