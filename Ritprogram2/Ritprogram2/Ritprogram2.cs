//Varje fönster får en egen rityta.
//Ritytan skalar inte upp om fönstret gör det. Fixa!
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ritprogram2
{
    public partial class Ritprogram2 : Form
    {
        static int totAntal = 0;    //Antal fönster. Statisk för att det inte beror på instansen
        static int nästaNr = 0;     //Nästa fönsters nummer
        int nr;                     //Detta fönsters nummer'

        public Ritprogram2()
        {
            InitializeComponent();
            totAntal++;                     //Ännu ett fönster gör att det räknas upp med ett
            nr = nästaNr++;                 
            Text = "Ritare " + (nr + 1);    //Text är en property i Formklassen
            Location = new Point(30 * nr, 30 * nr); //Location är en property i Formklassen. Flyttar vänsterhörn(origo)
            Visible = true;                         //Visble är en property i Controlklassen
        }

        private void nyttFönsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ritprogram2();
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ändraFärgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ritare1.ÄndraFärg();
        }

        private void Ritprogram2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (--totAntal == 0)             //Stängs det sista fönstret?
                Application.Exit();
        }
    }
}
