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
            Dice myDice1 = new Dice(Color.Empty);
            myDice1.Color = myDice1.PickDice();
            txtDiceColor1.BackColor = myDice1.Color;
            txtDiceResult1.Text = "";
            string diceRollResult1 = myDice1.Roll();
            txtDiceResult1.Text += diceRollResult1;

            Dice myDice2 = new Dice(Color.Empty);
            myDice2.Color = myDice2.PickDice();
            txtDiceColor2.BackColor = myDice2.Color;
            txtDiceResult2.Text = "";
            string diceRollResult2 = myDice1.Roll();
            txtDiceResult2.Text += diceRollResult2;

            Dice myDice3 = new Dice(Color.Empty);
            myDice3.Color = myDice3.PickDice();
            txtDiceColor3.BackColor = myDice3.Color;
            txtDiceResult3.Text = "";
            string diceRollResult3 = myDice1.Roll();
            txtDiceResult3.Text += diceRollResult3;
        }
    }
}
