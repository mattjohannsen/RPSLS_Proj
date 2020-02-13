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
        bool continueGame = true;

        // constructor


        // member methods
        public void RunGame()
        {
            ShowGameRules();
            string players = GetNumberOfPlayers();
            SetPlayers(players);
            do
            {
                player1.ChooseGesture();
                Console.WriteLine();
                Console.WriteLine($"Player 1 Chose: {player1.gesture.gestureName}");
                player2.ChooseGesture();
                Console.WriteLine($"Player 2 Chose: {player2.gesture.gestureName}");
                CompareGestures();
                CheckScore();
            }
            while (continueGame == true);

        }
        public void ShowGameRules()
        {
            Console.WriteLine("Welcome to the game: Rock, Paper, Scissors, Lizzard, Spock!");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("Rock crushes Scissors ");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine();
        }


        public void CheckScore()
        {
            if (player1.score >= 3)
            {
                continueGame = false;
                Console.WriteLine("");
                Console.WriteLine("Game Over! Player 1 wins!");
            }
            if (player2.score >= 3)
            {
                continueGame = false;
                Console.WriteLine("");
                Console.WriteLine("Game Over! Player 2 wins!");
            }
        }
        public void GestureStringCompare()
        {
            Console.WriteLine();
            //if ((player1.[0] == "rock") && (player2.gesture == "rock"))
            //{
            //    Console.WriteLine("Tie! Select Again!");
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}

        }
        public void CompareGestures()
        {
            bool contains = player2.gesture.losesTo.Contains(player1.gesture.gestureName);
            if (player1.gesture.gestureName == player2.gesture.gestureName)
            {
                Console.WriteLine("Tie");
            }
            else
            {
                if (contains)
                {
                    Console.WriteLine("Player 1 Wins");
                    player1.score++;

                }
                else
                {
                    Console.WriteLine("Player 2 Wins");
                    player2.score++;
                }
            }
            Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");

            //if ((player1.gesture.gestureName == "rock") && (player2.gesture.losesTo == "rock"))
            //{
            //    Console.WriteLine("Tie! Select Again!");
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "rock") && (player2.gesture == "paper"))
            //{
            //    Console.WriteLine("Paper covers Rock! Player 2 Wins!");
            //    player2.score ++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "rock") && (player2.gesture == "scissors"))
            //{
            //    Console.WriteLine("Rock crushes Scissors! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "rock") && (player2.gesture == "lizzard"))
            //{
            //    Console.WriteLine("Rock crushes Lizard! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "rock") && (player2.gesture == "spock"))
            //{
            //    Console.WriteLine("Spock vaporizes Rock! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "paper") && (player2.gesture == "rock"))
            //{
            //    Console.WriteLine("Paper covers Rock! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "paper") && (player2.gesture == "paper"))
            //{
            //    Console.WriteLine("Tie! Select Again!");
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "paper") && (player2.gesture == "scissors"))
            //{
            //    Console.WriteLine("Scissors cuts Paper! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "paper") && (player2.gesture == "lizzard"))
            //{
            //    Console.WriteLine("Lizard eats Paper! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "paper") && (player2.gesture == "spock"))
            //{
            //    Console.WriteLine("Paper disproves Spock! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "scissors") && (player2.gesture == "rock"))
            //{
            //    Console.WriteLine("Rock crushes Scissors! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "scissors") && (player2.gesture == "paper"))
            //{
            //    Console.WriteLine("Scissors cuts Paper! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "scissors") && (player2.gesture == "scissors"))
            //{
            //    Console.WriteLine("Tie! Select Again!");
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "scissors") && (player2.gesture == "lizzard"))
            //{
            //    Console.WriteLine("Scissors decapitates Lizard! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "scissors") && (player2.gesture == "spock"))
            //{
            //    Console.WriteLine("Spock smashes Scissors! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "lizzard") && (player2.gesture == "rock"))
            //{
            //    Console.WriteLine("Rock crushes Lizard! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "lizzard") && (player2.gesture == "paper"))
            //{
            //    Console.WriteLine("Lizard eats Paper! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "lizzard") && (player2.gesture == "scissors"))
            //{
            //    Console.WriteLine("Scissors decapitates Lizard! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "lizzard") && (player2.gesture == "lizzard"))
            //{
            //    Console.WriteLine("Tie! Select Again!");
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "lizzard") && (player2.gesture == "spock"))
            //{
            //    Console.WriteLine("Lizard poisons Spock! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "spock") && (player2.gesture == "rock"))
            //{
            //    Console.WriteLine("Spock vaporizes Rock! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "spock") && (player2.gesture == "paper"))
            //{
            //    Console.WriteLine("Paper disproves Spock! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "spock") && (player2.gesture == "scissors"))
            //{
            //    Console.WriteLine("Spock smashes Scissors! Player 1 Wins!");
            //    player1.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "spock") && (player2.gesture == "lizzard"))
            //{
            //    Console.WriteLine("Lizard poisons Spock! Player 2 Wins!");
            //    player2.score++;
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
            //if ((player1.gesture == "spock") && (player2.gesture == "spock"))
            //{
            //    Console.WriteLine("Tie! Select Again!");
            //    Console.WriteLine($"Score p1: {player1.score} p2: {player2.score}");
            //}
        }
        
        
        
        private string GetNumberOfPlayers()
        {
            bool isValidSelection = false;
            string numberPlayers;
            do
            {
                Console.WriteLine("Are you playing with 0, 1 or 2 players?");
                numberPlayers = Console.ReadLine();
                switch (numberPlayers)
                {
                    case "0":
                        isValidSelection = true;
                        break;
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
            else if (numberofPlayers == "0")
            {
                player1 = new AI();
                player2 = new AI();
            }

        }

        

    }
}
