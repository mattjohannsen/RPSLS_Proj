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
        Player player1;
        Player player2;
        // This is where the List<string> gestures will go




        // constructor






        // member methods
        public void RunGame()
        {
            //This is where the method will go to show the instructions
            Console.WriteLine("Rock Paper Scissors Lizzard Spock");

        }

        private string GetNumberOfPlayers()
        {
            Console.WriteLine("Are you playing with 1 or 2 players?");
            string numberPlayers = Console.ReadLine();
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
