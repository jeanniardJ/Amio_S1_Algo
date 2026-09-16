using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class ArrayManager
    {
        public static void FillArrays()
        {
            int[] entiers = new int[8];
            char[] chaines = new char[10];
            double[] prix = new double[5];

            for (int i = 0; i < entiers.Length; i++)
            {
                Console.WriteLine("Entrer un nombre entier : ");
                entiers[i] = Convert.ToInt16(Console.ReadLine());
            }

            for(int i = 0; i < chaines.Length; i++)
            {
                Console.WriteLine("Entre un caractere : ");
                chaines[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < prix.Length; i++)
            {
                Console.WriteLine("Entre un prix : ");
                prix[i] = Convert.ToDouble(Console.ReadLine());
            }


            //Affichage de chaque tableaux
            for(int i = 0; i < entiers.Length; i++)
            {
                Console.WriteLine($"Entiers {entiers[i]}");
            }

            for(int i = 0; i < chaines.Length; i++)
            {
                Console.WriteLine($"Caracters : {chaines[i]}");
            }

            for(int i = 0; i < prix.Length; i++)
            {
                Console.WriteLine($"Prix : {prix[i]}");
            }
        }
    }
}
