using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmBrains
{
    public class Dice
    {
        public Color Color { get; private set; }

        public Dice(Color diceImageColor)
        {
            Color = diceImageColor;
        }

        public DiceFaceImage Roll()
        {
            int diceResult = Global.NumberGenerator.Next(1, 7);

            if (Color == Color.Green)
            {
                switch (diceResult)
                {
                    case 1:
                    case 2:
                    case 6:
                        //return DiceFaceImage.Brain;
                        return DiceFaceImage.GreenBrain;
                    case 3:
                    case 4:
                        //return DiceFaceImage.Feet;
                        return DiceFaceImage.GreenFeet;
                    case 5:
                        //return DiceFaceImage.Shotgun;
                        return DiceFaceImage.GreenShotgun;
                }
            }
            else if (Color == Color.Yellow)
            {
                switch (diceResult)
                {
                    case 1:
                    case 6:
                        //return DiceFaceImage.Brain;
                        return DiceFaceImage.YellowBrain;
                    case 3:
                    case 4:
                        //return DiceFaceImage.Feet;
                        return DiceFaceImage.YellowFeet;
                    case 2:
                    case 5:
                        //return DiceFaceImage.Shotgun;
                        return DiceFaceImage.YellowShotgun;
                }
            }
            else if (Color == Color.Red)
            {
                switch (diceResult)
                {
                    case 1:
                        //return DiceFaceImage.Brain;
                        return DiceFaceImage.RedBrain;
                    case 3:
                    case 4:
                        //return DiceFaceImage.Feet;
                        return DiceFaceImage.RedFeet;
                    case 2:
                    case 5:
                    case 6:
                        //return DiceFaceImage.Shotgun;
                        return DiceFaceImage.RedShotgun;
                }
            }
            throw new InvalidOperationException();
        }
    }
}
