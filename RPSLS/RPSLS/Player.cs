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


        //constructor
        public Player()
        {

        }


        //member methods
        public abstract void ChooseGesture();




    }
}
