using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public string name;
        public int score;
        public string gesture;
        public List<string> gestures = new List<string>();

        //constructor
        public Player()
        {
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizzard");
            gestures.Add("spock");
        }


        //member methods
        public abstract void ChooseGesture();




    }
}
