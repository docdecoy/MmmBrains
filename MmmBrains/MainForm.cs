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
    public partial class MainForm : Form
    {
        private DiceCup _diceCup = new DiceCup();
        private List<DiceFaceImage> _rolledShotguns = new List<DiceFaceImage>();
        private List<DiceFaceImage> _rolledBrains = new List<DiceFaceImage>();
        private List<DiceFaceImage> _rolledFeet = new List<DiceFaceImage>();

        public MainForm()
        {
            InitializeComponent();
            lblDiceInCup.Text = _diceCup.DiceInCup.Count.ToString();
        }

        private static void SetPctBox(PictureBox pctbox, Dice dice)
        {
            pctbox.Image = DiceFaceToImg(dice.Roll());
        }

        private static void ResetPctBox(PictureBox pctbox)
        {
            pctbox.Image = null;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            List<Dice> diceInHand = _diceCup.TakeDice(3);
            //foreach (var dice in _rolledFeet)
            //{
            //    diceInHand.Add(dice);

            //}

            // Roll my dice (TODO: do something with this?)
            foreach (var dice in diceInHand)
            {
                var diceRollResult = dice.Roll();
                switch (diceRollResult)
                {
                    case DiceFaceImage.GreenBrain:
                    case DiceFaceImage.YellowBrain:
                    case DiceFaceImage.RedBrain:
                        _rolledBrains.Add(diceRollResult);
                        break;
                    case DiceFaceImage.GreenFeet:
                    case DiceFaceImage.YellowFeet:
                    case DiceFaceImage.RedFeet:
                        _rolledFeet.Add(diceRollResult);
                        break;
                    case DiceFaceImage.GreenShotgun:
                    case DiceFaceImage.YellowShotgun:
                    case DiceFaceImage.RedShotgun:
                        _rolledShotguns.Add(diceRollResult);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (diceInHand.Count > 0)
            {
                SetPctBox(pctDiceResult1, diceInHand[0]);
            }
            else
            {
                ResetPctBox(pctDiceResult1);
            }

            if (diceInHand.Count > 1)
            {
                SetPctBox(pctDiceResult2, diceInHand[1]);
            }
            else
            {
                ResetPctBox(pctDiceResult2);
            }

            if (diceInHand.Count > 2)
            {
                SetPctBox(pctDiceResult3, diceInHand[2]);
            }
            else
            {
                ResetPctBox(pctDiceResult3);
            }

            lblDiceInCup.Text = _diceCup.DiceInCup.Count.ToString();
            if (_diceCup.DiceInCup.Count == 0)
            {
                btnRoll.Enabled = false;
                btnReset.Focus();
            }
        }

        private static Image DiceFaceToImg(DiceFaceImage faceImage)
        {
            switch (faceImage)
            {
                case DiceFaceImage.GreenBrain:
                    return Properties.Resources.GB;
                case DiceFaceImage.GreenFeet:
                    return Properties.Resources.GF;
                case DiceFaceImage.GreenShotgun:
                    return Properties.Resources.GS;
                case DiceFaceImage.YellowBrain:
                    return Properties.Resources.YB;
                case DiceFaceImage.YellowFeet:
                    return Properties.Resources.YF;
                case DiceFaceImage.YellowShotgun:
                    return Properties.Resources.YS;
                case DiceFaceImage.RedBrain:
                    return Properties.Resources.RB;
                case DiceFaceImage.RedFeet:
                    return Properties.Resources.RF;
                case DiceFaceImage.RedShotgun:
                    return Properties.Resources.RS;
            }
            throw new InvalidOperationException();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _diceCup.Reset();
            lblDiceInCup.Text = _diceCup.DiceInCup.Count.ToString();

            ResetPctBox(pctDiceResult1);
            ResetPctBox(pctDiceResult2);
            ResetPctBox(pctDiceResult3);
            btnRoll.Enabled = true;
            btnRoll.Focus();
        }

    }
}
