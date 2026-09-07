using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class AgeOfChild
    {
        /*
         * Exercice 9 : Age of Child
         * 
         */
        public static void ageOfChild()
        {
            Console.WriteLine("Quel âge a l'enfant ?");
            int age = Convert.ToInt32(Console.ReadLine());
            string category = "Non autorisé";

            if (age >= 6 && age <= 7)
            {
                category = "Poussin";
            }
            else if (age >= 8 && age <= 9)
            {
                category = "Pupille";
            }
            else if (age >= 10 && age <= 11)
            {
                category = "Minime";
            }
            else if (age >= 12)
            {
                category = "Cadet";
            }
            else
            {
                category = "Hors catégorie";
            }

            Console.WriteLine($"La catégorie de l'enfant est : {category}");
        }
    }
}