﻿namespace TickTackToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

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
            //this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // button1-9
            // 
            for (int i = 0; i < 9; i++)
            {
                this.button1 = new System.Windows.Forms.Button();
                this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button1.Location = new System.Drawing.Point(13, 12);
                this.button1.Name = "button" + (i+1).ToString();
                this.button1.Size = new System.Drawing.Size(110, 110);
                this.button1.TabIndex = i;
                this.button1.UseVisualStyleBackColor = false;
                this.button1.Click += new System.EventHandler(this.Button_Click);
            }
            //// 
            //// button1
            //// 
            //this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button1.Location = new System.Drawing.Point(13, 12);
            //this.button1.Name = "button1";
            //this.button1.Size = new System.Drawing.Size(110, 110);
            //this.button1.TabIndex = 0;
            //this.button1.UseVisualStyleBackColor = false;
            //this.button1.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button2
            //// 
            //this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button2.Location = new System.Drawing.Point(128, 12);
            //this.button2.Name = "button2";
            //this.button2.Size = new System.Drawing.Size(110, 110);
            //this.button2.TabIndex = 1;
            //this.button2.UseVisualStyleBackColor = false;
            //this.button2.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button3
            //// 
            //this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button3.Location = new System.Drawing.Point(244, 12);
            //this.button3.Name = "button3";
            //this.button3.Size = new System.Drawing.Size(110, 110);
            //this.button3.TabIndex = 2;
            //this.button3.UseVisualStyleBackColor = false;
            //this.button3.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button4
            //// 
            //this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button4.Location = new System.Drawing.Point(12, 128);
            //this.button4.Name = "button4";
            //this.button4.Size = new System.Drawing.Size(110, 110);
            //this.button4.TabIndex = 4;
            //this.button4.UseVisualStyleBackColor = false;
            //this.button4.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button5
            //// 
            //this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button5.Location = new System.Drawing.Point(128, 128);
            //this.button5.Name = "button5";
            //this.button5.Size = new System.Drawing.Size(110, 110);
            //this.button5.TabIndex = 3;
            //this.button5.UseVisualStyleBackColor = false;
            //this.button5.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button6
            //// 
            //this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button6.Location = new System.Drawing.Point(244, 128);
            //this.button6.Name = "button6";
            //this.button6.Size = new System.Drawing.Size(110, 110);
            //this.button6.TabIndex = 5;
            //this.button6.UseVisualStyleBackColor = false;
            //this.button6.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button7
            //// 
            //this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button7.Location = new System.Drawing.Point(12, 244);
            //this.button7.Name = "button7";
            //this.button7.Size = new System.Drawing.Size(110, 110);
            //this.button7.TabIndex = 6;
            //this.button7.UseVisualStyleBackColor = false;
            //this.button7.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button8
            //// 
            //this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button8.Location = new System.Drawing.Point(128, 244);
            //this.button8.Name = "button8";
            //this.button8.Size = new System.Drawing.Size(110, 110);
            //this.button8.TabIndex = 7;
            //this.button8.UseVisualStyleBackColor = false;
            //this.button8.Click += new System.EventHandler(this.Button_Click);
            //// 
            //// button9
            //// 
            //this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            //this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.button9.Location = new System.Drawing.Point(244, 244);
            //this.button9.Name = "button9";
            //this.button9.Size = new System.Drawing.Size(110, 110);
            //this.button9.TabIndex = 8;
            //this.button9.UseVisualStyleBackColor = false;
            //this.button9.Click += new System.EventHandler(this.Button_Click);


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 361);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tre i rad";
            this.ResumeLayout(false);
        }
        #endregion
    }
}

