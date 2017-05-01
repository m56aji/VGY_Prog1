namespace Ritfönster3
{
    partial class Internt
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ritare1 = new Ritare.Ritare();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.färgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bytFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ritare1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(284, 237);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(284, 261);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.färgToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // ritare1
            // 
            this.ritare1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ritare1.Location = new System.Drawing.Point(0, 0);
            this.ritare1.Name = "ritare1";
            this.ritare1.Size = new System.Drawing.Size(284, 237);
            this.ritare1.TabIndex = 0;
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stängToolStripMenuItem});
            this.arkivToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // färgToolStripMenuItem
            // 
            this.färgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bytFärgToolStripMenuItem});
            this.färgToolStripMenuItem.Name = "färgToolStripMenuItem";
            this.färgToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.färgToolStripMenuItem.Text = "Färg";
            // 
            // stängToolStripMenuItem
            // 
            this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
            this.stängToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stängToolStripMenuItem.Text = "Stäng";
            this.stängToolStripMenuItem.Click += new System.EventHandler(this.stängToolStripMenuItem_Click);
            // 
            // bytFärgToolStripMenuItem
            // 
            this.bytFärgToolStripMenuItem.Name = "bytFärgToolStripMenuItem";
            this.bytFärgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bytFärgToolStripMenuItem.Text = "Byt Färg";
            this.bytFärgToolStripMenuItem.Click += new System.EventHandler(this.bytFärgToolStripMenuItem_Click);
            // 
            // Internt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Internt";
            this.Text = "Internt";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Ritare.Ritare ritare1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem färgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bytFärgToolStripMenuItem;
    }
}