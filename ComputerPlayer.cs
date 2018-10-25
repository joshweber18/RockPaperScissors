using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {
        public override void ChooseGesture()
        {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(gestureOptions.Count);
            
        }
    }
}
