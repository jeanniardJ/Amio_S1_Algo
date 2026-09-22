using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    /**
     * Ecrire et tester une fonction qui, à partir d'un nombre entier passé en paramètre, 
     * renvoie un booléen égal true à si le nombre est pair et false sinon.
     */
    internal class EvenNumberChecker
    {
        public static void GetNumber()
        {
            int inputNbr;

            Console.WriteLine("Entree un nombre entier : ");

            inputNbr = int.Parse(Console.ReadLine());

            Console.WriteLine($"Le nombre est {(IsEven(inputNbr) ? "pair" : "impair")}");
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }
    }
}
