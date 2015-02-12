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

        private void btnRoll_Click(object sender, EventArgs e)
        {

            List<Dice> diceInHand = _diceCup.TakeDice(3);

            if (diceInHand.Count > 0)
            {
                txtDiceResult1.BackColor = diceInHand[0].Color;
                txtDiceResult1.Text = DiceFaceToStr(diceInHand[0].Roll());
            }
            else
            {
                txtDiceResult1.Visible = false;
                txtDiceResult1.BackColor = Color.White;
                txtDiceResult1.Text = "";
            }

            if (diceInHand.Count > 1)
            {
                txtDiceResult2.BackColor = diceInHand[1].Color;
                txtDiceResult2.Text = DiceFaceToStr(diceInHand[1].Roll());
            }
            else
            {
                txtDiceResult2.Visible = false;
                txtDiceResult2.BackColor = Color.White;
                txtDiceResult2.Text = "";
            }

            if (diceInHand.Count > 2)
            {
                txtDiceResult3.BackColor = diceInHand[2].Color;
                txtDiceResult3.Text = DiceFaceToStr(diceInHand[2].Roll());
            }
            else
            {
                txtDiceResult3.Visible = false;
                txtDiceResult3.BackColor = Color.White;
                txtDiceResult3.Text = "";
            }

            txtDiceInCup.Text = _diceCup.DiceInCup.Count.ToString();
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
            txtDiceResult1.Visible = true;
            txtDiceResult2.Visible = true;
            txtDiceResult3.Visible = true;
            txtDiceResult1.BackColor = Color.White;
            txtDiceResult1.Text = "";
            txtDiceResult2.BackColor = Color.White;
            txtDiceResult2.Text = "";
            txtDiceResult3.BackColor = Color.White;
            txtDiceResult3.Text = "";
        }
    }
}
