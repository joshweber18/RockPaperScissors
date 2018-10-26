using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Rock crushes Scissors
// Scissors cuts Paper
// Paper covers Rock
// Rock crushes Lizard
// Lizard poisons Spock
// Spock smashes Scissors
// Scissors decapitates Lizard
// Lizard eats Paper
// Paper disproves Spock
// Spock vaporizes Rock
 

namespace RPSLS
{
    class Game
    {
        // member variables
        public int roundCount;
        public string takeTurns;
        Player Player1;
        Player Player2;
        public int amountOfPlayers;
        public int ScorePlayer1;
        public int ScorePlayer2;


        // constructor
        
       
        // member method
        public void RunGame()
        {
            while(ScorePlayer1 <3 ||ScorePlayer2 < 3)
            {
                Player1.ChooseGesture();
                Player2.ChooseGesture();
                Rules(Player1, Player2);
            }
            
        }

        public void Rules(Player player1, Player player2) // What gesture beats what.
        {
            
                if (Player1.gesture == Player1.gestureOptions[0] && Player2.gesture == Player2.gestureOptions[2])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Rock crushes Scissors");
                }

                if (Player1.gesture == Player1.gestureOptions[2] && Player2.gesture == Player2.gestureOptions[1])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Scissors cuts Paper");
                }

                if (Player1.gesture == Player1.gestureOptions[1] && Player2.gesture == Player2.gestureOptions[0])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Paper covers Rock");
                }

                if (Player1.gesture == Player1.gestureOptions[0] && Player2.gesture == Player2.gestureOptions[3])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Rock crushes Lizard");
                }

                if (Player1.gesture == Player1.gestureOptions[3] && Player2.gesture == Player2.gestureOptions[4])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Lizard poisons Spock");
                }

                if (Player1.gesture == Player1.gestureOptions[4] && Player2.gesture == Player2.gestureOptions[2])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Spock smashes Scissors");
                }

                if (Player1.gesture == Player1.gestureOptions[2] && Player2.gesture == Player2.gestureOptions[3])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Scissors decapitates Lizard");
                }

                if (Player1.gesture == Player1.gestureOptions[3] && Player2.gesture == Player2.gestureOptions[1])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Lizard eats Paper");
                }

                if (Player1.gesture == Player1.gestureOptions[1] && Player2.gesture == Player2.gestureOptions[4])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Paper disproves Spock");
                }

                if (Player1.gesture == Player1.gestureOptions[4] && Player2.gesture == Player2.gestureOptions[0])
                {
                    ScorePlayer1++;
                    Console.WriteLine("Player 1 wins! Spock vaporizes Rock");
                }

                // start of player 2 if statements

                if (Player2.gesture == Player2.gestureOptions[0] && Player1.gesture == Player1.gestureOptions[2])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Rock crushes Scissors");
                }

                if (Player2.gesture == Player2.gestureOptions[2] && Player1.gesture == Player1.gestureOptions[1])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Scissors cuts Paper");
                }

                if (Player2.gesture == Player2.gestureOptions[1] && Player1.gesture == Player1.gestureOptions[0])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Paper covers Rock");
                }

                if (Player2.gesture == Player2.gestureOptions[0] && Player1.gesture == Player1.gestureOptions[3])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Rock crushes Lizard");
                }

                if (Player2.gesture == Player2.gestureOptions[3] && Player1.gesture == Player1.gestureOptions[4])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Lizard poisons Spock");
                }

                if (Player2.gesture == Player2.gestureOptions[4] && Player1.gesture == Player1.gestureOptions[2])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Spock smashes Scissors");
                }

                if (Player2.gesture == Player2.gestureOptions[2] && Player1.gesture == Player1.gestureOptions[3])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Scissors decapitates Lizard");
                }

                if (Player2.gesture == Player2.gestureOptions[3] && Player1.gesture == Player1.gestureOptions[1])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Lizard eats Paper");
                }

                if (Player2.gesture == Player2.gestureOptions[1] && Player1.gesture == Player1.gestureOptions[4])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Paper disproves Spock");
                }

                if (Player2.gesture == Player2.gestureOptions[4] && Player1.gesture == Player1.gestureOptions[0])
                {
                    ScorePlayer2++;
                    Console.WriteLine("Player 2 wins! Spock vaporizes Rock");
                }

            // ties for Player1

                if (Player1.gesture == Player1.gestureOptions[0] && Player2.gesture == Player2.gestureOptions[0])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player1.gesture == Player1.gestureOptions[1] && Player2.gesture == Player2.gestureOptions[1])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player1.gesture == Player1.gestureOptions[2] && Player2.gesture == Player2.gestureOptions[2])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player1.gesture == Player1.gestureOptions[3] && Player2.gesture == Player2.gestureOptions[3])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player1.gesture == Player1.gestureOptions[4] && Player2.gesture == Player2.gestureOptions[4])
                {
                    Console.WriteLine("Meh, tie.");
                }


            
            // ties for Player2

                if (Player2.gesture == Player2.gestureOptions[0] && Player1.gesture == Player1.gestureOptions[0])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player2.gesture == Player2.gestureOptions[1] && Player1.gesture == Player1.gestureOptions[1])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player2.gesture == Player2.gestureOptions[2] && Player1.gesture == Player1.gestureOptions[2])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player2.gesture == Player2.gestureOptions[3] && Player1.gesture == Player1.gestureOptions[3])
                {
                    Console.WriteLine("Meh, tie.");
                }

                if (Player2.gesture == Player2.gestureOptions[4] && Player1.gesture == Player1.gestureOptions[4])
                {
                    Console.WriteLine("Meh, tie.");
                }

                








        }

        public void Scoreboard() // Tracks score for each player.
        {

        }

        public void RoundCounter() // Changes round after each turn.
        {

        }

        public void GetPlayers()
        {
            Console.WriteLine("Please enter the amount of players.");
            amountOfPlayers = int.Parse(Console.ReadLine());
            DeterminePlayers(amountOfPlayers);
        }

        public void DeterminePlayers(int numberOfPlayers) // Human vs. Human || Human vs. Computer
        {

            if (numberOfPlayers == 1)
            {
                Player1 = new HumanPlayer();
                Player2 = new ComputerPlayer();
            }
            else if (numberOfPlayers == 2)
            {
                Player1 = new HumanPlayer();
                Player2 = new HumanPlayer();
            }
            else if (numberOfPlayers == 0)
            {
                Player1 = new ComputerPlayer();
                Player2 = new ComputerPlayer();
            }
        }

        public void GetGestures()
            {
                Player1.ChooseGesture();
                Player2.ChooseGesture();
            }
        
    }
}
