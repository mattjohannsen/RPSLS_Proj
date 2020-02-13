using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        // member variables



        // constructor



        // member methods
        public override void ChooseGesture()
        {
            int result;
            Random rnd = new Random();
            result = rnd.Next(0, gestures.Count);
            for (int i = 0; i < gestures.Count; i++)
            {
                if (result == i)
                {
                    gesture = new Gesture(gestures[i].gestureName, gestures[i].losesTo);
                }
            }
        }


    }
}
