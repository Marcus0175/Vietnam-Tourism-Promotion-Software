using App.Views;
using App.Utilities;
using App.Models;
using System.ComponentModel;

namespace App.Controllers
{
    internal class DuyetBinhLuanController
    {
        private DuyetBinhLuanModel model;
        private DuyetBinhLuan view;
        private List<BinhLuan> binhLuan;

        public DuyetBinhLuanController(DuyetBinhLuan view)
        {
            this.view = view;
            this.model = new DuyetBinhLuanModel();
        }
        public void loadBinhLuan(string maDiaDanh)
        {
            try
            {
                binhLuan = model.layBinhLuan(maDiaDanh);
                BindingList<BinhLuan> binhLuanList = new BindingList<BinhLuan>(binhLuan);

                view.dataGridView1.DataSource = binhLuanList;
                view.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                view.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception) { throw; }
        }
        public void xoaBinhLuan(int maBinhLuan)
        {
            try
            {
                model.xoaBinhLuan(maBinhLuan);
            }
            catch (Exception) { throw; }
        }

        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }
    }
}
