using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class Modulo
    {
        public static void modulo()
        {
            Console.WriteLine("Entrez un nombre entier : ");

            int nombre = Convert.ToInt32(Console.ReadLine());

            if (nombre % 2 == 0)
            {
                Console.WriteLine("Le nombre " + nombre + " est pair.");
            }
            else
            {
                Console.WriteLine("Le nombre " + nombre + " est impair.");
            }
        }
    }
}
