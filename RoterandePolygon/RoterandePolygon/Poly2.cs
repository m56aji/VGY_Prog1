using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoterandePolygon
{
    public partial class Poly2 : UserControl
    {
        public Poly2()
        {
            InitializeComponent();
        }

        Point[] p;          //en array för hörnpunkterna i polygonen
        int dv = 5;         //delta v, dvs delta vinkel, dvs antal graders vridning vid varje tick
        int totDv;          //totala vridningen
        Brush blackBruch = new SolidBrush(Color.Black);
        int x0, y0;         //Polygonens mittpunkt
        int xSteg = 5, ySteg = 5;
        int r;              //polygonens radie

        //Parameterar: n = antal hörn, r = radien, interval = tidsenhet för varje tick
        public void Init(int n, int r, int interval)
        {
            Stop();
            totDv = 0;
            timer2.Interval = interval; //timer2 ligger i designerfilen som du drog in från Toolbox

            p = new Point[n];
            double v = 2 * Math.PI / n;     //vridning i radianer, dvs (ett helvarv)/(antal hörn)

            //Fyller arrayen/vektorn med hörnpunkternas koordinater
            for (int i = 0; i < n; i++)
            {
                p[i].X = (int)Math.Round(r * Math.Cos(i * v));
                p[i].Y = (int)Math.Round(r * Math.Sin(i * v));
            }

            this.r = r;
            x0 = r;
            y0 = r;
        }

        //Autogenererad. Händelsen Timer, hit kommer man vid varje tick/100:e ms med nyvarand argument
        private void timer2_Tick(object sender, EventArgs e)
        {
            totDv = totDv + dv;
            if (totDv >= 360)    //Efter ett varv subtraheras vinkelsumman med 360 grader
                totDv -= 360;

            if (x0 - r + xSteg < 0 || x0 + r + xSteg > ClientSize.Width)
                xSteg = -xSteg;    //Byt riktning vid kant
            x0 += xSteg;

            if (y0 - r + ySteg < 0 || y0 + r + ySteg > ClientSize.Height)
                ySteg = -ySteg;     //Byt riktning vid kant
            y0 += ySteg;
            Refresh();          //Rita om komponenten -> OnPaint-metoden anropas
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (p != null)   //Om arrayen med hörnpunkter inte är tom
            {
                Graphics g = e.Graphics;
                g.ResetTransform();
                g.TranslateTransform(x0, y0);  //Flytta origo
                g.RotateTransform(totDv);       //Roterar det uppritade runt det nya origo med totDv grader
                g.FillPolygon(blackBruch, p);   //Polygonen ritas upp
            }
        }

        public void Start()
        {
            timer2.Start();
        }

        public void Stop()
        {
            timer2.Stop();
        }
    }
}
