using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad2
{
    public partial class Notepad : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string filename = null;
        bool isUnsaved = false;
        bool ignoreTextChangedEvent = false;

        public Notepad()
        {
            InitializeComponent();
            UppdateTitle();
        }

        private void UppdateTitle()
        {
            string file;
            if (string.IsNullOrEmpty(filename))
                file = "Unnamed";
            else
                file = Path.GetFileName(filename);

            if (isUnsaved)
                Text = file + "* -Notepad";
            else
                Text = file + " -Notepad";
        }

        private void saveFile()
        {
            if (string.IsNullOrEmpty(filename))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    filename = saveFileDialog.FileName;
                else
                    return;
            }

            File.WriteAllText(filename, textBox1.Text);
            isUnsaved = false;
            UppdateTitle();
        }

        private void nyToolStripMenuItem_Click(object sender, EventArgs e)  //Arkiv-Ny rullgardinsmeny
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
                return;

            textBox1.Text = string.Empty;
            filename = null;
            isUnsaved = false;
            UppdateTitle();
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
                return;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ignoreTextChangedEvent = true;
                textBox1.Text = File.ReadAllText(openFileDialog.FileName);
                filename = openFileDialog.FileName;
                isUnsaved = false;
                UppdateTitle();
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ignoreTextChangedEvent)
            {
                ignoreTextChangedEvent = false;
                return;
            }
            isUnsaved = true;
            UppdateTitle();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUnsaved)
            {
                var res = MessageBox.Show(this, "Would you like to save canges?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                    saveFile();
                else if (res == DialogResult.No)
                {
                    //Do nothing
                }
                else if (res == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
