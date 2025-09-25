using App.Controllers;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace App.Views
{
    public partial class DuyetBinhLuan : Form
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
        private DuyetBinhLuanController controller;
        private string maDiaDanh;
        public DuyetBinhLuan(string maDiaDanh)
        {
            InitializeComponent();
            controller = new DuyetBinhLuanController(this);
            this.maDiaDanh = maDiaDanh;
        }

        private void DuyetBinhLuan_Load(object sender, EventArgs e)
        {
            controller.loadBinhLuan(maDiaDanh);
            voHieuHoaNutBam();
            btnQuayLai.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnQuayLai.Width, btnQuayLai.Height, 20, 20));
        }
        private void dataGridViewBinhLuan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int maBinhLuan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["maBinhLuan"].Value);
                    controller.xoaBinhLuan(maBinhLuan);
                    controller.loadBinhLuan(maDiaDanh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            controller.chuyenForm(new Admin());
        }
        private void voHieuHoaNutBam()
        {
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}