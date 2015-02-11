using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MmmBrains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Dice myDice1 = new Dice();
            txtDiceResult1.BackColor = myDice1.DiceFaceColor();
            txtDiceResult1.Text = DiceFaceToStr(myDice1.Roll());

            Dice myDice2 = new Dice();
            txtDiceResult2.BackColor = myDice2.DiceFaceColor();
            txtDiceResult2.Text = DiceFaceToStr(myDice2.Roll());

            Dice myDice3 = new Dice();
            txtDiceResult3.BackColor = myDice3.DiceFaceColor();
            txtDiceResult3.Text = DiceFaceToStr(myDice3.Roll());
        }

        private static string DiceFaceToStr(DiceFaceImage faceImage)
        {
            switch (faceImage)
            {
                case DiceFaceImage.Brain:
                    return "B";
                case DiceFaceImage.Feet:
                    return "F";
                case DiceFaceImage.Shotgun:
                    return "S";
            }
            throw new InvalidOperationException();
        }
    }
}
