using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    /**
     * This class is used to verify if a date is valid or not.
     * It takes the day, month and year as input from the user and checks if the date is valid or not.
     * It also checks for leap years.
     */
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

            bool isValidDate = month >= 1 && month <= 12 && day >= 1 && day <= 31;

            if (isValidDate)
            {
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    isValidDate = day <= 30;
                }
                else
                {
                    if (month == 2)
                    {
                        if (isLeapYear)
                        {
                            isValidDate = day <= 29;
                        }
                        else
                        {
                            isValidDate = day <= 28;
                        }
                    }
                }
            }

            Console.WriteLine(isValidDate ? "La date est valide." : "La date n'est pas valide.");
        }
    }
}
