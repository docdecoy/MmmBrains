﻿namespace MmmBrains
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtDiceResult1 = new System.Windows.Forms.TextBox();
            this.txtDiceResult2 = new System.Windows.Forms.TextBox();
            this.txtDiceResult3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(245, 163);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(66, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtDiceResult1
            // 
            this.txtDiceResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceResult1.Location = new System.Drawing.Point(264, 68);
            this.txtDiceResult1.Name = "txtDiceResult1";
            this.txtDiceResult1.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult1.TabIndex = 2;
            this.txtDiceResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiceResult2
            // 
            this.txtDiceResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceResult2.Location = new System.Drawing.Point(264, 94);
            this.txtDiceResult2.Name = "txtDiceResult2";
            this.txtDiceResult2.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult2.TabIndex = 3;
            this.txtDiceResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiceResult3
            // 
            this.txtDiceResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceResult3.Location = new System.Drawing.Point(264, 120);
            this.txtDiceResult3.Name = "txtDiceResult3";
            this.txtDiceResult3.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult3.TabIndex = 4;
            this.txtDiceResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.txtDiceResult3);
            this.Controls.Add(this.txtDiceResult2);
            this.Controls.Add(this.txtDiceResult1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "MmmBrains";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtDiceResult1;
        private System.Windows.Forms.TextBox txtDiceResult2;
        private System.Windows.Forms.TextBox txtDiceResult3;
    }
}

