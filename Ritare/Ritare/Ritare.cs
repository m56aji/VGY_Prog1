using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ritare
{
    public partial class Ritare : UserControl
    {
        public Ritare()
        {
            InitializeComponent();
            penna = new Pen(ForeColor);     //fönstrets Förgrundsfärg
        }

        List<Line> linjer = new List<Line>();   //Redan existerande linjer i figuren
        Line nyLinje;                           //Den linje som håller på att läggas till

        ColorDialog d = new ColorDialog();
        Pen penna;

        bool vänsterNere = false;               //Vänster musknapp nedtryckt false/true

        public void ÄndraFärg()
        {
            if (d.ShowDialog() == DialogResult.OK)
                ForeColor = d.Color;
        }

        private void RitaLinjer(Graphics g)
        {
            foreach (Line l in linjer)
            {
                penna.Color = l.Color;
                g.DrawLine(penna, l.P1, l.P2);
            }
        }

        //Metod som överskuggar/döljer superklassens metod
        //Anropar klassens metod - RitaLinjer - vid varje omritning
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RitaLinjer(e.Graphics);
        }

        //Undersöker vilken musknapp som tryckts ner, vänster eller höger
        private void Ritare_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                nyLinje = new global::Line(e.Location, e.Location, ForeColor);
                vänsterNere = true;
            }
            else if (e.Button == MouseButtons.Right && !vänsterNere)
                ÄndraFärg();
        }

        private void Ritare_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                nyLinje.P2 = e.Location;        //Uppdatear slutpunkten
                linjer.Add(nyLinje);            //Adderar den nya linjen till listan av linjer
                Refresh();                      //Anropar basklassens RitaOm-metod
                vänsterNere = false;
            }
        }

        //Ser till att den linje man ritar syns i fönstret
        //Linje som förändras ritas över med bakgrundsfärgen
        private void Ritare_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Graphics g = CreateGraphics();              //Skapa en rityta som vi kan rita på
                penna.Color = BackColor;
                g.DrawLine(penna, nyLinje.P1, nyLinje.P2);  //Sudda ut linjen
                nyLinje.P2 = e.Location;                    //Uppdatera slutpunkt
                penna.Color = nyLinje.Color;
                g.DrawLine(penna, nyLinje.P1, nyLinje.P2);  //Rita linjen
                RitaLinjer(g);                              //Rita redan lagrade linjer
                g.Dispose();                                //Frigör resurserna som ritytan upptar
            }
        }

        //Tar bort den sista punkten om nedtryckt knapp är Backspace
        private void Ritare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back && linjer.Count > 0 && !vänsterNere)
            {
                linjer.RemoveAt(linjer.Count - 1);  //Tar bort den sista linjen
                Refresh();
            }
        }
    }
}
