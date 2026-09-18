using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class FibonacciSequenceGenerator
    {
        public static void GenerateFibonacciSequence()
        {
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
            //Il ne faut que les 20 premières valeurs de la suite Fibonacci.
            int[] fibonacciNbrs = new int[20];

            for (int i = 0; i < fibonacciNbrs.Length; i++)
            {
                if (i < 1)
                {
                    fibonacciNbrs[i] = i;
                }
                else if (i < 2)
                {
                    fibonacciNbrs[i] = i;
                }
                else
                {
                    fibonacciNbrs[i] = fibonacciNbrs[i - 2] + fibonacciNbrs[i - 1];
                }
            }

            foreach (var item in fibonacciNbrs)
            {
                Console.WriteLine($"nombre : {item}");
            }
        }
    }
}
