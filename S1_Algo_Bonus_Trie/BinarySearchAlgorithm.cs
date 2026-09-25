using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Bonus_Trie
{
    /// <summary>
    /// Provides a binary search implementation for locating the index of a specified integer in a sorted array.
    /// </summary>
    internal class BinarySearchAlgorithm
    {
        static int[] numbers = { -6, -2, 4, 7, 22, 76, 123, 456, 789, 1032 };

        public static void SearchValue()
        {
            bool result = FindIndex(numbers, 76);
            Console.WriteLine($"Le resultat {result}");
        }

        /// <summary>
        /// Dichotomique
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="nbrFind"></param>
        /// <returns></returns>
        static bool FindIndex(int[] numbers, int nbrFind)
        {

            int sizetabs = numbers.Length;
            int middle = sizetabs / 2;
            int[] tabSort;
            
            if (numbers[middle] == nbrFind)
            {
                return true;
            }
                
            if (sizetabs == 1)
                return false;

            //recherche à droit ou gauche en fonction de la valeur à trouve
            if (numbers[middle] < nbrFind)//Si le nombre est plus grand que la valeur, alors svg crée 
            {
                //Il faut recuperer tout le tableau de droit ou de gauche en fonction de la condition
                //il faut partie de l'index du middle + 1 et recuperer les valeurs restants dans la partie de droit du tableau
                //Parcourir le tableau à partir de l'index middle + 1 jusqu'a la fin du table

                tabSort = new int[sizetabs - middle];
                int y = middle;//Je recuperer l'index du tableau

                for (int n = 0; n < (sizetabs - middle); n++)
                {
                    tabSort[n] = numbers[y];
                    y++;
                }
            }
            else
            {
                //Parcourir le tableau à partir de l'index middle -1 jusqu'au début du tableau
                Console.WriteLine($"{middle}");
                tabSort = new int[middle];

                for (int n = 0; n < middle; n++)
                {
                    tabSort[n] = numbers[n];
                }
            }

            FindIndex(tabSort, nbrFind);

            return false;
        }
    }
}
