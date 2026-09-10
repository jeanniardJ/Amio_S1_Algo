using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    /**
     * The Boucle class contains methods that demonstrate the use of different types of loops in C#.
     * It includes methods to display numbers in various ranges using while, do-while, and for loops.
     */
    internal class Boucle
    {

        public static void DoWhileForExo()
        {
            int x = 1;
            Console.WriteLine("Affichage de tous les nombres de 1 à 20 :");

            Console.WriteLine("While:");
            while (x < 21)
            {
                Console.WriteLine(x);
                x++;
            }

            x = 1;

            Console.WriteLine("Do While:");

            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 21);

            Console.WriteLine("\nFor:");
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void BoucleTwoOfTwoExo()
        {
            int x = 1;

            Console.WriteLine("Affichage de tous les nombres de 5 à 25 en avançant de 2 en 2");

            Console.WriteLine("While:");

            while (x < 26)
            {
                if (x >= 5)
                {
                    Console.WriteLine(x);
                }
                x += 2;
            }

            do
            {
                if (x >= 5)
                {
                    Console.WriteLine(x);
                }
                x += 2;
            }
            while (x < 26);

            Console.WriteLine("\nFor:");

            for (int i = 5; i < 26; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void ValueDecrementExo()
        {
            int x = 0;
            Console.WriteLine("Affichage de tous les nombres de 0 à -20 :");
            Console.WriteLine("While:");

            while (x > -21)
            {
                Console.WriteLine(x);
                x--;
            }

            x = 0;

            Console.WriteLine("Do While:");

            do
            {
                Console.WriteLine(x);
                x--;
            }
            while (x > -21);

            Console.WriteLine("\nFor:");

            for (x = 0; x > -21; x--)
            {
                Console.WriteLine(x);
            }
        }
    }
}
