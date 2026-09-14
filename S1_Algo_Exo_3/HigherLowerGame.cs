using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    internal class HigherLowerGame
    {
        public static void PlayGame()
        {
            bool retry = false;
            do
            {
                int randNbr = new Random().Next(100);
                int inputNbr;
                bool find = false;

                do
                {
                    Console.WriteLine("Entrer un nombre : ");
                    inputNbr = int.Parse(Console.ReadLine());

                    if (inputNbr == randNbr)
                    {
                        Console.WriteLine($"Nombre trouvé : {inputNbr}");
                        find = true;
                    }
                    else if (inputNbr > randNbr)
                    {
                        Console.WriteLine("Trop grand");
                    }
                    else
                    {
                        Console.WriteLine("Trop petit");
                    }
                }
                while (!find);

                Console.WriteLine("Voulez-vous rejouer (O/N) ?");

                retry = Console.ReadKey().ToString().ToLower() ==  "O" ? false : true;

                Console.WriteLine("\n");
            }
            while (retry);

        }
    }
}
