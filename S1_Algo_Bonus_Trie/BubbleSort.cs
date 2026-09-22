using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Bonus_Trie
{
    //Tu dois écrire un programme en C# (console) qui :
    // -> déclare un tableau de nombres,
    // -> implémente le tri à bulles dans une fonction,
    // -> affiche le tableau avant et après le tri.
    internal class BubbleSort
    {
        public static void SortArray()
        {
            int[] nbrs = { 5, 1, 2, 9, 4, 6, 7, 0, 8, 3 };
            bool isTrie = false;

            for (int y = 0; y < nbrs.Length; y++)
            {
                Console.WriteLine($"index {y} : {nbrs[y]}");
            }

            Console.WriteLine("\n");

            //Il faut penser aussi à relancer la boucle tant que le trie n'est pas correcte

            for (int i = 0; i < nbrs.Length; i++)
            {

                for (int y = 0; y < nbrs.Length-1; y++)
                {
                    int tempNbr = 0;
                    if (nbrs[y + 1] < nbrs[y])
                    {
                        //Si nbrs[0] est plus grand que nbrs[1], alors permuter les valeurs.
                        Console.WriteLine($"Nombre {nbrs[y + 1]} : {nbrs[y]}");
                        tempNbr = nbrs[y + 1];
                        nbrs[y + 1] = nbrs[y];
                        nbrs[y] = tempNbr;
                        Console.WriteLine($"Nombre {nbrs[y + 1]} : {nbrs[y]}");
                    }
                }
            }

            Console.WriteLine("\n");
            for (int z = 0; z < nbrs.Length; z++)
            {
                Console.WriteLine($"index {z} : {nbrs[z]}");
            }
        }
    }
}
