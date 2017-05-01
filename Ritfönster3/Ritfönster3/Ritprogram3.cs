using System;
using System.Windows.Forms;

namespace Ritfönster3
{
    public partial class RitProgram3 : Form
    {
        static int nästaNr = 0;
        public RitProgram3()
        {
            InitializeComponent();
        }

        private void nyttFönsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Internt f = new Internt();      //Den egna klassen Internt
            f.MdiParent = this;             //Ritprogram3 är föräldrarklass till MDI fönstren
            f.Text = "Ritare " + ++nästaNr;
            f.Show();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void förskjutnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horisontelltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vertikaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
