using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHello
{
    internal class Cercle
    {
        public static void calculPerimCercle()
        {
            string rayonStr;
            double rayon;
            double result;

            Console.WriteLine("Rentrez la valeur du rayon du cercle :");

            rayonStr = Console.ReadLine();

            rayon = double.Parse(rayonStr);

            result = 2 * Math.PI * rayon;

            Console.WriteLine($"Le cercle de rayon {rayon} a un périmètre égal à {result}");
        }
    }
}
