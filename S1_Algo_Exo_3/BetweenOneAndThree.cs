using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    /**
     * The BetweenOneAndThree class contains a method that prompts the user to enter an integer between 1 and 3.
     * It continues to prompt the user until a valid input is provided, and then displays a congratulatory message.
     */
    internal class BetweenOneAndThree
    {
        public static void InputBetweenOneAndThree()
        {
            int x;

            Console.WriteLine("Taper un nombre entier : ");

            x = Convert.ToInt32(Console.ReadLine());

            while (x < 1 || x > 3)
            {
                Console.WriteLine("Taper un nombre entier : ");
                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Bravo");
        }
    }
}
