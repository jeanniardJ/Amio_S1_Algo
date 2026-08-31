using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class FindUpNumber
    {
        public static void findUpNumber()
        {
            int firtNb;
            int lastNb;

            Console.WriteLine("Enter a first number: ");
            firtNb = int.Parse(Console.ReadLine());
            lastNb = int.Parse(Console.ReadLine());

            //
            Console.WriteLine("La plus grande valeur est : " + Math.Max(firtNb, lastNb));
        }
    }
}
