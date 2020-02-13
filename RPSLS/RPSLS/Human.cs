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
        //public string name;



        //member constructor




        //member methods
        public override void ChooseGesture()
        {
            bool validPlayerChoice = false;
            string playerSelection;

            Console.WriteLine();
            Console.WriteLine("Select Gesture:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"({i}) for {gestures[i].gestureName}");
            }
            do
            {
                playerSelection = Console.ReadLine();
                switch (playerSelection)
                {
                case "0":
                    //gesture = gestures[0];
                    gesture = gestures[0];
                    validPlayerChoice = true;
                    break;
                case "1":
                    gesture = gestures[1];
                        validPlayerChoice = true;
                    break;
                case "2":
                     gesture = gestures[2];
                        validPlayerChoice = true;
                    break;
                case "3":
                     gesture = gestures[3];
                        validPlayerChoice = true;
                    break;
                case "4":
                     gesture = gestures[4];
                        validPlayerChoice = true;
                    break;
                default:
                    Console.WriteLine("That is not a valid selection. Please try again.");
                    validPlayerChoice = false;
                    break;
                }
            }
            while (validPlayerChoice == false);
        }
    }
}
