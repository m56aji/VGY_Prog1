using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Cat
{
    public partial class CatDrawer : UserControl
    {
        public CatDrawer()
        {
            InitializeComponent();
        }

        // Vår lokala version av OnPaint-metoden som vi därmed kör över, "override"
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);                    //Anropar superklassens OnPaint-metod
            Graphics g = e.Graphics;            //g refererar till objektet e:s grafiska klass Graphics

            //Vi behöver några pennor, defalut 1 pixel tjock
            Pen blackPen = new Pen(Color.Black);       //Fördefinierad svart, vi slipper ange RGB-färger
            Pen redPen = new Pen(Color.Red);

            //Vi behöver några penslar
            Brush whiteBrush = new SolidBrush(Color.White);     //Solidbrush är en subklass till Brush-klassen
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush blueBrush = new SolidBrush(Color.Blue);

            //Pensel(!) för att måla bakgrunden i kattens kropp. Ladda ner en bild från nätet
            Brush csharpBrush = new TextureBrush(Image.FromFile(@"C:\Users\Andre\Dropbox\#Prog\C#\GitRepo\Bilder\Noter.jpg"));

            //En pensel för att rita mönster (rutmönster i detta fall)
            Brush crossBrush = new HatchBrush(HatchStyle.Cross, Color.LightGray, Color.White);

            g.TranslateTransform(0, 250);
            g.RotateTransform(-90);
            g.ScaleTransform(1.0F, 0.75F);

            //Nu ska vi rita konturer och fylla dem med färg
            g.FillRectangle(crossBrush, 50, 50, 60, 60);    //Huvud
            g.DrawRectangle(blackPen, 50, 50, 60, 60);

            g.FillRectangle(whiteBrush, 80, 225, 140, 5);   //Svans
            g.DrawRectangle(blackPen, 80, 225, 140, 5);

            g.FillEllipse(csharpBrush, 20, 110, 120, 120);   //Kropp
            g.DrawEllipse(blackPen, 20, 110, 120, 120);

            g.FillEllipse(blueBrush, 60, 60, 10, 10);       //Ögon
            g.FillEllipse(blueBrush, 90, 60, 10, 10);

            g.DrawArc(redPen, 60, 80, 40, 20, 0, 180);      //Mun

            //Polygoner måste ha punkter att utgå från
            Point[] ear1 = { new Point(50, 50), new Point(60, 30), new Point(70, 50) }; //En array av punkter
            g.FillPolygon(whiteBrush, ear1);                //öra1
            g.DrawPolygon(blackPen, ear1);

            Point[] ear2 = { new Point(90, 50), new Point(100, 30), new Point(110, 50) }; //En array av punkter
            g.FillPolygon(whiteBrush, ear2);                //öra2
            g.DrawPolygon(blackPen, ear2);

            //Skriva en text
            Font f = new Font("Arial", 18, FontStyle.Italic);
            g.DrawString("Katten", f, blackBrush, 175, 50);
            Size sz = TextRenderer.MeasureText("Katten", f);
            g.DrawLine(blackPen, 175, 50 + sz.Height, 175 + sz.Width, 50 + sz.Height);
        }
    }
}
