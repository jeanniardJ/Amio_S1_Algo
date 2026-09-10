using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    internal class MultipleSumsCalculator
    {
        public static void calculateSum()
        {
            bool isContinued = false;

            do
            {
                int n = 0, sum = 0;

                Console.WriteLine("Enter a positive integer: ");

                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; ++i)
                {
                    sum += i;
                }

                Console.WriteLine("Sum = " + sum);

                Console.WriteLine("Voulez-vous continuer ? (O/N) :");
                isContinued = Console.ReadKey().KeyChar.ToString().ToUpper() == "O" ? false : true;
                Console.WriteLine("\n");
            }
            while (!isContinued);
        }
    }
}
