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
            DiceInCup.Clear();
            DiceInCup.Add(new Dice(Color.Green));
            DiceInCup.Add(new Dice(Color.Green));
            DiceInCup.Add(new Dice(Color.Green));
            DiceInCup.Add(new Dice(Color.Green));
            DiceInCup.Add(new Dice(Color.Green));
            DiceInCup.Add(new Dice(Color.Green));
            DiceInCup.Add(new Dice(Color.Yellow));
            DiceInCup.Add(new Dice(Color.Yellow));
            DiceInCup.Add(new Dice(Color.Yellow));
            DiceInCup.Add(new Dice(Color.Yellow));
            DiceInCup.Add(new Dice(Color.Red));
            DiceInCup.Add(new Dice(Color.Red));
            DiceInCup.Add(new Dice(Color.Red));

            DiceInCup = DiceInCup.Shuffle();

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