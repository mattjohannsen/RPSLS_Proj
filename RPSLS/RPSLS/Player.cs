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
        public List<Gesture> gestures;

        //constructor
        public Player()
        {
            Gesture rock = new Gesture("rock", new List<string> { "paper", "spock" });
            Gesture paper = new Gesture("paper", new List<string> { "scissors", "lizzard" });
            Gesture scissors = new Gesture("scissors", new List<string> { "rock", "spock" });
            Gesture lizzard = new Gesture("lizzard", new List<string> { "rock", "scissors" });
            Gesture spock = new Gesture("spock", new List<string> { "paper", "lizzard" });

            gestures = new List<Gesture>() { rock, paper, scissors, lizzard, spock };
        }

        //member methods
        public abstract void ChooseGesture();

    }
}
