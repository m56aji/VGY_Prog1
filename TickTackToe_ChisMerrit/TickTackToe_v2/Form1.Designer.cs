namespace TickTackToe_v2
{
    partial class Form1
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
            this.nyOmgångToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omSpeletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.o_vinst_count = new System.Windows.Forms.Label();
            this.oavgjort_count = new System.Windows.Forms.Label();
            this.x_vinst_count = new System.Windows.Forms.Label();
            this.nollställRäknareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyOmgångToolStripMenuItem,
            this.nollställRäknareToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // nyOmgångToolStripMenuItem
            // 
            this.nyOmgångToolStripMenuItem.Name = "nyOmgångToolStripMenuItem";
            this.nyOmgångToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nyOmgångToolStripMenuItem.Text = "Ny omgång";
            this.nyOmgångToolStripMenuItem.Click += new System.EventHandler(this.nyOmgångToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omSpeletToolStripMenuItem});
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            // 
            // omSpeletToolStripMenuItem
            // 
            this.omSpeletToolStripMenuItem.Name = "omSpeletToolStripMenuItem";
            this.omSpeletToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.omSpeletToolStripMenuItem.Text = "Om spelet";
            this.omSpeletToolStripMenuItem.Click += new System.EventHandler(this.omSpeletToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(25, 49);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            this.A1.MouseEnter += new System.EventHandler(this.Button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(106, 49);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            this.A2.MouseEnter += new System.EventHandler(this.Button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(187, 49);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            this.A3.MouseEnter += new System.EventHandler(this.Button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(187, 130);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            this.B3.MouseEnter += new System.EventHandler(this.Button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(106, 130);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            this.B2.MouseEnter += new System.EventHandler(this.Button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(25, 130);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            this.B1.MouseEnter += new System.EventHandler(this.Button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(187, 211);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            this.C3.MouseEnter += new System.EventHandler(this.Button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(106, 211);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            this.C2.MouseEnter += new System.EventHandler(this.Button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(25, 211);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            this.C1.MouseEnter += new System.EventHandler(this.Button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.Button_leave);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.Location = new System.Drawing.Point(27, 294);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(49, 13);
            this.label_1.TabIndex = 10;
            this.label_1.Text = "X-Vinster";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.Location = new System.Drawing.Point(113, 294);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(47, 13);
            this.label_2.TabIndex = 11;
            this.label_2.Text = "Oavgjort";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(199, 294);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(50, 13);
            this.label_3.TabIndex = 12;
            this.label_3.Text = "O-Vinster";
            // 
            // o_vinst_count
            // 
            this.o_vinst_count.AutoSize = true;
            this.o_vinst_count.Location = new System.Drawing.Point(214, 319);
            this.o_vinst_count.Name = "o_vinst_count";
            this.o_vinst_count.Size = new System.Drawing.Size(13, 13);
            this.o_vinst_count.TabIndex = 15;
            this.o_vinst_count.Text = "0";
            // 
            // oavgjort_count
            // 
            this.oavgjort_count.AutoSize = true;
            this.oavgjort_count.Location = new System.Drawing.Point(128, 319);
            this.oavgjort_count.Name = "oavgjort_count";
            this.oavgjort_count.Size = new System.Drawing.Size(13, 13);
            this.oavgjort_count.TabIndex = 14;
            this.oavgjort_count.Text = "0";
            // 
            // x_vinst_count
            // 
            this.x_vinst_count.AutoSize = true;
            this.x_vinst_count.Location = new System.Drawing.Point(42, 319);
            this.x_vinst_count.Name = "x_vinst_count";
            this.x_vinst_count.Size = new System.Drawing.Size(13, 13);
            this.x_vinst_count.TabIndex = 13;
            this.x_vinst_count.Text = "0";
            // 
            // nollställRäknareToolStripMenuItem
            // 
            this.nollställRäknareToolStripMenuItem.Name = "nollställRäknareToolStripMenuItem";
            this.nollställRäknareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nollställRäknareToolStripMenuItem.Text = "Nollställ Räknare";
            this.nollställRäknareToolStripMenuItem.Click += new System.EventHandler(this.nollställRäknareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 341);
            this.Controls.Add(this.o_vinst_count);
            this.Controls.Add(this.oavgjort_count);
            this.Controls.Add(this.x_vinst_count);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tre i rad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyOmgångToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omSpeletToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;        
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label o_vinst_count;
        private System.Windows.Forms.Label oavgjort_count;
        private System.Windows.Forms.Label x_vinst_count;
        private System.Windows.Forms.ToolStripMenuItem nollställRäknareToolStripMenuItem;
    }
}

