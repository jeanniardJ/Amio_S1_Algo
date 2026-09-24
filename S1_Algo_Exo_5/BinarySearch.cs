using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class BinarySearch
    {
        public static void FindIndex()
        {
            int[] numbers = { -6, -2, 4, 7, 22, 76, 123, 456, 789, 1032 };

            int inputNbr;

            Console.WriteLine("Entrer la valeur à rechercher : ");
            int.TryParse(Console.ReadLine(), out inputNbr);

            Console.WriteLine($"La valeur {(Dico(numbers, inputNbr) ? "a été trouver" : "n'a pas été trouver" )}");
        }

        static bool Dico(int[] arr, int value)
        {

            //si arr == 1
            if (arr.Length == 1)
            {
                return arr[0] == value;
            }
            else
            {
                int milieu = arr.Length / 2;

                if (arr[milieu] == value) 
                    return true;
                else
                {
                    int[] copie = new int[milieu];

                    if (arr[milieu] > value)
                    {
                        //Retourner la partie de droit du tableau
                        //Il faut retouner la plage de valeur qui reste tableau[n-.],
                        //si la valeur est plus grande que la valeur qui pour index n du tableau,
                        //donner le tableau n à n fin du tableau original.
                        //arr.Lenght - milieur = donne le nombre de cellule restant dans un tableau
                        int i = 0;

                        for(int n = 0; n < milieu; n++)
                        {
                            Console.WriteLine(arr[n]);
                            copie[i] = arr[n];
                            i++;
                        }
                    }
                    else
                    {
                        //Retouner la partie de gauche du tableau
                        int i = 0;

                        for (int n = milieu; n < arr.Length; n++)
                        {
                            Console.WriteLine(arr[n]);
                            copie[i] = arr[n];
                            i++;
                        }
                    }

                    return Dico(copie, value);
                }
            }
        }
    }
}
