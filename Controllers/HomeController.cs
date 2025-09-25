using App.Views;
using App.Utilities;

namespace App.Controllers
{
    internal class HomeController
    {
        private Home view;

        public HomeController(Home view)
        {
            this.view = view;
        }

        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }
         
        public void dangXuatTaiKhoan()
        {
            NguoiDungHienTai.nguoiDungHienTai = null;
            Helpers.chuyenForm(new Home());
        }
    }
}
