using App.Models;
using App.Views;
using App.Utilities;

namespace App.Controllers
{
    internal class DangNhapController
    {
        private DangNhapModel model;
        private DangNhap view;

        public DangNhapController(DangNhap view)
        {
            this.view = view;
            this.model = new DangNhapModel();
        }

        public void xuLyDangNhap(string email, string matkhau)
        {
            try
            {
                string matKhauMaHoa = Helpers.maHoaMatKhau(matkhau);
                NguoiDungHienTai.nguoiDungHienTai = model.xacThucDangNhap(email, matKhauMaHoa);
                bool xacThucEmail = model.xacThucEmail(email);

                if (NguoiDungHienTai.nguoiDungHienTai != null)
                {
                    if (NguoiDungHienTai.nguoiDungHienTai.phanQuyen == 0)
                    {
                        Helpers.luuThongTin(email, matkhau);
                        chuyenForm(new Home());
                    }
                    else
                    {
                        Helpers.luuThongTin(email, matkhau);
                        chuyenForm(new Admin());
                    }
                }
                else
                {
                    if (!xacThucEmail)
                    {
                        view.hienThiLoiEmail();
                    }
                    else
                    {
                        view.hienThiLoiMatKhau();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }
    }
}
