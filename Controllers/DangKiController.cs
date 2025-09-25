using App.Models;
using App.Views;
using App.Utilities;

namespace App.Controllers
{
    internal class DangKiController
    {
        private DangKiModel model;
        private DangKi view;
        private string? maXacNhan;

        public DangKiController(DangKi view)
        {
            this.view = view;
            this.model = new DangKiModel();
        }

        public void xuLiDangKi(string email,string matKhau, string xacNhanMatKhau, string maXacNhan)
        {
            bool thongTinHopLe = true;
            if (!Helpers.kiemTraEmailHopLe(email))
            {
                view.hienThiEmailKhongHopLe();
                thongTinHopLe = false;
            }
            if (matKhau.Trim() == "") 
            {
                view.hienThiMatKhauTrong();
                thongTinHopLe = false;
            }
            if (matKhau != xacNhanMatKhau)
            {
                view.hienThiMatKhauKhongKhop();
                thongTinHopLe = false;
            }
            if (maXacNhan != this.maXacNhan || this.maXacNhan == null)
            {
                view.hienThiMaXacNhanKhongChinhXac();
                thongTinHopLe = false;
            }
            if (thongTinHopLe)
            {
                this.maXacNhan = null;
                try
                {
                    string matKhauMaHoa = Helpers.maHoaMatKhau(matKhau);
                    bool dangKiThanhCong = model.luuTaiKhoan(email, matKhauMaHoa);

                    if (dangKiThanhCong)
                    {
                        view.dangKiThanhCong();

                        DangNhap dangNhap = new DangNhap();
                        Helpers.chuyenForm(dangNhap);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public void guiMaXacNhan(string email)
        {
            if (!Helpers.kiemTraEmailHopLe(email))
            {
                view.hienThiEmailKhongHopLe();
                return;
            }
            try
            {
                maXacNhan = Helpers.taoMaXacNhan();
                bool guiThanhCong = model.guiMaXacNhan(email, maXacNhan);

                if (guiThanhCong)
                {
                    view.hienThiMaXacNhanGuiThanhCong();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
