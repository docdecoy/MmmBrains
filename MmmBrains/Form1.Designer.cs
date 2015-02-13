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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiceInCup = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pctDiceResult1 = new System.Windows.Forms.PictureBox();
            this.pctDiceResult2 = new System.Windows.Forms.PictureBox();
            this.pctDiceResult3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiceResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiceResult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiceResult3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(257, 53);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 27);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtDiceResult1
            // 
            this.txtDiceResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceResult1.Location = new System.Drawing.Point(78, 271);
            this.txtDiceResult1.Name = "txtDiceResult1";
            this.txtDiceResult1.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult1.TabIndex = 2;
            this.txtDiceResult1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiceResult1.Visible = false;
            // 
            // txtDiceResult2
            // 
            this.txtDiceResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceResult2.Location = new System.Drawing.Point(78, 297);
            this.txtDiceResult2.Name = "txtDiceResult2";
            this.txtDiceResult2.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult2.TabIndex = 3;
            this.txtDiceResult2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiceResult2.Visible = false;
            // 
            // txtDiceResult3
            // 
            this.txtDiceResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceResult3.Location = new System.Drawing.Point(78, 323);
            this.txtDiceResult3.Name = "txtDiceResult3";
            this.txtDiceResult3.Size = new System.Drawing.Size(29, 20);
            this.txtDiceResult3.TabIndex = 4;
            this.txtDiceResult3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiceResult3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dice In Cup";
            // 
            // txtDiceInCup
            // 
            this.txtDiceInCup.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiceInCup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiceInCup.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiceInCup.Location = new System.Drawing.Point(78, 78);
            this.txtDiceInCup.Name = "txtDiceInCup";
            this.txtDiceInCup.Size = new System.Drawing.Size(29, 26);
            this.txtDiceInCup.TabIndex = 6;
            this.txtDiceInCup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(257, 99);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Stop!";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pctDiceResult1
            // 
            this.pctDiceResult1.Location = new System.Drawing.Point(269, 145);
            this.pctDiceResult1.Name = "pctDiceResult1";
            this.pctDiceResult1.Size = new System.Drawing.Size(50, 50);
            this.pctDiceResult1.TabIndex = 8;
            this.pctDiceResult1.TabStop = false;
            // 
            // pctDiceResult2
            // 
            this.pctDiceResult2.Location = new System.Drawing.Point(269, 218);
            this.pctDiceResult2.Name = "pctDiceResult2";
            this.pctDiceResult2.Size = new System.Drawing.Size(50, 50);
            this.pctDiceResult2.TabIndex = 9;
            this.pctDiceResult2.TabStop = false;
            // 
            // pctDiceResult3
            // 
            this.pctDiceResult3.Location = new System.Drawing.Point(269, 291);
            this.pctDiceResult3.Name = "pctDiceResult3";
            this.pctDiceResult3.Size = new System.Drawing.Size(50, 50);
            this.pctDiceResult3.TabIndex = 10;
            this.pctDiceResult3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.pctDiceResult3);
            this.Controls.Add(this.pctDiceResult2);
            this.Controls.Add(this.pctDiceResult1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtDiceInCup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiceResult3);
            this.Controls.Add(this.txtDiceResult2);
            this.Controls.Add(this.txtDiceResult1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "MmmBrains";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDiceResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiceResult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDiceResult3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtDiceResult1;
        private System.Windows.Forms.TextBox txtDiceResult2;
        private System.Windows.Forms.TextBox txtDiceResult3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiceInCup;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pctDiceResult1;
        private System.Windows.Forms.PictureBox pctDiceResult2;
        private System.Windows.Forms.PictureBox pctDiceResult3;
    }
}

