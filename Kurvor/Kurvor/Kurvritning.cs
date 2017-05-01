using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurvor
{
    public partial class Kurvritning : UserControl
    {
        public Kurvritning()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            int minX = -4, maxX = 4;
            int minY = -4, maxY = 15;

            float scale = 10f;

            Pen blackPen = new Pen(Color.Black);
            g.TranslateTransform(140, 160);
            g.ScaleTransform(scale, scale);

            blackPen.Width = 1 / scale;
            g.DrawLine(blackPen, minX, 0, maxX, 0);
            g.DrawLine(blackPen, 0, -minY, 0, -maxY);

            for (int i = minX; i <= maxX ; i++)
                g.DrawLine(blackPen, i, 0, i, -2 / scale);

            for (int i = minY; i <= maxY ; i++)
                g.DrawLine(blackPen, 0, -i, 2 / scale, -i);

            int n = (int)((maxX - minX) * scale) + 1;

            PointF[] points = new PointF[n];

            float x = minX;

            for (int i = 0; i < n; i++, x += 0.1F)  //Två uppräkningar: i och x
                points[i] = new PointF(x, -f(x));

            g.DrawCurve(blackPen, points);
        }

        static float f(float x)
        {
            return 0.5F * x * x + 1.5F * x;
        }
    }
}
