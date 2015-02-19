using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmBrains
{
    public class DiceCup
    {

        public List<Dice> DiceInCup { get; private set; }

        public DiceCup()
        {
            DiceInCup = new List<Dice>();
            Reset();
        }

        public void Reset()
        {
            int totalGreenDice = 0;
            int totalYellowDice = 0;
            int totalRedDice = 0;

            DiceInCup.Clear();

            do
            {
                int getDice = Global.NumberGenerator.Next(1, 4);

                switch (getDice)
                {
                    case 1:
                        if (totalGreenDice < 6)
                        {
                            DiceInCup.Add(new Dice(Color.Green));
                            totalGreenDice++;
                        }
                        break;
                    case 2:
                        if (totalYellowDice < 4)
                        {
                            DiceInCup.Add(new Dice(Color.Yellow));
                            totalYellowDice++;
                        }
                        break;
                    case 3:
                        if (totalRedDice < 3)
                        {
                            DiceInCup.Add(new Dice(Color.Red));
                            totalRedDice++;
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

            } while (DiceInCup.Count < 13);
        }

        public List<Dice> TakeDice(int numberToGrab)
        {
            List<Dice> grabbedDice = new List<Dice>();

            for (int numberLeftToGrab = numberToGrab; numberLeftToGrab > 0 && DiceInCup.Count > 0; numberLeftToGrab--)
            {
                int index = Global.NumberGenerator.Next(0, DiceInCup.Count);
                grabbedDice.Add(DiceInCup[index]);
                DiceInCup.RemoveAt(index);
            }
            return grabbedDice;
        }
    }
}