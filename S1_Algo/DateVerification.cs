using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class DateVerification
    {
        public static void dateVerification()
        {
            Console.Write("Entrez le jour : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le mois : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez l'année : ");
            int year = Convert.ToInt32(Console.ReadLine());

            //Vérification de la validité de la date, attention aux années bissextiles
            //Une année est bissextile si elle est divisible par 4, mais pas par 100, sauf si elle est divisible par 400.
            //Verifier si l'année est bissextile
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            //verifier de l'année est valide
            if (year < 1)
            {
                Console.WriteLine("Année invalide.");
                return;
            }

            //Vérification du mois
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Mois invalide.");
                return;
            }

            //Vérification du jour en fonction du mois et de l'année
            if (day < 1 || day > 31)
            {
                Console.WriteLine("Jour invalide.");
                return;
            }

            else if (month == 2)
            {
                // Vérification du jour pour le mois de février
                if (isLeapYear && day > 29)
                {
                    Console.WriteLine("Jour invalide pour le mois de février d'une année bissextile.");
                    return;
                }
                else if(!isLeapYear && day > 28)
                {
                    Console.WriteLine("Jour invalide pour le mois de février d'une année non bissextile.");
                    return;
                }
            }
            else
            {
                if(month == 4 || month == 6 || month == 9 || month == 11)
                {
                    // Vérification du jour pour les mois avec 30 jours
                    if (day > 30)
                    {
                        Console.WriteLine("Jour invalide pour le mois choisi.");
                        return;
                    }
                }
            }

            Console.WriteLine($"La date {day:D2}/{month:D2}/{year} est valide.");
        }
    }
}
