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
        public Gesture gesture;
        //OLD working simple list below
        //public List<string> gestures = new List<string>();
        //OLD working simple list above
        //New variables from Gesture class below
        //public string gestureName;
        public List<Gesture> gestures;
        //New variables from Gesture class above

        //constructor
        public Player()
        {

            Gesture rock = new Gesture("rock", new List<string> { "paper", "spock" });
            Gesture paper = new Gesture("paper", new List<string> { "scissors", "lizzard" });
            Gesture scissors = new Gesture("scissors", new List<string> { "rock", "spock" });
            Gesture lizzard = new Gesture("lizzard", new List<string> { "rock", "scissors" });
            Gesture spock = new Gesture("spock", new List<string> { "paper", "lizzard" });

            gestures = new List<Gesture>() { rock, paper, scissors, lizzard, spock };
            //OLD working simple list below
            //gestures.Add("rock");
            //gestures.Add("paper");
            //gestures.Add("scissors");
            //gestures.Add("lizzard");
            //gestures.Add("spock");
            //OLD working simple list above
        }


        //member methods
        public abstract void ChooseGesture();




    }
}
