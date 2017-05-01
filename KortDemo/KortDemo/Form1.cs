using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KortDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear(); //Ta bort gamla kort
            Kortbunt lek = new Kortbunt();
            lek.NyKortlek();
            lek.Blanda();
            for(int c = 0; c < 5; c++)
            {
                Kort k = lek.TaBortÖversta();
                flowLayoutPanel1.Controls.Add(k); //Lägg ut kortet
                k.Click += card_Click;            //Koppla händelsehanteraren nedan till kortet
            }
        }

        private void card_Click(object sender, EventArgs e)
        {
            Kort k = (Kort)sender;
            k.Synligt = !k.Synligt; //Vänd kortet
        }
    }
}
