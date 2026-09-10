using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    internal class IntegerSumCalculator
    {
        public static void calculateSum()
        {
            int n = 5, sum = 0;

            for(int i = 0; i < n; ++i)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
