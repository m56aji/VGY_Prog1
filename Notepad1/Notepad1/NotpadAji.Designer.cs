namespace Notepad1
{
    partial class Notepad
    {

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
         private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem utskriftformatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skrivUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem redigeraToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.redigeraToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.visaToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
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
            // 
            // nyToolStripMenuItem
            // 
            resources.ApplyResources(this.nyToolStripMenuItem, "nyToolStripMenuItem");
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.Click += new System.EventHandler(this.nyToolStripMenuItem_Click);
            // 
            // öppnaToolStripMenuItem
            // 
            resources.ApplyResources(this.öppnaToolStripMenuItem, "öppnaToolStripMenuItem");
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            resources.ApplyResources(this.sparaToolStripMenuItem, "sparaToolStripMenuItem");
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            resources.ApplyResources(this.sparaSomToolStripMenuItem, "sparaSomToolStripMenuItem");
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // utskriftformatToolStripMenuItem
            // 
            resources.ApplyResources(this.utskriftformatToolStripMenuItem, "utskriftformatToolStripMenuItem");
            this.utskriftformatToolStripMenuItem.Name = "utskriftformatToolStripMenuItem";
            // 
            // skrivUtToolStripMenuItem
            // 
            resources.ApplyResources(this.skrivUtToolStripMenuItem, "skrivUtToolStripMenuItem");
            this.skrivUtToolStripMenuItem.Name = "skrivUtToolStripMenuItem";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // avslutaToolStripMenuItem
            // 
            resources.ApplyResources(this.avslutaToolStripMenuItem, "avslutaToolStripMenuItem");
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // redigeraToolStripMenuItem
            // 
            resources.ApplyResources(this.redigeraToolStripMenuItem, "redigeraToolStripMenuItem");
            this.redigeraToolStripMenuItem.Name = "redigeraToolStripMenuItem";
            // 
            // formatToolStripMenuItem
            // 
            resources.ApplyResources(this.formatToolStripMenuItem, "formatToolStripMenuItem");
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            // 
            // visaToolStripMenuItem
            // 
            resources.ApplyResources(this.visaToolStripMenuItem, "visaToolStripMenuItem");
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            // 
            // hjälpToolStripMenuItem
            // 
            resources.ApplyResources(this.hjälpToolStripMenuItem, "hjälpToolStripMenuItem");
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Notepad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notepad";
            this.ShowIcon = false;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

