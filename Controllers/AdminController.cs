using App.Models;
using App.Views;
using App.Utilities;

namespace App.Controllers
{
    internal class AdminController
    {
        private AdminModel model;
        private Admin view;
        private int trangHienTai;
        private int kichThuocTrang = 10;
        private int soLuong;
        private int soLuongTrang;
        private string? tinhThanh;
        private string? maTinh;
        private string? loaiDiaDanh;
        private string? tenDiaDanh;
        private string tieuChi;

        public AdminController(Admin view)
        {
            this.view = view;
            this.model = new AdminModel();
        }
        public void soLuongDiaDanhTheoBoLoc(string maTinh, string loaiDiaDanh)
        {
            trangHienTai = 0;
            this.maTinh = maTinh;
            this.loaiDiaDanh = loaiDiaDanh;
            soLuong = model.timKiemTheoBoLoc(maTinh, loaiDiaDanh);
            soLuongTrang = (int)Math.Ceiling((double)soLuong / kichThuocTrang);
            tieuChi = "BoLoc";
            taiTrang();
        }
        public void soLuongDiaDanhTheoLoai(string loaiDiaDanh)
        {
            trangHienTai = 0;
            this.loaiDiaDanh = loaiDiaDanh;
            soLuong = model.timKiemTheoLoai(loaiDiaDanh);
            soLuongTrang = (int)Math.Ceiling((double)soLuong / kichThuocTrang);
            tieuChi = "Loai";
            taiTrang();
        }
        public void soLuongDiaDanhTheoTinh(string maTinh)
        {
            trangHienTai = 0;
            this.maTinh = maTinh;
            soLuong = model.timKiemTheoTinhThanh(maTinh);
            soLuongTrang = (int)Math.Ceiling((double)soLuong / kichThuocTrang);
            tieuChi = "Tinh";
            taiTrang();
        }
        public void hienThiTatCaDiaDanh()
        {
            trangHienTai = 0;
            soLuong = model.timKiemTatCa();
            soLuongTrang = (int)Math.Ceiling((double)soLuong / kichThuocTrang);
            taiTrang();
        }
        public void hienThiDiaDanh()
        {
            try
            {
                view.panel4.Controls.Clear();
                view.panel5.Controls.Clear();
                view.panel6.Controls.Clear();
                view.panel7.Controls.Clear();
                view.panel8.Controls.Clear();
                view.panel9.Controls.Clear();
                view.panel10.Controls.Clear();
                view.panel11.Controls.Clear();
                view.panel12.Controls.Clear();
                view.panel13.Controls.Clear();

                int startIndex = trangHienTai * kichThuocTrang;
                int endIndex = Math.Min(startIndex + kichThuocTrang, soLuong);

                List<ThongTinDiaDanh> danhSachDiaDanh;

                if (tieuChi == "BoLoc")
                {
                    danhSachDiaDanh = model.layThongTinDiaDanhTheoBoLoc(startIndex, kichThuocTrang, maTinh, loaiDiaDanh);
                }
                else if (tieuChi == "Ten")
                {
                    danhSachDiaDanh = model.layThongTinDiaDanhTheoTen(startIndex, kichThuocTrang, tenDiaDanh);
                }
                else if (tieuChi == "Loai")
                {
                    danhSachDiaDanh = model.layThongTinTheoLoai(startIndex, kichThuocTrang, loaiDiaDanh);
                }
                else if (tieuChi == "Tinh")
                {
                    danhSachDiaDanh = model.layThongTinTheoTinhThanh(startIndex, kichThuocTrang, maTinh);
                }
                else
                {
                    danhSachDiaDanh = model.layThongTinTatCa(startIndex, kichThuocTrang);
                }

                int i = 0;

                foreach (var diaDanh in danhSachDiaDanh)
                {
                    Panel panel = new Panel { Size = new Size(852, 60) };

                    Label nameLabel = new Label
                    {
                        Text = (i+startIndex+1).ToString() + ". " + diaDanh.tenDiaDanh,
                        Location = new Point(20, 17),
                        AutoSize = true,
                        Font = new Font("Arial", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0),
                        Margin = new Padding(5, 0, 5, 0),
                        Size = new Size(148, 23),
                        Tag = diaDanh.maDiaDanh,
                    };
                    Label duyetBinhLuanLabel = new Label
                    {
                        Text = "Duyệt bình luận",
                        Location = new Point(554, 17),
                        AutoSize = true,
                        Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Margin = new Padding(5, 0, 5, 0),
                        Size = new Size(145, 23),
                        Tag = diaDanh.maDiaDanh,
                    };
                    duyetBinhLuanLabel.Click += view.duyetBinhLuanClick;

                    Label suaThongTinLabel = new Label
                    {
                        Text = "Sửa thông tin",
                        Location = new Point(702, 17),
                        AutoSize = true,
                        Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Margin = new Padding(5, 0, 5, 0),
                        Size = new Size(127, 23),
                        Tag = diaDanh.maDiaDanh,
                    };
                    suaThongTinLabel.Click += view.suaThongTinClick;

                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(suaThongTinLabel);
                    panel.Controls.Add(duyetBinhLuanLabel);

                    if (i == 0) view.panel4.Controls.Add(panel);
                    else if (i == 1) view.panel5.Controls.Add(panel);
                    else if (i == 2) view.panel6.Controls.Add(panel);
                    else if (i == 3) view.panel7.Controls.Add(panel);
                    else if (i == 4) view.panel8.Controls.Add(panel);
                    else if (i == 5) view.panel9.Controls.Add(panel);
                    else if (i == 6) view.panel10.Controls.Add(panel);
                    else if (i == 7) view.panel11.Controls.Add(panel);
                    else if (i == 8) view.panel12.Controls.Add(panel);
                    else if (i == 9) view.panel13.Controls.Add(panel);

                    i++;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void taiTrang()
        {
            int startIndex = trangHienTai * kichThuocTrang;
            hienThiDiaDanh();
            capNhatNutPhanTrang();
        }
        private void capNhatNutPhanTrang()
        {
            view.button15.Enabled = trangHienTai > 0;
            view.button1.Enabled = trangHienTai < soLuongTrang - 1;
        }
        public void denTrangKeTiep()
        {
            if (trangHienTai < soLuongTrang)
            {
                trangHienTai++;
                taiTrang();
            }
        }
        public void denTrangTruocDo()
        {
            if (trangHienTai > 0)
            {
                trangHienTai--;
                taiTrang();
            }
        }
        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }
    }
}
