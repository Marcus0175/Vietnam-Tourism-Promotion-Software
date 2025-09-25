using App.Controllers;
using App.Utilities;
using Chatbot;
using HoTro;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace App.Views;

public partial class ThongTinChiTietDiaDanh : Form
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
    private ThongTinChiTietDiaDanhController controller;
    private string maDiaDanh;
    public ThongTinChiTietDiaDanh(string maDiaDanh)
    {
        InitializeComponent();
        this.maDiaDanh = maDiaDanh;
        controller = new ThongTinChiTietDiaDanhController(this);
    }

    public void ThongTinChiTietDiaDanh_Load(object sender, EventArgs e)
    {
        pictureBox2.Parent = pictureBox1;
        try
        {
            labelLoiBinhLuan.Hide();
            voHieuHoaNutBam();
            if (maDiaDanh != null)
            {
                controller.thongTinDiaDanhHienTai(maDiaDanh);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        btnQuayLai.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnQuayLai.Width, btnQuayLai.Height, 15, 15));
        btnTrangChu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTrangChu.Width, btnTrangChu.Height, 15, 15));
        btnDiemDen.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDiemDen.Width, btnDiemDen.Height, 20, 20));
        btnDiTich.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDiTich.Width, btnDiTich.Height, 20, 20));
        btnBaoTang.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBaoTang.Width, btnBaoTang.Height, 20, 20));
        panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
        panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 15, 15));
        textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 15, 15));
    }
    private void ThongTinChiTietDiaDanh_KeyDown(object sender, KeyEventArgs e)
    {
        if (textBox1.Focused == true)
        {
            if (NguoiDungHienTai.nguoiDungHienTai == null)
            {
                labelLoiBinhLuan.Show();
            }
            else
            {
                labelLoiBinhLuan.Hide();
                if (e.KeyCode == Keys.Enter && textBox1.Text != "")
                {
                    try
                    {
                        controller.luuBinhLuan(textBox1.Text, maDiaDanh);
                        controller.loadBinhLuan(maDiaDanh);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        else if (textBox2.Focused == true)
        {
            if (e.KeyCode == Keys.Enter)
            {
                controller.dungThuyetMinh();
                controller.timKiemDiaDanhTheoTen(textBox2.Text);
            }
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        if (NguoiDungHienTai.nguoiDungHienTai == null)
        {
            labelLoiBinhLuan.Show();
        }
        else
        {
            labelLoiBinhLuan.Hide();
        }
    }

    private void btnTrangChu_Click(object sender, EventArgs e)
    {
        controller.dungThuyetMinh();
        controller.chuyenForm(new Home());
    }

    private void btnQuayLai_Click(object sender, EventArgs e)
    {
        controller.dungThuyetMinh();
        controller.chuyenForm(new DanhSachDiaDanh());
    }

    private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
    {
        int width = pictureBox3.Width;

        if (e.X > width / 2)
        {
            controller.loadHinhAnhSau();
        }
        else // Left side of the image
        {
            controller.loadHinhAnhTruoc();
        }
    }



    private void progressBar1_MouseDown(object sender, MouseEventArgs e)
    {
        try
        {
            int newPosition = (int)((e.X / (float)progressBar1.Width) * progressBar1.Maximum);
            controller.datViTriBatDau(newPosition);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void voHieuHoaNutBam()
    {
        btnDiemDen.Enabled = false;
        btnBaoTang.Enabled = false;
        btnDiTich.Enabled = false;
        button4.Enabled = false;
        button6.Enabled = false;
        button7.Enabled = false;
        button10.Enabled = false;
        button9.Enabled = false;
        button8.Enabled = false;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnDiemDen_Click(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        controller.dungThuyetMinh();
        DanhSachDiaDanh ds = new DanhSachDiaDanh();
        ds.Show();
        this.Hide();
    }

    private void btnChatBot_Click(object sender, EventArgs e)
    {
        ChatBot chatbot = new ChatBot();
        chatbot.Show();
    }

    private void btnTroGiup_Click(object sender, EventArgs e)
    {
        LienHe lienHe = new LienHe();
        lienHe.Show();
    }

    private void btnPlayPause_Click(object sender, EventArgs e)
    {
        try
        {
            this.ActiveControl = null;
            controller.chayThuyetMinh();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {

    }
}
