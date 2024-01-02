using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTAPPS_WIN
{
    public class reundedPNClass1 : Panel
    {
        public int CornerRadius { get; set; } = 10; // Adjust the corner radius value as desired

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                RectangleF rect = new RectangleF(0, 0, Width, Height);
                int radius = CornerRadius * 2;

                // Top-left corner
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);

                // Top-right corner
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);

                // Bottom-right corner
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);

                // Bottom-left corner
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

                path.CloseFigure();

                Region = new Region(path);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(new SolidBrush(BackColor), path);
            }
        }
    }

}
