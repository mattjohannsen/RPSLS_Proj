using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Gesture
    {
        //member variables

        public List<string> losesTo;
        public string gestureName;
        //EXAMPLE of a simple list:
        //List<Dog> dogs = new List<Dog>();
        //EXAMPLE of

        //var animals = new List<string>() { "bird", "dog" };
        //var losesTo = new List<string>() { string, string };
        //public List<string> losesTo = new List<string>();
        //gestures = new List<Gesture>( rock, { Gesture paper, spock }), (scissors, { rock, spock }), (scissors, { rock, spock }), (lizzard, { rock, scissors }), (spock, { paper, lizzard }));


        // rock (paper, spock), paper (scissors, lizzard), scissors (rock, spock), lizzard (rock, scissors), spock (paper, lizzard)

        //constructor
        public Gesture(string gestureName, List<string> losesTo)
        {
            //this.gestureName = gestureName;
            this.gestureName = gestureName;
            this.losesTo = losesTo;

        }

        //member methods

    }
}
