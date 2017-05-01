//Ett enkelt fönster med ett textfält, en label som kan flyttas upp och ner 
//och en timer som stänger ner programmet när den nått max.

using System;
using System.Windows.Forms;

namespace ToolStripÖvning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                label1.Text = toolStripTextBox1.Text;
                e.Handled = true;
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            label1.Dock = DockStyle.Top;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            label1.Dock = DockStyle.Bottom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
                Application.Exit();
        }
    }
}
