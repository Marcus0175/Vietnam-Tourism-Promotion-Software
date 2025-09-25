using App.Views;
using App.Utilities;
using System.Windows.Forms;

namespace App.Controllers
{
    internal class TinhThanhController
    {
        private Views.TinhThanh view;
        public TinhThanhController(Views.TinhThanh view)
        {
            this.view = view;
        }

        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }

        public void hienThongTin(string iPath, string tPath)
        {
            string imagePath = Path.Combine(Application.StartupPath, "TinhThanh", iPath);
            string filePath = Path.Combine(Application.StartupPath, "TinhThanh", tPath);
            if (File.Exists(imagePath))
            {
                view.pictureBox3.Image = Image.FromFile(imagePath);
            }
            else
            {
                view.pictureBox3.Image = null;
            }
            view.label3.Text = File.ReadAllText(filePath);
            view.label3.MaximumSize = new 
            System.Drawing.Size(view.panel1.Width - 50, int.MaxValue);
        }
    }
}
