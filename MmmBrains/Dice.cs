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
        private Random _numberGenerator = new Random();

        public Color Color { get; set; }

        public Dice(Color color)
        {
            Color = color;
        }

        public string Roll()
        {
            int result = _numberGenerator.Next(1, 6);

            if (Color == Color.Red)
            {
                if (result == 1)
                {
                    return "B";
                }
                else if (result == 2)
                {
                    return "S";
                }
                else if (result == 3)
                {
                    return "F";
                }
                else if (result == 4)
                {
                    return "F";
                }
                else if (result == 5)
                {
                    return "S";
                }
                else if (result == 6)
                {
                    return "S";
                }
            }
            else if (Color == Color.Yellow)
            {
                if (result == 1 || result == 6)
                {
                    return "B";
                }
                else if (result == 2 || result == 5)
                {
                    return "S";
                }
                else if (result == 3 || result == 4)
                {
                    return "F";
                }
            }
            else if (Color == Color.Green)
            {
                switch (result)
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
                throw new InvalidOperationException();
        }
    }
}
