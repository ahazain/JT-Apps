using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbahUnamePw
{
    public class CustomRoundedButton : Button
    {
        private Color hoverColor = Color.LightBlue;
        private Color pressColor = Color.DarkBlue;
        private int cornerRadius = 10;

        public Color HoverColor
        {
            get { return hoverColor; }
            set
            {
                hoverColor = value;
                Invalidate(); // Redraw the button when the hover color changes
            }
        }

        public Color PressColor
        {
            get { return pressColor; }
            set
            {
                pressColor = value;
                Invalidate(); // Redraw the button when the press color changes
            }
        }

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                Invalidate(); // Redraw the button when the corner radius changes
            }
        }

        public CustomRoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.LightBlue;
            ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a GraphicsPath to define the rounded shape
            GraphicsPath path = new GraphicsPath();
            RectangleF bounds = new RectangleF(0, 0, Width, Height);
            float radius = cornerRadius * 2;

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Set the button's region to the rounded shape
            Region = new Region(path);

            // Fill the button with the background color
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Draw the button's text
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = hoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.LightBlue;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            BackColor = pressColor;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            BackColor = hoverColor;
        }
    }

    public class MainFormm : Form
    {
        public MainFormm()
        {
            CustomRoundedButton customButton = new CustomRoundedButton();
            customButton.Location = new Point(10, 10);
            customButton.Size = new Size(100, 50);
            customButton.Text = "Click Me";
            customButton.HoverColor = Color.Orange;
            customButton.PressColor = Color.Red;
            customButton.CornerRadius = 20;

            Controls.Add(customButton);
        }
    }
}
