using System.Drawing.Drawing2D;
using System.Text;
using System.Web;

namespace App.Views
{
    public partial class ChiDuong : Form
    {
        private string toaDo;
        public ChiDuong(string toaDo)
        {
            InitializeComponent();

            txtSearch.KeyDown += TxtSearch_KeyDown;
            this.toaDo = toaDo;
        }

        public ChiDuong(object? tag)
        {
            Tag = tag;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async(null);
            txtSearch.Text = toaDo;
            btnTimKiem.PerformClick();

        }


        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnTimKiem.PerformClick();
            }
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (webView.CoreWebView2 == null)
            {
                await webView.EnsureCoreWebView2Async(null);
            }

            string searchQuery = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Vui lòng nhập địa điểm hoặc địa chỉ để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = HttpUtility.UrlEncode(searchQuery);

            string googleMapsUrl = $"https://www.google.com/maps/search/?api=1&query={query}";

            webView.CoreWebView2.Navigate(googleMapsUrl);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Bo góc
            int borderRadius = 15; // Độ bo góc
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();
            float r = borderRadius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            // Gán vùng (region) để bo góc
            btn.Region = new Region(path);

            // Vẽ nền
            using (SolidBrush brush = new SolidBrush(btn.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }



            // Vẽ text
            TextRenderer.DrawText(
                e.Graphics,
                btn.Text,
                btn.Font,
                rect,
                btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

        }

        private void webView_Click(object sender, EventArgs e)
        {

        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
