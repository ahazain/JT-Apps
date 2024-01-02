using bagianAB;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagianAB
{
    public class regtangle : Panel 
    {
        public int CornerRadius { get; set; }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate(); // Redraw the panel when it is resized
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            RectangleF bounds = new RectangleF(0, 0, Width, Height);
            int diameter = CornerRadius * 2;

            if (diameter > 0 && diameter <= bounds.Width && diameter <= bounds.Height)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Width - diameter, bounds.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Height - diameter, diameter, diameter, 90, 90);
                path.CloseAllFigures();

                Region = new Region(path);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(new Pen(Color.Black), path);
            }
            else
            {
                // Handle invalid parameters gracefully, e.g., fallback to a different rendering method or display an error message.
            }
        }
    }

    public class bagianAB : Form
    {
        public bagianAB()
        {
            rectangle roundedPanel = new rectangle();
            roundedPanel.CornerRadius = 20;
            roundedPanel.BackColor = Color.LightBlue;
            roundedPanel.Dock = DockStyle.Fill;

            Controls.Add(roundedPanel);
        }
    }
}
