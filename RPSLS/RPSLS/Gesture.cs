using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Gesture
    {
        //member methods
        string gestureName;
        public List<Outcome> outcomes;

        // constructor
        public Gesture()
        {
        Outcome rock = new Outcome("tie", "lose", "win", "win", "lose");
        Outcome paper = new Outcome("win", "tie", "lose", "lose", "win");
        Outcome scissors = new Outcome("lose", "win", "tie", "win", "lose");
        Outcome lizzard = new Outcome("lose", "win", "lose", "tie", "win");
        Outcome spock = new Outcome("win", "lose", "win", "lose", "tie");

        outcomes = new List<Outcome>() { rock, paper, scissors, lizzard, spock };
        Console.WriteLine($"{outcomes}");
    }

        // member variables


    }
}
