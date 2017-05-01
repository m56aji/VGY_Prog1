namespace Ritfönster3
{
    partial class RitProgram3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fönsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttFönsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.förskjutnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horisontelltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertikaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.placeringToolStripMenuItem,
            this.fönsterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.fönsterToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttFönsterToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // placeringToolStripMenuItem
            // 
            this.placeringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.förskjutnaToolStripMenuItem,
            this.horisontelltToolStripMenuItem,
            this.vertikaltToolStripMenuItem});
            this.placeringToolStripMenuItem.Name = "placeringToolStripMenuItem";
            this.placeringToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.placeringToolStripMenuItem.Text = "Placering";
            // 
            // fönsterToolStripMenuItem
            // 
            this.fönsterToolStripMenuItem.Name = "fönsterToolStripMenuItem";
            this.fönsterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fönsterToolStripMenuItem.Text = "Fönster";
            // 
            // nyttFönsterToolStripMenuItem
            // 
            this.nyttFönsterToolStripMenuItem.Name = "nyttFönsterToolStripMenuItem";
            this.nyttFönsterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nyttFönsterToolStripMenuItem.Text = "Nytt Fönster";
            this.nyttFönsterToolStripMenuItem.Click += new System.EventHandler(this.nyttFönsterToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // förskjutnaToolStripMenuItem
            // 
            this.förskjutnaToolStripMenuItem.Name = "förskjutnaToolStripMenuItem";
            this.förskjutnaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.förskjutnaToolStripMenuItem.Text = "Förskjutna";
            this.förskjutnaToolStripMenuItem.Click += new System.EventHandler(this.förskjutnaToolStripMenuItem_Click);
            // 
            // horisontelltToolStripMenuItem
            // 
            this.horisontelltToolStripMenuItem.Name = "horisontelltToolStripMenuItem";
            this.horisontelltToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horisontelltToolStripMenuItem.Text = "Horisontellt";
            this.horisontelltToolStripMenuItem.Click += new System.EventHandler(this.horisontelltToolStripMenuItem_Click);
            // 
            // vertikaltToolStripMenuItem
            // 
            this.vertikaltToolStripMenuItem.Name = "vertikaltToolStripMenuItem";
            this.vertikaltToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vertikaltToolStripMenuItem.Text = "Vertikalt";
            this.vertikaltToolStripMenuItem.Click += new System.EventHandler(this.vertikaltToolStripMenuItem_Click);
            // 
            // RitProgram3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RitProgram3";
            this.Text = "Ritprogram3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyttFönsterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem förskjutnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horisontelltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertikaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fönsterToolStripMenuItem;
    }
}

