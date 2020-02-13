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

        //constructor
        public Gesture(string gestureName, List<string> losesTo)
        {
            this.gestureName = gestureName;
            this.losesTo = losesTo;

        }

        //member methods

    }
}
