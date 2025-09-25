using App.Utilities;
using App.Views;

namespace App.Controllers
{
    internal class KhamPhaController
    {
        private KhamPha view;
        private Views.TinhThanh tinhThanh;
        public KhamPhaController(KhamPha view)
        {
            this.view = view;
        }

        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }

        public void chuyenFormClick(string btn)
        {
            tinhThanh = new Views.TinhThanh();
            tinhThanh.Show();
            if (btn == "HCM")
            {
                tinhThanh.clickTrigger(tinhThanh.button4);
            }
            else if (btn == "BD")
            {
                tinhThanh.clickTrigger(tinhThanh.button6);
            }
            else if (btn == "BP")
            {
                tinhThanh.clickTrigger(tinhThanh.button7);
            }
            else if (btn == "BRVT")
            {
                tinhThanh.clickTrigger(tinhThanh.button10);
            }
            else if (btn == "TN")
            {
                tinhThanh.clickTrigger(tinhThanh.button8);
            }
            else
            {
                tinhThanh.clickTrigger(tinhThanh.button9);
            }
        }

        public void soLuongDiaDanhTheoTen(string tenDiaDanh)
        {
            DanhSachDiaDanh danhSachDiaDanh = new DanhSachDiaDanh();
            danhSachDiaDanh.Show();
            danhSachDiaDanh.triggerKeyDown(tenDiaDanh);
            view.Hide();
        }
    }
}
