using System;
using System.Windows.Forms;
using WMPLib;

namespace WindowsMediaPlayer
{
    public partial class Form1 : Form
    {
        bool finished = false;

        public Form1()
        {
            InitializeComponent();
        }

         private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                finished = false;
                axWindowsMediaPlayer1.URL  = openFileDialog1.FileName;
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            finished = false;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            finished = false;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            finished = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        //Om det av någon anledning inte skulle gå att spela filen...
        private void axWindowsMediaPlayer1_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            label1.Text = "Kan inte spela filen " + openFileDialog1.FileName;
        }

        //Visar status för pågående uppspelning
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPPlayState.wmppsPlaying)
                label1.Text = openFileDialog1.FileName + " [Spelar]";
            else if (e.newState == (int)WMPPlayState.wmppsPaused)
                label1.Text = openFileDialog1.FileName + " [Pausad]";
            else if (e.newState == (int)WMPPlayState.wmppsStopped)
            {
                if (!finished)
                    label1.Text = openFileDialog1.FileName + " [Stoppad]";
            }
            else if (e.newState == (int)WMPPlayState.wmppsMediaEnded)
            {
                label1.Text = openFileDialog1.FileName + " [Avslutad]";
                finished = true;
            }
        }
    }
}
