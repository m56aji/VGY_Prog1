using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad1
{
    public partial class Notepad : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string filename = null;

        public Notepad()
        {
            InitializeComponent();
        }

        private void nyToolStripMenuItem_Click(object sender, EventArgs e)  //Arkiv-Ny rullgardinsmeny
        {
            textBox1.Text = string.Empty;
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                filename = openFileDialog.FileName;
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
                return;

            File.WriteAllText(filename, textBox1.Text);
        }
    }
}
