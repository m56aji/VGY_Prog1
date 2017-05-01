namespace TickTackToe_v2
{
    partial class PlayersNameWindow
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
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.spelare1 = new System.Windows.Forms.TextBox();
            this.spelare2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.Location = new System.Drawing.Point(13, 13);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(157, 24);
            this.player1.TabIndex = 0;
            this.player1.Text = "Spelare 1:s namn";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.Location = new System.Drawing.Point(13, 53);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(157, 24);
            this.player2.TabIndex = 1;
            this.player2.Text = "Spelare 2:s namn";
            // 
            // spelare1
            // 
            this.spelare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spelare1.Location = new System.Drawing.Point(217, 16);
            this.spelare1.Name = "spelare1";
            this.spelare1.Size = new System.Drawing.Size(383, 26);
            this.spelare1.TabIndex = 2;
            // 
            // spelare2
            // 
            this.spelare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spelare2.Location = new System.Drawing.Point(217, 48);
            this.spelare2.Name = "spelare2";
            this.spelare2.Size = new System.Drawing.Size(383, 26);
            this.spelare2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Starta spelet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayersNameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spelare2);
            this.Controls.Add(this.spelare1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.MaximumSize = new System.Drawing.Size(628, 161);
            this.MinimumSize = new System.Drawing.Size(628, 161);
            this.Name = "PlayersNameWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayersNameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.TextBox spelare1;
        private System.Windows.Forms.TextBox spelare2;
        private System.Windows.Forms.Button button1;
    }
}