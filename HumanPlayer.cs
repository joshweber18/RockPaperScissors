using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player // inheritance (IS A TYPE OF)
    {
        // member variables (HAS A)

       


        // member methods (DOES IT)
        public override void ChooseGesture()
        {
            Console.WriteLine("Press 1 for " + gestureOptions[0]);
            Console.WriteLine("Press 2 for " + gestureOptions[1]);
            Console.WriteLine("Press 3 for " + gestureOptions[2]);
            Console.WriteLine("Press 4 for " + gestureOptions[3]);
            Console.WriteLine("Press 5 for " + gestureOptions[4]);
            switch (Console.ReadLine())
            {
                case "1":
                    gesture = gestureOptions[0];
                    break;
                case "2":
                    gesture = gestureOptions[1];
                    break;
                case "3":
                    gesture = gestureOptions[2];
                    break;
                case "4":
                    gesture = gestureOptions[3];
                    break;
                case "5":
                    gesture = gestureOptions[4];
                    break;
                case "":
                    Console.WriteLine("you entered a nothing");
                    ChooseGesture();
                    break;
                default:
                    Console.WriteLine("you dummy");
                    ChooseGesture();
                    break;

            }
        }
    }

    
}
