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
        public List<string> gestureOptions = new List<string>();

        public Player()
        {
            gestureOptions.Add("Rock");
            gestureOptions.Add("Paper");
            gestureOptions.Add("Scissors");
            gestureOptions.Add("Lizard");
            gestureOptions.Add("Spock");
        }




        /// constructor

        /// member methods(DOES IT)
        public abstract void ChooseGesture();
    }
}
