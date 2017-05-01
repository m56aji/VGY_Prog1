using System;
using System.Windows.Forms;

namespace SoundPlayer
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(); //Måste ange hela sökvägen eftersom vårt namnspace är identiskt

        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                player.SoundLocation = openFileDialog1.FileName;
                try                                             //Try-catch så fort vi försöker öppna filer
                {
                    player.Play();
                    label.Text = "" + openFileDialog1.FileName;
                }
                catch (Exception)
                {
                    label.Text = "Kan inte spela filen " + openFileDialog1.FileName;
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            label.Text = "";
        }
    }
}
