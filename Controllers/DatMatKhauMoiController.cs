using App.Views;
using App.Models;
using App.Utilities;

namespace App.Controllers
{
    internal class DatMatKhauMoiController
    {
        private DatMatKhauMoiModel model;
        private DatMatKhauMoi view;

        public DatMatKhauMoiController(DatMatKhauMoi view)
        {
            this.view = view;
            this.model = new DatMatKhauMoiModel();
        }

        public void datLaiMatKhau(string matKhau, string email)
        {
            try
            {
                string matKhauMaHoa = Helpers.maHoaMatKhau(matKhau);
                model.luuMatKhauMoi(email, matKhauMaHoa);
                Helpers.chuyenForm(new DangNhap());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
