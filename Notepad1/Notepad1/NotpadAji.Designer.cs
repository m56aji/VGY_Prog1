namespace Notepad1
{
    partial class Notepad
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.utskriftformatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skrivUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 237);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.redigeraToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.visaToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.toolStripSeparator1,
            this.utskriftformatToolStripMenuItem,
            this.skrivUtToolStripMenuItem,
            this.toolStripSeparator2,
            this.avslutaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Arikiv";
            // 
            // nyToolStripMenuItem
            // 
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nyToolStripMenuItem.Text = "Ny";
            this.nyToolStripMenuItem.Click += new System.EventHandler(this.nyToolStripMenuItem_Click);
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // utskriftformatToolStripMenuItem
            // 
            this.utskriftformatToolStripMenuItem.Name = "utskriftformatToolStripMenuItem";
            this.utskriftformatToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.utskriftformatToolStripMenuItem.Text = "Utskriftformat...";
            // 
            // skrivUtToolStripMenuItem
            // 
            this.skrivUtToolStripMenuItem.Name = "skrivUtToolStripMenuItem";
            this.skrivUtToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.skrivUtToolStripMenuItem.Text = "Skriv ut...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            // 
            // redigeraToolStripMenuItem
            // 
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            this.redigeraToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.redigeraToolStripMenuItem.Text = "Redigera";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // visaToolStripMenuItem
            // 
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            this.visaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.visaToolStripMenuItem.Text = "Visa";
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text filer|*.txt";
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem utskriftformatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skrivUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

