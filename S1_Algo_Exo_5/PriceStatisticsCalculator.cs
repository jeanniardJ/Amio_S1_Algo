using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class PriceStatisticsCalculator
    {
        public static void CalculateTotalAndAverage()
        {
            int nbrSaisi;
            double[] prix;
            double toto = 0;

            //Demander à l'utilisateur le nombre de prix qu'il souhaite
            Console.WriteLine("Saisisé le nombre de prix que vous voulez aditionner : ");
            nbrSaisi = int.Parse(Console.ReadLine());
            //TODO : Verifiere qu'un utilisateur saisie un nombre de type entier positive
            prix = new double[nbrSaisi];

            for (int i = 0; i < nbrSaisi; i++)
            {
                Console.WriteLine($"Entre le prix de la saisie numero {i + 1}:");
                prix[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < prix.Length; i++)
            {
                toto += prix[i];
            }

            Console.WriteLine($"Le total de tout ces prix est : {toto}");

            Console.WriteLine($"Est la moyenne de tout ces prix est {toto / nbrSaisi}");
        }
    }
}
