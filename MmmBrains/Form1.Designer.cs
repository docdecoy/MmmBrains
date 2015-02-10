namespace MmmBrains
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
            this.txtDiceColor1 = new System.Windows.Forms.TextBox();
            this.txtDiceColor2 = new System.Windows.Forms.TextBox();
            this.txtDiceColor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(245, 141);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtDiceResult1
            // 
            this.txtDiceResult1.Location = new System.Drawing.Point(351, 63);
            this.txtDiceResult1.Name = "txtDiceResult1";
            this.txtDiceResult1.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult1.TabIndex = 2;
            this.txtDiceResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiceResult2
            // 
            this.txtDiceResult2.Location = new System.Drawing.Point(351, 89);
            this.txtDiceResult2.Name = "txtDiceResult2";
            this.txtDiceResult2.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult2.TabIndex = 3;
            this.txtDiceResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiceResult3
            // 
            this.txtDiceResult3.Location = new System.Drawing.Point(351, 115);
            this.txtDiceResult3.Name = "txtDiceResult3";
            this.txtDiceResult3.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult3.TabIndex = 4;
            this.txtDiceResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiceColor1
            // 
            this.txtDiceColor1.Location = new System.Drawing.Point(245, 63);
            this.txtDiceColor1.Name = "txtDiceColor1";
            this.txtDiceColor1.Size = new System.Drawing.Size(100, 20);
            this.txtDiceColor1.TabIndex = 5;
            // 
            // txtDiceColor2
            // 
            this.txtDiceColor2.Location = new System.Drawing.Point(245, 89);
            this.txtDiceColor2.Name = "txtDiceColor2";
            this.txtDiceColor2.Size = new System.Drawing.Size(100, 20);
            this.txtDiceColor2.TabIndex = 6;
            // 
            // txtDiceColor3
            // 
            this.txtDiceColor3.Location = new System.Drawing.Point(245, 115);
            this.txtDiceColor3.Name = "txtDiceColor3";
            this.txtDiceColor3.Size = new System.Drawing.Size(100, 20);
            this.txtDiceColor3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.txtDiceColor3);
            this.Controls.Add(this.txtDiceColor2);
            this.Controls.Add(this.txtDiceColor1);
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
        private System.Windows.Forms.TextBox txtDiceColor1;
        private System.Windows.Forms.TextBox txtDiceColor2;
        private System.Windows.Forms.TextBox txtDiceColor3;
    }
}

