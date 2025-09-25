using App.Views;
using App.Utilities;
using App.Models;
using NAudio.Wave;
using System.Timers;


namespace App.Controllers
{
    internal class ThongTinChiTietDiaDanhController
    {
        private ThongTinChiTietDiaDanhModel model;
        private ThongTinChiTietDiaDanh view;
        private DiaDanhHienTai diaDanh;
        private List<BinhLuan> binhLuan;
        private int chiMucHinhAnh = 0;
        private IWavePlayer waveOut;
        private MediaFoundationReader audioFile;
        private System.Timers.Timer playbackTimer;
        private TimeSpan totalDuration;
        private bool dangThuyetMinh = false;

        public ThongTinChiTietDiaDanhController(ThongTinChiTietDiaDanh view)
        {
            this.view = view;
            this.model = new ThongTinChiTietDiaDanhModel();
            this.chiMucHinhAnh = chiMucHinhAnh;
            playbackTimer = new System.Timers.Timer(100); // Updates every 100ms
            playbackTimer.Elapsed += PlaybackTimer_Elapsed;
        }

        public void thongTinDiaDanhHienTai(string maDiaDanh)
        {
            diaDanh = model.layThongTinDiaDanh(maDiaDanh);
            hienThiThongTin();
        }

        public void hienThiThongTin()
        {
            try
            {
                view.panel5.Controls.Clear();
                view.panel6.Controls.Clear();

                foreach (BinhLuan binhLuan in diaDanh.danhSachBinhLuan)
                {
                    Label nguoiDungLabel = new Label
                    {
                        Text = binhLuan.email + ": ",
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        Location = new Point(0, view.panel6.Controls.Count > 0 ? view.panel6.Controls[view.panel6.Controls.Count - 1].Bottom + 5 : 0)
                    };
                    view.panel6.Controls.Add(nguoiDungLabel);
                    Label binhLuanLabel = new Label
                    {
                        Text = binhLuan.noiDung,
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = new Point(nguoiDungLabel.Right, nguoiDungLabel.Top)
                    };
                    view.panel6.Controls.Add(binhLuanLabel);
                }

                string hinhAnh = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[chiMucHinhAnh]);
                if (File.Exists(hinhAnh))
                {
                    view.pictureBox3.Image = Image.FromFile(hinhAnh);
                }
                else
                {
                    view.pictureBox3.Image = null;
                }

                string thongTinDiaDanh = Path.Combine(Application.StartupPath, "Data", diaDanh.thongTin);
                if (File.Exists(thongTinDiaDanh))
                {
                    Label thongTinLabel = new Label
                    {
                        Text = File.ReadAllText(thongTinDiaDanh),
                        AutoSize = true,
                        MaximumSize = new System.Drawing.Size(940,int.MaxValue),
                        Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = new Point(0, 0),
                        TextAlign = ContentAlignment.TopLeft,
                    };
                    view.panel5.Controls.Add(thongTinLabel);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }

        public void luuBinhLuan(string binhLuan,string maDiaDanh)
        {
            try {
                model.luuBinhLuan(maDiaDanh,binhLuan);
            }
            catch(Exception) { throw; } 
        }

        public void loadBinhLuan(string maDiaDanh)
        {
            try
            {
                binhLuan = model.layBinhLuan(maDiaDanh);
                view.panel6.Controls.Clear();
                foreach (BinhLuan binhLuan in binhLuan)
                {
                    Label nguoiDungLabel = new Label
                    {
                        Text = binhLuan.email + ": ",
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                        Location = new Point(0, view.panel6.Controls.Count > 0 ? view.panel6.Controls[view.panel6.Controls.Count - 1].Bottom + 5 : 0)
                    };
                    view.panel6.Controls.Add(nguoiDungLabel);

                    Label binhLuanLabel = new Label
                    {
                        Text = binhLuan.noiDung,
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Location = new Point(nguoiDungLabel.Right, nguoiDungLabel.Top)
                    };
                    view.panel6.Controls.Add(binhLuanLabel);
                }
            }
            catch (Exception) { throw; }
        }

        public void loadHinhAnhTruoc()
        {
            if (chiMucHinhAnh > 0)
            {
                chiMucHinhAnh -= 1;
                string hinhAnh = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[chiMucHinhAnh]);
                if (File.Exists(hinhAnh))
                {
                    view.pictureBox3.Image = Image.FromFile(hinhAnh);
                }
                else
                {
                    view.pictureBox3.Image = null;
                }
            }
        }

        public void loadHinhAnhSau()
        {
            if (chiMucHinhAnh < diaDanh.danhSachAnh.Count - 1)
            {
                chiMucHinhAnh += 1;
                string hinhAnh = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[chiMucHinhAnh]);
                if (File.Exists(hinhAnh))
                {
                    view.pictureBox3.Image = Image.FromFile(hinhAnh);
                }
                else
                {
                    view.pictureBox3.Image = null;
                }
            }
        }

        public void dungLai()
        {
            if (audioFile == null || waveOut == null)
                return;

            if (dangThuyetMinh)
            {
                waveOut.Pause();
                playbackTimer.Stop();
            }
            else
            {
                waveOut.Play();
                playbackTimer.Start();
            }
            dangThuyetMinh = !dangThuyetMinh;
        }

        private void PlaybackTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (audioFile == null || waveOut == null)
                return;

            view.Invoke(new Action(() =>
            {
                var currentPosition = audioFile.CurrentTime;
                view.progressBar1.Value = (int)currentPosition.TotalSeconds;
                view.label3.Text = currentPosition.ToString(@"mm\:ss");

                if (currentPosition >= totalDuration)
                {
                    playbackTimer.Stop();
                    view.progressBar1.Value = view.progressBar1.Maximum;
                }
            }));
        }
        public void chayThuyetMinh()
        {
            try
            {
                string amThanh = Path.Combine(Application.StartupPath, "Audio", diaDanh.amThanh);

                if (File.Exists(amThanh))
                {
                    waveOut?.Dispose();
                    audioFile?.Dispose();

                    audioFile = new MediaFoundationReader(amThanh);
                    waveOut = new WaveOutEvent();
                    waveOut.Init(audioFile);

                    totalDuration = audioFile.TotalTime;

                    view.progressBar1.Maximum = (int)totalDuration.TotalSeconds;
                    view.progressBar1.Value = 0;

                    dungLai();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void dungThuyetMinh()
        {
            if (audioFile == null || waveOut == null)
                return;

            if (dangThuyetMinh)
            {
                waveOut.Pause();
                playbackTimer.Stop();
            }
        }

        public void datViTriBatDau(int seconds)
        {
            if (audioFile == null)
                return;

            audioFile.CurrentTime = TimeSpan.FromSeconds(seconds);
            view.progressBar1.Value = seconds;

            if (!dangThuyetMinh)
            { 
                waveOut.Play();
                playbackTimer.Start();
                dangThuyetMinh = true;
            }
        }

        public void timKiemDiaDanhTheoTen(string tenDiaDanh)
        {
            DanhSachDiaDanh danhSachDiaDanh = new DanhSachDiaDanh();
            danhSachDiaDanh.Show();
            danhSachDiaDanh.triggerKeyDown(tenDiaDanh);
            view.Hide();
        }
    }
}