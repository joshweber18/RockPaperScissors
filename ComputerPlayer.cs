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

            switch (randomNumber)
            {
                case 1:
                    gesture = gestureOptions[0];
                    Console.WriteLine("Rock");
                    break;
                case 2:
                    gesture = gestureOptions[1];
                    Console.WriteLine("Paper");
                    break;
                case 3:
                    gesture = gestureOptions[2];
                    Console.WriteLine("Scissors");
                    break;
                case 4:
                    gesture = gestureOptions[3];
                    Console.WriteLine("Lizard");
                    break;
                case 5:
                    gesture = gestureOptions[4];
                    Console.WriteLine("Spock");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number.");
                    break;
            }

        }
    }
}
