using System;
using System.Windows.Forms;

namespace Ritfönster3
{
    public partial class Internt : Form
    {
        public Internt()
        {
            InitializeComponent();
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bytFärgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ritare1.ÄndraFärg();
        }
    }
}
