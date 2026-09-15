using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class FactorialCalculator
    {
        public static void CalculateFactorial(int number)
        {
            int calcul = 1;

            for(int i = 1; i <= number; i++)
            {
                calcul *= i;
                Console.WriteLine(calcul);
            }

            Console.WriteLine(calcul);
        }
    }
}
