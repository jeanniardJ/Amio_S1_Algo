using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class Greeting
    {
        public static void AskForName()
        {
            Console.WriteLine("Entree votre nom : ");
            SayHello(Console.ReadLine());
        }
        public static void SayHello(String NomUtilisateur)
        {
            Console.WriteLine($"Bonjour {NomUtilisateur}");
        }
    }
}
