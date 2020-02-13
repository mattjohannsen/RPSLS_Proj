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
            result = rnd.Next(0, 5);

            if (result == 0)
            {
                gesture = "rock";
            }
            if (result == 1)
            {
                gesture = "paper";
            }
            if (result == 2)
            {
                gesture = "scissors";
            }
            if (result == 3)
            {
                gesture = "lizzard";
            }
            if (result == 4)
            {
                gesture = "spock";
            }


        }


    }
}
