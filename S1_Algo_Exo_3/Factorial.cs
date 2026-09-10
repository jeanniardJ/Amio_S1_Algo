using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    internal class Factorial
    {
        public static void CalculateFactorial()
        {
            int number = 0;
            long factorial = 1;

            Console.WriteLine("Enter a number to calculate its factorial:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of " + number + " is: " + factorial);
        }
    }
}
