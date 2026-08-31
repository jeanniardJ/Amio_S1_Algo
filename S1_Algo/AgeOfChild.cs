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

            if (age >= 6 || age <= 7)
            {
                Console.WriteLine("Poussin");
            }
            else if (age >= 8 || age <= 9)
            {
                Console.WriteLine("Pupille");
            }
            else if (age >= 10 || age <= 11)
            {
                Console.WriteLine("Minime");
            }
            else if (age >= 12)
            {
                Console.WriteLine("Cadet");
            }
            else
            {
                Console.WriteLine("Hors catégorie");
            }
        }
    }
}