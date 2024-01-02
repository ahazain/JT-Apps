using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTAPPS_WIN
{
    public class RoundedPicbox : PictureBox
    {
        private int cornerRadius = 10;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                Invalidate(); // Redraw the picture box when the corner radius changes
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate(); // Redraw the panel when it is resized
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                RectangleF bounds = new RectangleF(0, 0, Width, Height);
                int diameter = cornerRadius * 2;

                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Width - diameter, bounds.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Height - diameter, diameter, diameter, 90, 90);
                path.CloseAllFigures();

                Region = new Region(path);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                if (Image != null)
                    e.Graphics.DrawImage(Image, ClientRectangle);
            }
        }

    }

    public class MainForms : Form
    {
        public MainForms()
        {
            RoundedPicbox roundedPictureBox = new RoundedPicbox();
            roundedPictureBox.CornerRadius = 20;
            roundedPictureBox.Image = Image.FromFile("path_to_your_image");
            roundedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            roundedPictureBox.Dock = DockStyle.Fill;

            Controls.Add(roundedPictureBox);
        }
    }
}
