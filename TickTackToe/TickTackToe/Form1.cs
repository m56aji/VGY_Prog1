using System;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Form1 : Form       //Klassen subklassen Form1 ärver ":" egenskaper från föräldrarklassen Form
    {
        bool XTurn = false;
        Button[,] buttonArray;                //Deklarera en 2:dimensionell array som fält/klassvariabel
        int arrSize;                    //Gör arrSize till en klassvariabel
        string playerXO;                  //Är det spelare X eller spelare O som gjort sista draget

        public Form1()
        {
            InitializeComponent();
            //skapar en tvådimensionell array[3,3] med tre rader och tre kolumner
            buttonArray = new Button[,]  {  { button1, button2, button3},           //Element i rad 0
                                            { button4, button5, button6},           //Element i rad 1
                                            { button7, button8, button9} };         //Element i rad 2
            arrSize = buttonArray.GetLength(0);                                           //Returnerar antal element på rad 0
        }

        //Raderar texten på knapparna efter en vinstomgång
        private void ResetBoard()
        {
            for (int x = 0; x < arrSize; x++)
            {
                for (int y = 0; y < arrSize; y++)
                {
                    buttonArray[y, x].Text = string.Empty;
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
                return;                                             //lämna Button_Click-metoden (early exit) trots att returtypen är void

            playerXO = (XTurn) ? "X" : "O";                         //Om XTurn är true tillela player X annars tilldela player O
            b.Text = playerXO;

            XTurn = !XTurn;                                         //Växlar mellan X och O och viseversa

            LodrättVinst();
            VågrättVinst();
            Diagonalt1Vinst();
            Diagonalt2Vinst();
            IngenVinnare();

        }//Button_Click

        //Kollar om någon vunnit lodrätt/kolumner
        private void LodrättVinst()
        {
            for (int x = 0; x < arrSize; x++)
            {
                //OBS ett villkor i villkoret. Gör så att for-loopen bryts om inte texten är identisk på alla knappar i loopen
                for (int y = 0; y < arrSize && playerXO == buttonArray[y, x].Text; y++)
                {
                    if (y == arrSize - 1)                                                  //Om k = 2 så har for-loopen fullföljts
                    {
                        MessageBox.Show(this, "Player " + playerXO + " vertikal won!");
                        ResetBoard();
                    }
                }
            }
        }//Lodrätt

        //Kollar om någon vunnit vågrätt
        private void VågrättVinst()
        {
            for (int y = 0; y < arrSize; y++)
            {
                for (int x = 0; x < arrSize && buttonArray[y, x].Text == playerXO; x++)
                {
                    if (x == arrSize - 1)
                    {
                        MessageBox.Show(this, "Player " + playerXO + " horizontal won!");
                        ResetBoard();
                    }
                }
            }
        }//Vågrätt

        //Kollar om någon vunnit diagonalt snett åt höger, dvs: [0,0] [1,1] och [2,2]
        private void Diagonalt1Vinst()
        {
            for (int i = 0; i < arrSize && buttonArray[i, i].Text == playerXO; i++)
            {
                if (i == arrSize - 1)
                {
                    MessageBox.Show(this, "Player " + playerXO + " diagonal '\' won!");
                    ResetBoard();
                }
            }
        }
        
        //Kollar om någon vunnit diagonalt snett åt vänster, dvs: [0,2] [1,1] och [2,0]
        private void Diagonalt2Vinst() {
            for (int i = 0; i < arrSize && buttonArray[arrSize - 1 - i, i].Text == playerXO; i++) {
                if (i == arrSize - 1) {
                    MessageBox.Show(this, "Player " + playerXO + " diagonal / won!");
                    ResetBoard();
                }
            }
        }

        //Samtliga buttons iklickade men ingen vann
        private void IngenVinnare() {
            bool finished = true;

            //Finns det några tomma rutor/knappar?
            for (int x = 0; x < arrSize; x++) {
                for (int y = 0; y < arrSize; y++) {
                    if (string.IsNullOrEmpty(buttonArray[x, y].Text))
                        finished = false;           //Tom ruta hittad alltså är spelet inte slutspelat
                }
            }

            if (finished) {
                MessageBox.Show(this, "It's a draw!");  //Det är oavgjort
                ResetBoard();
            }
        }

    }//class
}//namespace


