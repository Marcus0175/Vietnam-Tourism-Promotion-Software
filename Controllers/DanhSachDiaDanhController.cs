using App.Models;
using App.Views;
using App.Utilities;

namespace App.Controllers
{
    internal class DanhSachDiaDanhController
    {
        private DanhSachDiaDanhModel model;
        private DanhSachDiaDanh view;
        private int trangHienTai;
        private int kichThuocTrang = 3;
        private int soLuong;
        private int soLuongTrang;
        private string? tinhThanh;
        private string? maTinh;
        private string? loaiDiaDanh;
        private string? tenDiaDanh;
        private string tieuChi;
        public DanhSachDiaDanhController(DanhSachDiaDanh view)
        {
            this.view = view;
            this.model = new DanhSachDiaDanhModel();
        }

        public void soLuongDiaDanhTheoTen(string tenDiaDanh)
        {
            trangHienTai = 0;
            soLuong = model.timKiemTheoTen(tenDiaDanh);
            soLuongTrang = (int)Math.Ceiling((double)soLuong / kichThuocTrang);
            this.tenDiaDanh = tenDiaDanh;
            tieuChi = "Ten";
            taiTrang();
        }
        public void soLuongDiaDanhTheoBoLoc(string maTinh, string loaiDiaDanh)
        {
            trangHienTai = 0;
            this.maTinh = maTinh;
            this.loaiDiaDanh = loaiDiaDanh;
            soLuong = model.timKiemTheoBoLoc(maTinh,loaiDiaDanh);
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
                if(soLuong == 0)
                {
                    view.ThongBaoLoi.Show();
                    return;
                }
                view.ThongBaoLoi.Hide();
                view.panel3.Controls.Clear();
                view.panel4.Controls.Clear();
                view.panel5.Controls.Clear();

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
                    // Dynamically calculate panel width/height
                    int panelWidth = view.panel3.Width - 20; // Adding margins
                    int panelHeight = view.panel3.Height; // Fixed height for consistency

                    Panel panel = new Panel
                    {
                        Size = new Size(panelWidth, panelHeight),
                        AutoSize = false,
                        Margin = new Padding(10)
                    };

                    // PictureBox: Adjust size and position dynamically
                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(panelWidth / 3, panelHeight - 50),
                        Location = new Point(30, 30),
                        Tag = diaDanh.maDiaDanh
                    };
                    pictureBox.Click += view.clickEvent;

                    if (!string.IsNullOrEmpty(diaDanh.anhChuDe))
                    {
                        string imagePath = Path.Combine(Application.StartupPath, "Images", diaDanh.anhChuDe);
                        pictureBox.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
                    }

                    // Name Label
                    Label nameLabel = new Label
                    {
                        Text = diaDanh.tenDiaDanh,
                        Location = new Point(pictureBox.Right + 20, 20),
                        Font = new Font("Arial", 11.25F, FontStyle.Bold),
                        AutoSize = true,
                        Tag = diaDanh.maDiaDanh,
                    };
                    nameLabel.Click += view.clickEvent;

                    // View Count Label
                    Label luotXemLabel = new Label
                    {
                        Text = "Lượt Xem: " + diaDanh.luotXem.ToString(),
                        Location = new Point(pictureBox.Right + 20, nameLabel.Bottom + 10),
                        Font = new Font("Arial", 9F),
                        AutoSize = true,
                        Tag = diaDanh.maDiaDanh,
                    };
                    luotXemLabel.Click += view.clickEvent;

                    // Rank Label
                    Label rankLabel = new Label
                    {
                        Text = "Xếp hạng: " + diaDanh.xepHang,
                        Location = new Point(pictureBox.Right + 20, luotXemLabel.Bottom + 10),
                        Font = new Font("Arial", 9F),
                        AutoSize = true,
                        Tag = diaDanh.maDiaDanh,
                    };
                    rankLabel.Click += view.clickEvent;

                    // Button: Dynamically calculate position
                    Button button = new Button
                    {
                        Text = "Đường đến địa danh",
                        BackColor = Color.DodgerBlue,
                        ForeColor = Color.White,
                        Size = new Size(panelWidth / 4, 40), // Proportional size
                        Location = new Point(pictureBox.Right + 20, rankLabel.Bottom + 7), // Adjust spacing dynamically
                        Font = new Font("Arial", 9F),
                        Tag = diaDanh.toaDo,
                        UseVisualStyleBackColor = false,
                        FlatStyle = FlatStyle.Flat,
                    };
                    button.Click += view.buttonClickEvent;

                    // Add controls to the panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(nameLabel);
                    panel.Controls.Add(luotXemLabel);
                    panel.Controls.Add(rankLabel);
                    panel.Controls.Add(button);

                    // Add panel to the appropriate container
                    if (i == 0) view.panel3.Controls.Add(panel);
                    else if (i == 1) view.panel4.Controls.Add(panel);
                    else if (i == 2) view.panel5.Controls.Add(panel);

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
            view.btnTruoc.Enabled = trangHienTai > 0;
            view.btnTiep.Enabled = trangHienTai < soLuongTrang-1;
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

        public void capNhatLuotXem(string maDiaDanh)
        {
            try
            {
                model.capNhatLuotXem(maDiaDanh);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
