using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class SchtroumpfCalculator
    {
        public static void CalculateSchtroumpf() {
            int[] tableA = { 4, 8, 7, 12 };
            int[] tableB = { 3, 6 };
            int somme = 0;

            for (int i = 0; i < tableA.Length; i++)
            {
                for (int y = 0;  y < tableB.Length; y++)
                {
                    somme += tableA[i] * tableB[y];
                    Console.WriteLine($"Calcul de la multiplication est {somme} = {tableA[i]} * {tableB[y]} donc le resultat est {tableA[i] * tableB[y]}");
                }
            }
            Console.WriteLine($"La somme des calculs est {somme}");
        }
    }
}
