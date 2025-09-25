using App.Controllers;
using App.Utilities;
using HoTro;
using System.Runtime.InteropServices;

namespace App.Views;

public partial class Admin : Form
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
    private AdminController controller;
    public Admin()
    {
        InitializeComponent();
        controller = new AdminController(this);
        TinhThanhHienTai.tinhThanhHienTai.maTinh = null;
    }

    private void lbDiemDen_Click(object sender, EventArgs e)
    {
        try
        {
            if (TinhThanhHienTai.tinhThanhHienTai.maTinh != null)
            {
                controller.soLuongDiaDanhTheoBoLoc(TinhThanhHienTai.tinhThanhHienTai.maTinh, lbDiemDen.Text);
            }
            else
            {
                controller.soLuongDiaDanhTheoLoai(lbDiemDen.Text);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void Admin_Load(object sender, EventArgs e)
    {
        try
        {
            controller.hienThiTatCaDiaDanh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        btnDangXuat.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDangXuat.Width, btnDangXuat.Height, 20, 20));
        button15.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button15.Width, button15.Height, 20, 20));
        button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
    }

    private void lbDiTich_Click(object sender, EventArgs e)
    {
        try
        {
            if (TinhThanhHienTai.tinhThanhHienTai.maTinh != null)
            {
                controller.soLuongDiaDanhTheoBoLoc(TinhThanhHienTai.tinhThanhHienTai.maTinh, lbDiTich.Text);
            }
            else
            {
                controller.soLuongDiaDanhTheoLoai(lbDiTich.Text);
            }
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
    private void lbBaoTang_Click(object sender, EventArgs e)
    {
        try
        {
            if (TinhThanhHienTai.tinhThanhHienTai.maTinh != null)
            {
                controller.soLuongDiaDanhTheoBoLoc(TinhThanhHienTai.tinhThanhHienTai.maTinh, lbBaoTang.Text);
            }
            else
            {
                controller.soLuongDiaDanhTheoLoai(lbBaoTang.Text);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
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
    private void button15_Click(object sender, EventArgs e)
    {
        controller.denTrangTruocDo();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        controller.denTrangKeTiep();
    }
    public void suaThongTinClick(object sender, EventArgs e)
    {
        try
        {
            if (NguoiDungHienTai.nguoiDungHienTai.phanQuyen < 2)
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này");
                return;
            }
            if (sender is Control control && control.Tag is string tag)
            {
                controller.chuyenForm(new SuaThongTin(tag));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    public void duyetBinhLuanClick(object sender, EventArgs e)
    {
        try
        {
            if (NguoiDungHienTai.nguoiDungHienTai.phanQuyen == 2)
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này");
                return;
            }
            if (sender is Control control && control.Tag is string tag)
            {
                controller.chuyenForm(new DuyetBinhLuan(tag));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnDangXuat_Click(object sender, EventArgs e)
    {
        NguoiDungHienTai.nguoiDungHienTai = null;
        controller.chuyenForm(new Home());
    }

    private void btnTroGiup_Click(object sender, EventArgs e)
    {
        LienHe lienhe = new LienHe();
        lienhe.Show();
        this.Hide();
    }
}
