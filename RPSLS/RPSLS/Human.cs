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
            bool validPlayerChoice = false;
            string playerSelection;
            //List<Gesture> gestures = new List<Gesture>();
            //Gesture rock = new Gesture("rock");
            //Gesture paper = new Gesture("paper");
            //Gesture scissors = new Gesture("scissors");
            //Gesture lizzard = new Gesture("lizzard");
            //Gesture spock = new Gesture("spock");
            //gestures = new List<Gesture>() { rock, paper, scissors, lizzard, spock };
            List<string> gestures = new List<string>();
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizzard");
            gestures.Add("spock");
            Console.WriteLine();
            Console.WriteLine("Select Gesture:");
            //Console.WriteLine($"{gestures.Count}");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"({i}) for {gestures[i]}");
            }

            {
                playerSelection = Console.ReadLine();
                switch (playerSelection)
                {
                case "0":
                    gesture = "rock";
                    validPlayerChoice = true;
                    break;
                case "1":
                    gesture = "paper";
                    validPlayerChoice = true;
                    break;
                case "2":
                     gesture = "scissors";
                    validPlayerChoice = true;
                    break;
                case "3":
                     gesture = "lizzard";
                    validPlayerChoice = true;
                    break;
                case "4":
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
        }
    }
}
