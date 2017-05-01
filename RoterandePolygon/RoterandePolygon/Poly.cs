using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoterandePolygon
{
    public partial class Poly : UserControl
    {
        public Poly()
        {
            InitializeComponent();
        }

        Point[] p;          //en array för hörnpunkterna i polygonen
        int dv = 5;         //delta v, dvs delta vinkel, dvs antal graders vridning vid varje tick
        int totDv;          //totala vridningen
        Brush blackBruch = new SolidBrush(Color.Black);

        //Parameterar: n = antal hörn, r = radien, interval = tidsenhet för varje tick
        public void Init(int n, int r, int interval)
        {
            Stop();
            totDv = 0;
            timer1.Interval = interval; //timer1 ligger i designerfilen och du drog in den från Toolbox

            p = new Point[n];
            double v = 2 * Math.PI / n;     //vridning i radianer, dvs (ett helvarv)/(antal hörn)

            //Fyller arrayen/vektorn med hörnpunkternas koordinater
            for (int i = 0; i < n; i++)
            {
                p[i].X = (int)Math.Round(r * Math.Cos(i * v));
                p[i].Y = (int)Math.Round(r * Math.Sin(i * v));
            }
        }

        //Händelsen Timer, hit kommer man vid varje tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            totDv = totDv + dv;
            if(totDv >= 360)    //Efter ett varv subtraheras vinkelsumman med 360 grader
                totDv -= 360;
            Refresh();          //Rita om komponenten -> OnPaint-metoden anropas
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(p != null)   //Om arrayen med hörnpunkter inte är tom
            {
                Graphics g = e.Graphics;
                g.ResetTransform();
                g.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);  //Flytta origo till fönstrets mitt
                g.RotateTransform(totDv);       //Roterar det uppritade runt det nya origo med totDv grader
                g.FillPolygon(blackBruch, p);   //Polygonen ritas upp
            }
        }

        public void Start()
        {
            timer1.Start();
        }

        public void Stop()
        {
            timer1.Stop();
        }
    }
}
