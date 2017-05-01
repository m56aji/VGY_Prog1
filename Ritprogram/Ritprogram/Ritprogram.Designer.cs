namespace Ritprogram
{
    partial class Ritprogram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ritare1 = new Ritare.Ritare();
            this.SuspendLayout();
            // 
            // ritare1
            // 
            this.ritare1.Location = new System.Drawing.Point(12, 12);
            this.ritare1.Name = "ritare1";
            this.ritare1.Size = new System.Drawing.Size(264, 240);
            this.ritare1.TabIndex = 0;
            // 
            // Ritprogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ritare1);
            this.Name = "Ritprogram";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ritare.Ritare ritare1;
    }
}

