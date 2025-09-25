using App.Models;
using App.Views;
using App.Utilities;
using System.Diagnostics.Eventing.Reader;
namespace App.Controllers
{
    internal class QuenMatKhauController
    {
        private QuenMatKhauModel model;
        private QuenMatKhau view;
        private string? maXacNhan;

        public QuenMatKhauController(QuenMatKhau view)
        {
            this.view = view;
            this.model = new QuenMatKhauModel();
        }

        public void xuLiDatMatKhau(string maXacNhan, string email)
        {
            if (maXacNhan != this.maXacNhan)
            {
                view.hienThongBaoMaXacNhanKhongChinhXac();
                return;
            }
            else
            {
                chuyenForm(new DatMatKhauMoi(email));
            }
            
        }
        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }
        public void guiMaXacNhan(string email)
        {
            try
            {
                bool kiemTraEmail = model.kiemTraEmail(email);
                if (!kiemTraEmail)
                {
                    view.hienThongBaoEmail();
                    return;
                }
                else
                {
                    maXacNhan = Helpers.taoMaXacNhan();
                    bool guiThanhCong = model.guiMaXacNhan(email, maXacNhan);

                    if (guiThanhCong)
                    {
                        view.hienThongBaoDaGuiMaXacNhan();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
