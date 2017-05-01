using System;
using System.Windows.Forms;

namespace RoterandePolygon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            poly21.Init(5, 50, 100); //Vår instans heter poly21(Se Databinding i Properties-Fliken)
            poly1.Init(5, 50, 100); //Mitt val att ha dubbla
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            poly21.Start();
            poly1.Start();      //Mitt val att ha dubbla
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            poly21.Stop();
            poly1.Stop();       //Mitt val att ha dubbla
        }
    }
}
