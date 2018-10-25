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
        public int roundCount;
        public string takeTurns;
        public string Player1;
        public string Player2;


        // constructor
        
       
        // member method
        public void RunGame()
        {

        }
        public void RoundCounter()
        {

        }

        public void GetPlayers()
        {

        }

        public void DeterminePlayers(int numberOfPlayers)
        {
            Player Player1;
            Player Player2;

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
        }
        public void GetGestures()
            {
            Player1.ChooseGesture;
            }
        }
    }
}
