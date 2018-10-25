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

            gesture = Console.ReadLine();
        }
    }

    
}
