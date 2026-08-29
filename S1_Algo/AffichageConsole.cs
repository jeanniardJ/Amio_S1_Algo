using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class AffichageConsole
    {
        public static void demandePrenom()
        {
            Console.WriteLine("Entree votre prenom : \n");
            string prenom = Console.ReadLine();

            Console.WriteLine($"Bienvenu : {prenom}");
        }
    }
}
