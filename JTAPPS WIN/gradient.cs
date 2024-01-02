using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GradientForm
{
    public class GradientPanel : Panel
    {
        private int borderTopLeftRadius = 0;
        private int borderTopRightRadius = 0;
        private int borderBottomLeftRadius = 0;
        private int borderBottomRightRadius = 0;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.CadetBlue;
        private Color gradientMiddleColor = Color.LightCyan;
        private Color gradientBottomColor = Color.DarkSeaGreen;

        public GradientPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(300, 200);
        }

        public int BorderTopLeftRadius
        {
            get => borderTopLeftRadius;
            set { borderTopLeftRadius = value; this.Invalidate(); }
        }

        public int BorderTopRightRadius
        {
            get => borderTopRightRadius;
            set { borderTopRightRadius = value; this.Invalidate(); }
        }

        public int BorderBottomLeftRadius
        {
            get => borderBottomLeftRadius;
            set { borderBottomLeftRadius = value; this.Invalidate(); }
        }

        public int BorderBottomRightRadius
        {
            get => borderBottomRightRadius;
            set { borderBottomRightRadius = value; this.Invalidate(); }
        }

        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
        }

        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; this.Invalidate(); }
        }

        public Color GradientMiddleColor
        {
            get => gradientMiddleColor;
            set { gradientMiddleColor = value; this.Invalidate(); }
        }

        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; this.Invalidate(); }
        }

        private GraphicsPath GetGradientPath(RectangleF rectangle)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();

            if (borderTopLeftRadius > 0)
                graphicsPath.AddArc(rectangle.Left, rectangle.Top, borderTopLeftRadius * 2, borderTopLeftRadius * 2, 180, 90);
            else
                graphicsPath.AddLine(rectangle.Left, rectangle.Top, rectangle.Left, rectangle.Top);

            graphicsPath.AddLine(rectangle.Left + borderTopLeftRadius, rectangle.Top, rectangle.Right - borderTopRightRadius, rectangle.Top);

            if (borderTopRightRadius > 0)
                graphicsPath.AddArc(rectangle.Right - borderTopRightRadius * 2, rectangle.Top, borderTopRightRadius * 2, borderTopRightRadius * 2, 270, 90);
            else
                graphicsPath.AddLine(rectangle.Right, rectangle.Top, rectangle.Right, rectangle.Top);

            graphicsPath.AddLine(rectangle.Right, rectangle.Top + borderTopRightRadius, rectangle.Right, rectangle.Bottom - borderBottomRightRadius);

            if (borderBottomRightRadius > 0)
                graphicsPath.AddArc(rectangle.Right - borderBottomRightRadius * 2, rectangle.Bottom - borderBottomRightRadius * 2, borderBottomRightRadius * 2, borderBottomRightRadius * 2, 0, 90);
            else
                graphicsPath.AddLine(rectangle.Right, rectangle.Bottom, rectangle.Right, rectangle.Bottom);

            graphicsPath.AddLine(rectangle.Right - borderBottomRightRadius, rectangle.Bottom, rectangle.Left + borderBottomLeftRadius, rectangle.Bottom);

            if (borderBottomLeftRadius > 0)
                graphicsPath.AddArc(rectangle.Left, rectangle.Bottom - borderBottomLeftRadius * 2, borderBottomLeftRadius * 2, borderBottomLeftRadius * 2, 90, 90);
            else
                graphicsPath.AddLine(rectangle.Left, rectangle.Bottom, rectangle.Left, rectangle.Bottom);

            graphicsPath.AddLine(rectangle.Left, rectangle.Bottom - borderBottomLeftRadius, rectangle.Left, rectangle.Top + borderTopLeftRadius);

            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushGradient = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.gradientAngle);
            Graphics graphicsgGradient = e.Graphics;
            graphicsgGradient.FillRectangle(brushGradient, ClientRectangle);

            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath graphicsPath = GetGradientPath(rectangleF))
            using (Pen pen = new Pen(this.Parent.BackColor, 2))
            {
                this.Region = new Region(graphicsPath);
                e.Graphics.DrawPath(pen, graphicsPath);
            }
        }
    }
}
