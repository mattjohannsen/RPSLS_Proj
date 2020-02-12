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
            Console.WriteLine("This is where computers choose gesture.");
            int result;
            Random rnd = new Random();
            result = rnd.Next(1, 5);
            if (result == 1)
            {
                gesture = "rock";
            }
            if (result == 2)
            {
                gesture = "paper";
            }
            if (result == 3)
            {
                gesture = "scissors";
            }
            if (result == 4)
            {
                gesture = "lizzard";
            }
            if (result == 5)
            {
                gesture = "spock";
            }


        }


    }
}
