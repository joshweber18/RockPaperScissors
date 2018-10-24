using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        /// member variables(HAS A)
        public string gesture;
        public List<string> gestures = new List<string>();

        public Player()
        {
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }




        /// constructor

        /// member methods(DOES IT)
        public void ChooseGesture()
        {
            Console.WriteLine("Press 1 for " + gestures[0]);
            gesture = "Rock";
            Console.WriteLine("Press 2 for " + gestures[1]);
            gesture = "Paper";
            Console.WriteLine("Press 3 for " + gestures[2]);
            gesture = "Scissors";
            Console.WriteLine("Press 4 for " + gestures[3]);
            gesture = "Lizard";
            Console.WriteLine("Press 5 for " + gestures[4]);
            gesture = "Spock";
        }
    }
}
