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
            Dice myDice = new Dice(Color.Red);
            txtDiceResult1.Text = "";
            string diceRollResult1 = myDice.Roll();
            txtDiceResult1.Text += diceRollResult1;

            Dice myDice2 = new Dice(Color.Yellow);
            txtDiceResult2.Text = "";
            string diceRollResult2 = myDice.Roll();
            txtDiceResult2.Text += diceRollResult2;

            Dice myDice3 = new Dice(Color.Green);
            txtDiceResult3.Text = "";
            string diceRollResult3 = myDice.Roll();
            txtDiceResult3.Text += diceRollResult3;
        }
    }
}
