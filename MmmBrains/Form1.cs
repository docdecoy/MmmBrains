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

        private DiceCup _diceCup = new DiceCup();

        public Form1()
        {
            InitializeComponent();
            txtDiceInCup.Text = _diceCup.DiceInCup.Count.ToString();
        }

        private static void SetTextBox(TextBox textbox, Dice dice)
        {
            textbox.BackColor = dice.Color;
            textbox.Text = DiceFaceToStr(dice.Roll());
        }

        private static void ResetTextBox(TextBox textbox, bool isVisible)
        {
            textbox.Visible = isVisible;
            textbox.BackColor = Color.White;
            textbox.Text = "";
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {

            List<Dice> diceInHand = _diceCup.TakeDice(3);

            if (diceInHand.Count > 0)
            {
                SetTextBox(txtDiceResult1, diceInHand[0]);
            }
            else
            {
                ResetTextBox(txtDiceResult1, false);
            }

            if (diceInHand.Count > 1)
            {
                SetTextBox(txtDiceResult2, diceInHand[1]);
            }
            else
            {
                ResetTextBox(txtDiceResult2, false);
            }

            if (diceInHand.Count > 2)
            {
                SetTextBox(txtDiceResult3, diceInHand[2]);
            }
            else
            {
                ResetTextBox(txtDiceResult3, false);
            }

            txtDiceInCup.Text = _diceCup.DiceInCup.Count.ToString();
            if (_diceCup.DiceInCup.Count == 0)
            {
                btnRoll.Enabled = false;
                btnReset.Focus();
            }
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            _diceCup.Reset();
            txtDiceInCup.Text = _diceCup.DiceInCup.Count.ToString();

            ResetTextBox(txtDiceResult1, true);
            ResetTextBox(txtDiceResult2, true);
            ResetTextBox(txtDiceResult3, true);
            btnRoll.Enabled = true;
        }
    }
}
