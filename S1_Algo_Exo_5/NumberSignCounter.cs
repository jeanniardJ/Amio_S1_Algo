using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class NumberSignCounter
    {
        public static void CountPositiveAndNegativeNumbers()
        {
            int[] nbrs;
            int nbrSaisie = 0;
            int compteurPositif = 0;
            int compteurNegative = 0;

            Console.WriteLine("Entree un nombre de valeur que vous voulez saisir : ");

            //TODO : Tant que l'utilisateur entre pas au moins une valeur de saisie superieur à 0
            nbrSaisie = Convert.ToInt32(Console.ReadLine());

            nbrs = new int[nbrSaisie];

            for (int i = 0; i < nbrSaisie; i++)
            {
                Console.WriteLine($"Entre votre saisie numero {i + 1}");
                nbrs[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Compteur le nombre de valeur négative et le nombre de valeur positif dans le tableau
            for (int i = 0; i < nbrSaisie; i++)
            {
                if (nbrs[i] >= 0)
                {
                    compteurPositif++;
                }
                else
                { 
                    compteurNegative++; 
                }

            }

            Console.WriteLine($"Nombre de valeur positive {compteurPositif++} et nombre de valeur négative {compteurNegative}");
        }
    }
}
