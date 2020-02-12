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
            //Console.WriteLine("This is the place where humans select gesture.");
            bool validPlayerChoice = false;
            string playerSelection;
            do
            {
                Console.WriteLine("Select Gesture:");
                Console.WriteLine("(1) for Rock");
                Console.WriteLine("(2) for Paper");
                Console.WriteLine("(3) for Scissors");
                Console.WriteLine("(4) for Lizzard");
                Console.WriteLine("(5) for Spock");
                playerSelection = Console.ReadLine();
                switch (playerSelection)
                {
                case "1":
                    gesture = "rock";
                    validPlayerChoice = true;
                    break;
                case "2":
                    gesture = "paper";
                    validPlayerChoice = true;
                    break;
                case "3":
                     gesture = "scissors";
                    validPlayerChoice = true;
                    break;
                case "4":
                     gesture = "lizzard";
                    validPlayerChoice = true;
                    break;
                case "5":
                     gesture = "spock";
                    validPlayerChoice = true;
                    break;
                default:
                    Console.WriteLine("That is not a valid selection. Please try again.");
                    validPlayerChoice = false;
                    break;
                }

            }
            while (validPlayerChoice == false);
            //Console.WriteLine("Choose Gesture:");
            //gesture = Console.ReadLine();
        }




    }
}
