using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables
        public string name;


        //member constructor




        //member methods
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose Gesture:");
            gesture = Console.ReadLine();
        }




    }
}
