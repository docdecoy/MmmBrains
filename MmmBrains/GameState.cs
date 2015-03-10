using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmBrains
{
    public class GameState
    {
        public DiceCup DiceCup { get; private set; }
        public List<DiceFaceImage> RolledShotguns { get; private set; }
        public List<DiceFaceImage> RolledBrains { get; private set; }
        public List<DiceFaceImage> RolledFeet { get; private set; }

        public void NewGame()
        {
            DiceCup = new DiceCup();
            RolledShotguns = new List<DiceFaceImage>();
            RolledBrains = new List<DiceFaceImage>();
            RolledFeet = new List<DiceFaceImage>();            
        }
                // Roll my dice (TODO: do something with this?)
            //foreach (var dice in diceInHand)
            //{
            //    var diceRollResult = dice.Roll();
            //    switch (diceRollResult)
            //    {
            //        case DiceFaceImage.GreenBrain:
            //        case DiceFaceImage.YellowBrain:
            //        case DiceFaceImage.RedBrain:
            //            _rolledBrains.Add(diceRollResult);
            //            break;
            //        case DiceFaceImage.GreenFeet:
            //        case DiceFaceImage.YellowFeet:
            //        case DiceFaceImage.RedFeet:
            //            _rolledFeet.Add(diceRollResult);
            //            break;
            //        case DiceFaceImage.GreenShotgun:
            //        case DiceFaceImage.YellowShotgun:
            //        case DiceFaceImage.RedShotgun:
            //            _rolledShotguns.Add(diceRollResult);
            //            break;
            //        default:
            //            throw new ArgumentOutOfRangeException();
            //    }
            //}

    }
}
