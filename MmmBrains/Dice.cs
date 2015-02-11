﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmBrains
{
    public class Dice
    {
        private static readonly Random NumberGenerator = new Random();

        public Color Color { get; private set; }

        public Dice()
        {
            Color = PickDiceColor();
        }

        private static Color PickDiceColor()
        {
            int diceColor = NumberGenerator.Next(1, 4);

            switch (diceColor)
            {
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Yellow;
                case 3:
                    return Color.Green;
            }
            throw new InvalidOperationException();
        }
        
        public string Roll()
        {
            int diceResult = NumberGenerator.Next(1, 7);

            if (Color == Color.Green)
            {
                switch (diceResult)
                {
                    case 1:
                    case 2:
                    case 6:
                        return "B";
                    case 3:
                    case 4:
                        return "F";
                    case 5:
                        return "S";
                }
            }
            else if (Color == Color.Yellow)
            {
                switch (diceResult)
                {
                    case 1:
                    case 6:
                        return "B";
                    case 3:
                    case 4:
                        return "F";
                    case 2:
                    case 5:
                        return "S";
                }
            }
            else if (Color == Color.Red)
            {
                switch (diceResult)
                {
                    case 1:
                        return "B";
                    case 3:
                    case 4:
                        return "F";
                    case 2:
                    case 5:
                    case 6:
                        return "S";
                }
            }
            throw new InvalidOperationException();
        }
    }
}
