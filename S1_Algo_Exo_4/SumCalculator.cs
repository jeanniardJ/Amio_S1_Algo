using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class SumCalculator
    {
        public static void ReadTwoIntegers()
        {
            int nbrA, nbrB, nbrC;

            Console.WriteLine("Entree un premiere nombre entier :");
            
            nbrA = int.Parse(Console.ReadLine());

            Console.WriteLine("Entree un second nombre entier : ");

            nbrB = int.Parse(Console.ReadLine());

            nbrC = CalculateSum(nbrA, nbrB);

            Console.WriteLine($"La somme des deux nombres est {nbrC}");

        }
        public static int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}
