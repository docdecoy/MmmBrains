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
            Color = DiceFaceColor();
        }

        public Color DiceFaceColor()
        {
            Color[] strDicePool = new Color[] { Color.Green, Color.Green, Color.Green, Color.Green, Color.Green, Color.Green, Color.Yellow, Color.Yellow, Color.Yellow, Color.Yellow, Color.Red, Color.Red, Color.Red };
            Random pickDice = new Random();
            int index = pickDice.Next(0, 13);
            Color value = strDicePool[index];
            return value;
        }

        //private static Color PickDiceColor()
        //{
        //    int diceColor = NumberGenerator.Next(1, 4);

        //    switch (diceColor)
        //    {
        //        case 1:
        //            return Color.Red;
        //        case 2:
        //            return Color.Yellow;
        //        case 3:
        //            return Color.Green;
        //    }
        //    throw new InvalidOperationException();
        //}
        
        public DiceFaceImage Roll()
        {
            int diceResult = NumberGenerator.Next(1, 7);

            if (Color == Color.Green)
            {
                switch (diceResult)
                {
                    case 1:
                    case 2:
                    case 6:
                        return DiceFaceImage.Brain;
                    case 3:
                    case 4:
                        return DiceFaceImage.Feet;
                    case 5:
                        return DiceFaceImage.Shotgun;
                }
            }
            else if (Color == Color.Yellow)
            {
                switch (diceResult)
                {
                    case 1:
                    case 6:
                        return DiceFaceImage.Brain;
                    case 3:
                    case 4:
                        return DiceFaceImage.Feet;
                    case 2:
                    case 5:
                        return DiceFaceImage.Shotgun;
                }
            }
            else if (Color == Color.Red)
            {
                switch (diceResult)
                {
                    case 1:
                        return DiceFaceImage.Brain;
                    case 3:
                    case 4:
                        return DiceFaceImage.Feet;
                    case 2:
                    case 5:
                    case 6:
                        return DiceFaceImage.Shotgun;
                }
            }
            throw new InvalidOperationException();
        }
    }
}
