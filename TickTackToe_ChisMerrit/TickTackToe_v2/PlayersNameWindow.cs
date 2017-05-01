using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe_v2
{
    public partial class PlayersNameWindow : Form
    {
        public PlayersNameWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setSpelarNamn(spelare1.Text, spelare2.Text);
            this.Close();
        }
    }
}
