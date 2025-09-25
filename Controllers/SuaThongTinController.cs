using App.Views;
using App.Utilities;
using App.Models;

namespace App.Controllers
{
    internal class SuaThongTinController
    {
        private SuaThongTinModel model;
        private SuaThongTin view;
        private DiaDanhHienTai diaDanh;
        private string txtPath;
        private string mp3Path;
        private string jpg1Path;
        private string jpg2Path;
        private string jpg3Path;
        private string jpg4Path;
        private string jpg5Path;

        private string txtTargetPath;
        private string mp3TargetPath;
        private string jpg1TargetPath;
        private string jpg2TargetPath;
        private string jpg3TargetPath;
        private string jpg4TargetPath;
        private string jpg5TargetPath;

        public SuaThongTinController(SuaThongTin view)
        {
            this.view = view;
            this.model = new SuaThongTinModel();
        }
        public void thongTinDiaDanhHienTai(string maDiaDanh)
        {
            try
            {
                diaDanh = model.layThongTinDiaDanh(maDiaDanh);
                hienThiThongTin();
                txtTargetPath = Path.Combine(Application.StartupPath, "Data", diaDanh.thongTin);
                mp3TargetPath = Path.Combine(Application.StartupPath, "Audio", diaDanh.amThanh);
                jpg1TargetPath = Path.Combine(Application.StartupPath, "Images", diaDanh.anhChuDe);
                jpg2TargetPath = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[0]);
                jpg3TargetPath = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[1]);
                jpg4TargetPath = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[2]);
                jpg5TargetPath = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[3]);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void chuyenForm(Form form)
        {
            Helpers.chuyenForm(form);
        }
        private void hienThiThongTin()
        {
            view.textBox1.Text = diaDanh.tenDiaDanh;
            view.textBox4.Text = diaDanh.xepHang;

            string hinhAnh1 = Path.Combine(Application.StartupPath, "Images", diaDanh.anhChuDe);
            string hinhAnh2 = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[0]);
            string hinhAnh3 = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[1]);
            string hinhAnh4 = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[2]);
            string hinhAnh5 = Path.Combine(Application.StartupPath, "Images", diaDanh.danhSachAnh[3]);
            if (File.Exists(hinhAnh1) && File.Exists(hinhAnh2) && File.Exists(hinhAnh3) && File.Exists(hinhAnh4) && File.Exists(hinhAnh5))
            {
                view.pictureBox1.Image = Image.FromFile(hinhAnh1);
                view.pictureBox3.Image = Image.FromFile(hinhAnh2);
                view.pictureBox10.Image = Image.FromFile(hinhAnh3);
                view.pictureBox11.Image = Image.FromFile(hinhAnh4);
                view.pictureBox12.Image = Image.FromFile(hinhAnh5);
            }
            else
            {
                view.pictureBox1.Image = null;
                view.pictureBox3.Image = null;
                view.pictureBox10.Image = null;
                view.pictureBox11.Image = null;
                view.pictureBox12.Image = null;
            }
        }
        public void loadTxt()
        {
            txtPath = LoadFile("Text files (*.txt)|*.txt");
            view.textBox2.Text = txtPath;
        }
        public void loadMp3()
        {
            mp3Path = LoadFile("Audio files (*.mp3)|*.mp3");
            view.textBox3.Text = mp3Path;
        }
        public void loadJpg(string soThuTu)
        {
            string jpgPath = LoadFile("Image files (*.jpg)|*.jpg");
            if (string.IsNullOrEmpty(jpgPath)) return;

            switch (soThuTu)
            {
                case "1":
                    LoadImageIntoPictureBox(view.pictureBox1, jpgPath);
                    jpg1Path = jpgPath;
                    break;
                case "2":
                    LoadImageIntoPictureBox(view.pictureBox3, jpgPath);
                    jpg2Path = jpgPath;
                    break;
                case "3":
                    LoadImageIntoPictureBox(view.pictureBox10, jpgPath);
                    jpg3Path = jpgPath;
                    break;
                case "4":
                    LoadImageIntoPictureBox(view.pictureBox11, jpgPath);
                    jpg4Path = jpgPath;
                    break;
                case "5":
                    LoadImageIntoPictureBox(view.pictureBox12, jpgPath);
                    jpg5Path = jpgPath;
                    break;
                default:
                    break;
            }
        }
        private string LoadFile(string filter)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = filter;
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return null;
        }
        public void luuThongTin(string maDiaDanh,string xepHang)
        {
            try
            {
                model.capNhatThongTinDiaDanh(maDiaDanh, xepHang);
                capNhatFile(txtPath, txtTargetPath);
                capNhatFile(mp3Path, mp3TargetPath);
                DisposeImage(view.pictureBox1);
                capNhatFile(jpg1Path, jpg1TargetPath);
                DisposeImage(view.pictureBox3);
                capNhatFile(jpg2Path, jpg2TargetPath);
                DisposeImage(view.pictureBox10);
                capNhatFile(jpg3Path, jpg3TargetPath);
                DisposeImage(view.pictureBox11);
                capNhatFile(jpg4Path, jpg4TargetPath);
                DisposeImage(view.pictureBox12);
                capNhatFile(jpg5Path, jpg5TargetPath);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void capNhatFile(string file, string desFile)
        {
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            else
            {
                replaceFile(file, desFile);
            }
        }
        private void replaceFile(string sourceFilePath, string targetFilePath)
        {
            if (File.Exists(targetFilePath))
            {
                File.Delete(targetFilePath);
            }
            File.Copy(sourceFilePath, targetFilePath, true);
        }
        private void LoadImageIntoPictureBox(PictureBox pictureBox, string imagePath)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose(); // Release the existing image
                pictureBox.Image = null;
            }

            using (var stream = new MemoryStream(File.ReadAllBytes(imagePath)))
            {
                pictureBox.Image = Image.FromStream(stream);
            }
        }
        private void DisposeImage(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }
    }
}
