using System.Drawing.Drawing2D;


public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 20;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Vẽ button với bo góc
        using (GraphicsPath path = new GraphicsPath())
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            float r = BorderRadius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            // Vẽ nền
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                graphics.FillPath(brush, path);
            }

            // Vẽ viền nếu cần
            using (Pen pen = new Pen(this.ForeColor, 2))
            {
                graphics.DrawPath(pen, path);
            }
        }

        // Vẽ text
        TextRenderer.DrawText(graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
