using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        bool vsComputer;
        Gesture theGestures;


        //constructor
        public Game()
        {
            
        }


        //methods

        public void StartGame()
        {

            Console.WriteLine("RPSLS Game");
            SelectPlayers();
            Console.ReadLine();
        }
        public void SelectPlayers()
        {
            bool validPlayerChoice = false;
            while (validPlayerChoice == false)
            {

            string varPlayerSelection;
            Console.WriteLine("Enter 0 if playing against computer:");
            Console.WriteLine("Enter 1 if playing against another player:");
            varPlayerSelection = Console.ReadLine();
            switch (varPlayerSelection)
            {
                case "1":
                    vsComputer = false;
                        validPlayerChoice = true;
                    break;
                case "0":
                    vsComputer = true;
                        validPlayerChoice = true;
                    break;
                default:
                    Console.WriteLine("That is not a valid selection. Please try again.");
                    break;
            }
            Console.WriteLine($"{vsComputer}");
            }
        }




    }
}
