using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    /**
     * This class is used to calculate the sum of all integers from 1 to n.
     * It takes a positive integer n as input from the user and calculates the sum of all integers from 1 to n.
     */
    internal class IntegerSumCalculator
    {
        public static void calculateSum()
        {
            int n = 0, sum = 0;

            Console.WriteLine("Enter a positive integer: ");

            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; ++i)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
