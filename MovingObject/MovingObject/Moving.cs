//En enkel figur som rör sig med hjälp av piltangneterna och nollas med mellanslag
//Grund: https://www.youtube.com/watch?v=3eIzmcTe0mg 

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovingObject
{
    public partial class Moving : Form
    {
        enum Direction {Left, Right, Up , Down, Stop};  //uppräkningsvärden för positionen
        private Direction objDirection;
        private int x0, y0;                            //Övre vänstra hörnet (origo) i bilden
        private int objID = 0;

        public Moving()
        {
            InitializeComponent();
            //MessageBox.Show("x y " + this.Width + " : " + this.Height);   //Fönstrets bredd och höjd
            x0 = 50;                                                        //Startkoordinat för kvadraten
            y0 = 50;
            objDirection = Direction.Right;
        }

        //Paint-metoden anropas varje gång fönstret måste ritas om
        private void Moving_Paint(object sender, PaintEventArgs e)
        {
            //Färg/bild, övre vänstra hörnet x, övre vänstra hörnet y, storlek i x, storlek i y
            if(objID == 0)
                e.Graphics.FillRectangle(Brushes.BlueViolet, x0, y0, 10, 10);
            else
                e.Graphics.DrawImage(new Bitmap("AjiVGYsmall.png"), x0, y0, 40, 40);  //Add-Existing Item
        }

        //Anropas varje tidsenhet som Tickhändelsens property anger
        private void timerMove_Tick(object sender, EventArgs e)
        {
            //Ändrar riktning om figuren träffar fönstrets kanter
            if (x0 <= 0)
                objDirection = Direction.Right;
            else if (x0 + 20 >= this.Width)
                objDirection = Direction.Left;
            else if (y0 <= 0)
                objDirection = Direction.Down;
            else if (y0+50 >= this.Height)
                objDirection = Direction.Up;

            //Adderar eller subtraherar 10 pixlar till koordinaterna för origo
            if (objDirection == Direction.Right)
                x0 += 10;
            else if (objDirection == Direction.Left)
                x0 -= 10;
            else if (objDirection == Direction.Down)
                y0 += 10;
            else if (objDirection == Direction.Up)
                y0 -= 10;
            else if (objDirection == Direction.Stop)
            {
                y0 = 0;
                x0 = 0;
            }

            Invalidate(); //Invalidates the entire surface of the control and causes the control to be redrawn. 
        }

        //Button-lyssnaren 
        private void button1_Click(object sender, EventArgs e)
        {
            objID = objID == 0 ? 1 : 0;
        }

        //Vi kan inte använda KeyDown-lyssnaren eftersom Button har fokus
        //Istället får vi överskugga/dölja/ta över superklassens lyssnarmetod
        //Vilket gör att denna klass har en lyssnare som inte kommer i konflikt
        //med Button lyssnaren. Lösningen är hämtad från stackowerflow
        //http://stackoverflow.com/questions/5499463/fire-form-keypress-event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                objDirection = Direction.Left;
                return true;    //Meddelandet är hanterat och skickas inte vidare
            }
            else if (keyData == Keys.Right)
            {
                objDirection = Direction.Right;
                return true;
            }
            else if (keyData == Keys.Up)
            {
                objDirection = Direction.Up;
                return true;
            }
            else if (keyData == Keys.Down)
            {
                objDirection = Direction.Down;
                return true;
            }
            else if (keyData == Keys.Space)
            {
                objDirection = Direction.Stop;
                return true;
            }
            
            //Ingen av de givna tangenterna användes
            //call the base class to handle other key events
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
