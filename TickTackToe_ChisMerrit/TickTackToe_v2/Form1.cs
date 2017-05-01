using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                 //https://msdn.microsoft.com/en-us/library/system.windows.forms(v=vs.110).aspx#Classes

namespace TickTackToe_v2
{
    public partial class Form1 : Form       //https://msdn.microsoft.com/en-us/library/system.windows.forms.form(v=vs.110).aspx
    {
        bool turn = true;   //turn X = true, turn Y = false;
        int turn_count = 0; //räknar antalet klickade knappar
        static string spelare1, spelare2;   //Video3, Gör namnen till statiska(!) variabler

        public Form1()                  //Konstruktor
        {
            InitializeComponent();      //Metoden som finns i den andra halvan av den delade klassen
        }

        //Video3. Statisk(!) metod för att sätta spelarnamnen
        public static void setSpelarNamn(string s1, string s2)
        {
            spelare1 = s1;
            spelare2 = s2;
        }

        private void omSpeletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Skapat av André", "Tre i rad spelet");
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;      //Casting av eventobjektet sender
            if (turn)
                b.Text = "X";               //Text är ett "property" i Button-klassen
            else                            // se https://msdn.microsoft.com/en-us/library/system.windows.forms.button(v=vs.110).aspx#Events
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;              //Nu är inte knappen klickbar/Eneabled längre

            turn_count++;
            CheckForWinner();
        }

        private void CheckForWinner()     //gemen eller versal inledande bokstav?
        {
            bool there_is_a_winner = false;

            //Horisontell vinnare
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
                there_is_a_winner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
                there_is_a_winner = true;

            //Vertikal vinnare
            else if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
                there_is_a_winner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
                there_is_a_winner = true;

            //Diagonal vinnare
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !A3.Enabled)
                there_is_a_winner = true;
            else if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();

                string winner = "";
                if (turn)
                {
                    winner = spelare2;
                    o_vinst_count.Text = (Int32.Parse(o_vinst_count.Text) + 1).ToString();
                }
                else
                {
                    winner = spelare1;
                    x_vinst_count.Text = (Int32.Parse(x_vinst_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Vann", "Hurra");
            }
            else
            {
                if (turn_count == 9)
                {
                    oavgjort_count.Text = (Int32.Parse(oavgjort_count.Text) + 1).ToString();
                    MessageBox.Show("Oavgjort", "Opps");
                }
            }
        }//CheckForWinner

        private void disableButtons()
        {
            try                                     //Om Controll-elementet är en Button gör den till en Button
            {                                       //          annars skicka ett exception 
                foreach (Control c in Controls)     //foreach = förenklad for-loop
                {
                    Button b = (Button)c;           //casting
                    b.Enabled = false;
                }//end foreach
            }
            catch { }                               //Här fångas felmeddelandet in, men det görs inget med det.
        }

        private void nyOmgångToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

                foreach (Control c in Controls)     //foreach
                {
                    try {
                        Button b = (Button)c;       //casting
                        b.Enabled = true;
                        b.Text = "";
                    }//end try
                    catch { /*Do nothing*/ }
                }//end foreach
        }

        private void Button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = (turn) ? "X" : "O";    //Förenklad if-sats (conditional operator)
         }
        private void Button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = "";
        }

        private void nollställRäknareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oavgjort_count.Text = "0";
            o_vinst_count.Text = "0";
            x_vinst_count.Text = "0";
        }

        //Video 3. Anropar konstruktorn för Namndialogrutan när Form1 laddas
        private void Form1_Load(object sender, EventArgs e)
        {
            PlayersNameWindow pnw = new PlayersNameWindow();
            pnw.ShowDialog();
            label_1.Text = spelare1;
            label_3.Text = spelare2;
        }
    }
}
