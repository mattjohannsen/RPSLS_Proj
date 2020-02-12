using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables
        public Player player1;
        public Player player2;

        // This is where the List<string> gestures will go




        // constructor






        // member methods
        public void RunGame()
        {
            //This is where the method will go to show the instructions
            Console.WriteLine("Rock Paper Scissors Lizzard Spock");
            string players = GetNumberOfPlayers();
            SetPlayers(players);

            //string numberPlayers = GetNumberOfPlayers();


        }

        private string GetNumberOfPlayers()
        {
            bool isValidSelection = false;
            string numberPlayers;
            do
            {
                Console.WriteLine("Are you playing with 1 or 2 players?");
                numberPlayers = Console.ReadLine();
                switch (numberPlayers)
                {
                    case "1":
                        isValidSelection = true;
                        break;
                    case "2":
                        isValidSelection = true;
                        break;
                    default:
                        isValidSelection = false;
                        Console.WriteLine("That is not a valid selection. Please try again.");
                        break;
                }
            }
            while (isValidSelection == false);
            return numberPlayers;

        }

        private void SetPlayers(string numberofPlayers)
        {
            if (numberofPlayers == "1")
            {
                player1 = new Human();
                player2 = new AI();

            }
            else if (numberofPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }

        }

    }
}
