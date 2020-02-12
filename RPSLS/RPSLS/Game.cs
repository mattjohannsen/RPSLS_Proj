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
            player1.ChooseGesture();
            Console.WriteLine($"Player 1 Chose: {player1.gesture}");
            player2.ChooseGesture();
            Console.WriteLine($"Player 2 Chose: {player2.gesture}");
            CompareGestures();
            //Console.WriteLine($"p2: {player2.gesture}");
            //string numberPlayers = GetNumberOfPlayers();


        }
        public void CompareGestures()
        {
            Console.WriteLine("Comparing gesture selections...");
            Console.WriteLine($"{player1.gesture} vs. {player2.gesture}");
            if ((player1.gesture == "rock") && (player2.gesture == "rock"))
            {
                Console.WriteLine("Tie! Select Again!");
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "rock") && (player2.gesture == "paper"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score ++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "rock") && (player2.gesture == "scissors"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "rock") && (player2.gesture == "lizzard"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "rock") && (player2.gesture == "spock"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "paper") && (player2.gesture == "rock"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "paper") && (player2.gesture == "paper"))
            {
                Console.WriteLine("Tie! Select Again!");
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "paper") && (player2.gesture == "scissors"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "paper") && (player2.gesture == "lizzard"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "paper") && (player1.gesture == "spock"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "scissors") && (player2.gesture == "rock"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "scissors") && (player2.gesture == "paper"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "scissors") && (player2.gesture == "scissors"))
            {
                Console.WriteLine("Tie! Select Again!");
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "scissors") && (player2.gesture == "lizzard"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "scissors") && (player2.gesture == "spock"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "lizzard") && (player2.gesture == "rock"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "lizzard") && (player2.gesture == "paper"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "lizzard") && (player2.gesture == "scissors"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "lizzard") && (player2.gesture == "lizzard"))
            {
                Console.WriteLine("Tie! Select Again!");
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "lizzard") && (player2.gesture == "spock"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "spock") && (player2.gesture == "rock"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "spock") && (player2.gesture == "paper"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "spock") && (player2.gesture == "scissors"))
            {
                Console.WriteLine("Player 1 Wins!");
                player1.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "spock") && (player2.gesture == "lizzard"))
            {
                Console.WriteLine("Player 2 Wins!");
                player2.score++;
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
            if ((player1.gesture == "spock") && (player1.gesture == "spock"))
            {
                Console.WriteLine("Tie! Select Again!");
                Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            }
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
