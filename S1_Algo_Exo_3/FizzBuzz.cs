using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    /**
     * FizzBuzz is a classic programming exercise that prints numbers from 0 to 100.
     * For multiples of 3, it prints "Fizz" instead of the number.
     * For multiples of 5, it prints "Buzz" instead of the number.
     * For numbers that are multiples of both 3 and 5, it prints "FizzBuzz".
     */
    internal class FizzBuzz
    {
        public static void RunFizzBuzz()
        {
            Console.WriteLine("FizzBuzz from 0 to 100:");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}