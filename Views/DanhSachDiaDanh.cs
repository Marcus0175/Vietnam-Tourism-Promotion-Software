using App.Utilities;
using App.Controllers;
using System.Runtime.InteropServices;
using Chatbot;
using HoTro;

namespace App.Views;

public partial class DanhSachDiaDanh : Form
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
    private DanhSachDiaDanhController controller;
    public DanhSachDiaDanh()
    {
        InitializeComponent();
        controller = new DanhSachDiaDanhController(this);
    }
    private void label6_Click(object sender, EventArgs e)
    {

    }
    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
    private void Listdiadanhhcm_Load(object sender, EventArgs e)
    {
        ThongBaoLoi.Parent = pictureBox1;
        pictureBox2.Parent = pictureBox1;
        try
        {
            controller.hienThiTatCaDiaDanh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        btnBaoTang.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBaoTang.Width, btnBaoTang.Height, 20, 20));
        btnDiTich.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDiTich.Width, btnDiTich.Height, 20, 20));
        btnDiTich.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDiTich.Width, btnDiTich.Height, 20, 20));
        btnDiemDen.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDiemDen.Width, btnDiemDen.Height, 20, 20));
        button12.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button12.Width, button12.Height, 10, 10));
        button13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button13.Width, button13.Height, 10, 10));
        button14.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button14.Width, button14.Height, 10, 10));
        btnTruoc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTruoc.Width, btnTruoc.Height, 10, 10));
        btnTiep.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTiep.Width, btnTiep.Height, 10, 10));
        textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 10, 10));
        btnTrangChu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTrangChu.Width, btnTrangChu.Height, 20, 20));
    }
    private void button4_Click(object sender, EventArgs e)
    {
        try
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "0";
            chonTinhThanh(button4);
            controller.soLuongDiaDanhTheoTinh(TinhThanhHienTai.tinhThanhHienTai.maTinh);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void btnBaoTang_Click(object sender, EventArgs e)
    {
        try
        {
            if (TinhThanhHienTai.tinhThanhHienTai.maTinh != null)
            {
                controller.soLuongDiaDanhTheoBoLoc(TinhThanhHienTai.tinhThanhHienTai.maTinh, btnBaoTang.Text);
            }
            else
            {
                controller.soLuongDiaDanhTheoLoai(btnBaoTang.Text);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void btnTruoc_Click(object sender, EventArgs e)
    {
        controller.denTrangTruocDo();
    }
    private void btnTiep_Click(object sender, EventArgs e)
    {
        controller.denTrangKeTiep();
    }
    private void btnDiemDen_Click(object sender, EventArgs e)
    {
        try
        {
            if (TinhThanhHienTai.tinhThanhHienTai.maTinh != null)
            {
                controller.soLuongDiaDanhTheoBoLoc(TinhThanhHienTai.tinhThanhHienTai.maTinh, btnDiemDen.Text);
            }
            else
            {
                controller.soLuongDiaDanhTheoLoai(btnDiemDen.Text);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void btnDiTich_Click(object sender, EventArgs e)
    {
        try
        {
            if (TinhThanhHienTai.tinhThanhHienTai.maTinh != null)
            {
                controller.soLuongDiaDanhTheoBoLoc(TinhThanhHienTai.tinhThanhHienTai.maTinh, btnDiTich.Text);
            }
            else
            {
                controller.soLuongDiaDanhTheoLoai(btnDiTich.Text);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void button10_Click(object sender, EventArgs e)
    {
        try
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "1";
            chonTinhThanh(button10);
            controller.soLuongDiaDanhTheoTinh(TinhThanhHienTai.tinhThanhHienTai.maTinh);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void button6_Click(object sender, EventArgs e)
    {
        try
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "2";
            chonTinhThanh(button6);
            controller.soLuongDiaDanhTheoTinh(TinhThanhHienTai.tinhThanhHienTai.maTinh);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
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
    private void button7_Click(object sender, EventArgs e)
    {
        try
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "3";
            chonTinhThanh(button7);
            controller.soLuongDiaDanhTheoTinh(TinhThanhHienTai.tinhThanhHienTai.maTinh);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void button8_Click(object sender, EventArgs e)
    {
        try
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "5";
            chonTinhThanh(button8);
            controller.soLuongDiaDanhTheoTinh(TinhThanhHienTai.tinhThanhHienTai.maTinh);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void button9_Click(object sender, EventArgs e)
    {
        try
        {
            TinhThanhHienTai.tinhThanhHienTai.maTinh = "4";
            chonTinhThanh(button9);
            controller.soLuongDiaDanhTheoTinh(TinhThanhHienTai.tinhThanhHienTai.maTinh);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void DanhSachDiaDanh_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && textBox1.Text != "")
        {
            triggerKeyDown(textBox1.Text);
        }
    }
    private void btnTrangChu_Click(object sender, EventArgs e)
    {
        controller.chuyenForm(new Home());
    }
    public void clickEvent(object sender, EventArgs e)
    {
        try
        {
            if (sender is Control control && control.Tag is string tag)
            {
                controller.capNhatLuotXem(tag);
                controller.chuyenForm(new ThongTinChiTietDiaDanh(tag));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public void triggerKeyDown(string tenDiaDanh)
    {
        try
        {
            controller.soLuongDiaDanhTheoTen(tenDiaDanh);
            textBox1.Text = null;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        KhamPha kp = new KhamPha();
        kp.Show();
        this.Hide();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnChatBot_Click(object sender, EventArgs e)
    {
        ChatBot chatbot = new ChatBot();
        chatbot.Show();
    }
    public void buttonClickEvent(object sender, EventArgs e)
    {
        try
        {
            if (sender is Control control && control.Tag is string tag)
            {
                ChiDuong chiDuong = new ChiDuong(tag);
                chiDuong.Show();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }



    private void btnMap_Click(object sender, EventArgs e)
    {
        ChiDuong chiduong = new ChiDuong(Tag);
        chiduong.Show();
    }

    private void btnTroGiup_Click(object sender, EventArgs e)
    {
        LienHe lienhe = new LienHe();
        lienhe.Show();
        this.Hide();
    }

    private void button12_Click(object sender, EventArgs e)
    {

    }

    private void ThongBaoLoi_Click(object sender, EventArgs e)
    {

    }
}
