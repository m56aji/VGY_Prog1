using System;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Form1 : Form       //Klassen subklassen Form1 ärver ":" egenskaper från föräldrarklassen Form
    {
        bool XTurn = false;
        Button[,] array;                    //Deklarera en 2:dimensionell array som fält/klassvariabel

        public Form1()
        {
            InitializeComponent();
            //skapar en tvådimensionell array[3,3] med tre rader och tre kolumner
            array = new Button[,]  {        { button1, button2, button3},           //Element i rad 0
                                            { button4, button5, button6},           //Element i rad 1
                                            { button7, button8, button9} };         //Element i rad 2
        }

        //Raderar texten på knapparna efter en vinstomgång
        private void ResetBoard() {
            int size = array.GetLength(0);                      //Ger antalet element i rad 0 och öppnar för att göra större spelplan

            for (int x = 0; x < size; x++) {
                for (int y = 0; y < size; y++) {
                    array[y, x].Text = string.Empty;
                }
            }//inre for
        }//yttre for


        ////Metod för att hantera händelsen att någon trycker på en knapp
        ////Metoden har två parametrar. Vilket objekt som genererade händelsen (sender)
        ////och vad som hände (e)
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;            //Nyckelordet "as" visar vilken typ objekt-variabeln "sender" ska ha
            if (b == null || !string.IsNullOrEmpty(b.Text))         //Om inte knappen är textlös 
                return;                                             //lämna Button_Click-metoden (early exit)

            string player = (XTurn) ? "X" : "O";                    //Om XTurn är true tillela player X annars tilldela player O
            b.Text = player;

            XTurn = !XTurn;

            int size = array.GetLength(0);

            //Studera och förstå dig på lösningen. Viktigt!
            //Kollar om någon vunnit lodrätt/kolumner(k)
            for (int x = 0; x < size; x++)
            {
                //OBS ett villkor i villkoret. Gör så att for-loopen bryts om inte texten är identisk på alla knappar i loopen
                for (int y = 0; y < size && player == array[y, x].Text ; y++)
                {
                    if (y == size - 1)                                                  //Om k = 2 så har for-loopen fullföljts
                    {
                        MessageBox.Show(this, "Player " + player + " vertikal won!");
                        ResetBoard();
                    }
                }
            }

            //rader
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size && array[y, x].Text == player; x++)
                {
                    if (x == size - 1)
                    {
                        MessageBox.Show(this, "Player " + player + " horizontal won!");
                        ResetBoard();
                    }
                }
            }

            //Kollar om någon vunnit diagonalt snett åt höger, dvs: [0,0] [1,1] och [2,2]
            for (int i = 0; i < size && array[i, i].Text == player; i++)
            {
                if (i == size - 1)
                {
                    MessageBox.Show(this, "Player " + player + " diagonal '\' won!");
                    ResetBoard();
                }
            }

            //Kollar om någon vunnit diagonalt snett åt vänster, dvs: [0,2] [1,1] och [2,0]
            for (int i = 0; i < size && array[size - 1 - i, i].Text == player; i++)
            {
                if (i == size - 1)
                {
                    MessageBox.Show(this, "Player " + player + " diagonal / won!");
                    ResetBoard();
                }
            }

            //Ingen vinnare om det inte finns några tomma knappar
            bool finished = true;

            //Finns det några 
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (string.IsNullOrEmpty(array[x, y].Text))
                        finished = false;
                }
            }

            if (finished)
            {
                MessageBox.Show(this, "It's a draw!");
                ResetBoard();
            }
        }
    }//Main
}//class


