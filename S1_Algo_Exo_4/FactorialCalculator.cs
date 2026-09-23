using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class FactorialCalculator
    {
        public static int CalculateFactorial(int number)
        {
            int calcul = 1;

            for(int i = 2; i <= number; i++)
            {
                calcul *= i;
                Console.WriteLine(calcul);
            }

            return calcul;
        }
    }
}
