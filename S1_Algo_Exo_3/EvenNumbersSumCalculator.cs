using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    /**
     * 
     */
    internal class EvenNumbersSumCalculator
    {
        public static void CalculateSumOfFirstNEvenNumbers()
        {
            int sum = 0, n = 0;

            Console.WriteLine("Entre un nombre entier");

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    Console.WriteLine(sum);
                }
            }

            Console.WriteLine($"Sum : {sum}");
        }
    }
}
