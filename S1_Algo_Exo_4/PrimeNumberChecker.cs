using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class PrimeNumberChecker
    {
        public static bool IsPrimeNumber(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{number / i}");
                Console.WriteLine($"{number % 2 == 0}, {number % 2}");
            }

            return true;
        }
    }
}