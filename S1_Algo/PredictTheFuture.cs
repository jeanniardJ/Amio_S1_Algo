using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class PredictTheFuture
    {
        /*
         * Exercice 11 : Prédire l'avenir
         * 
         * Écrivez un programme qui demande à l'utilisateur de saisir une heure (0-23) et un nombre de minutes (0-59). 
         * Le programme doit ensuite afficher l'heure qu'il sera dans une minute.
         * 
         * Par exemple, si l'utilisateur saisit 14 pour l'heure et 59 pour les minutes, le programme doit afficher "Il sera 15:00 dans une minute."
         */
        static public void PredictTheClock()
        {
            int heure = 0;
            int time = 0;

            Console.WriteLine("Entrez l'heure (0-23) : ");

            try
            {
                heure = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur : Veuillez entrer un nombre entier valide pour l'heure.");
                return;
            }

            if (heure < 0 || heure > 23)
            {
                Console.WriteLine("Erreur : L'heure doit être comprise entre 0 et 23.");
                return;
            }

            Console.WriteLine("Entrez le nombre de minutes (0-59) : ");

            try
            {
                time = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur : Veuillez entrer un nombre entier valide pour les minutes.");
                return;
            }

            if (time < 0 || time > 59)
            {
                Console.WriteLine("Erreur : Le nombre de minutes doit être compris entre 0 et 59.");
                return;
            }

            // Ajout de 1 minute
            time += 1;

            if(time == 60)
            {
                time = 0;
                heure += 1;
                if(heure == 24)
                {
                    heure = 0;
                }
            }

            Console.WriteLine($"Dans une minute, il sera {heure:D2}:{time:D2}");
        }
    }
}
