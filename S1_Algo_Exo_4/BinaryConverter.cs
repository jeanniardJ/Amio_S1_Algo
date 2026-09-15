using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class BinaryConverter
    {
        public static void ConvertToBinary(int decimalNumber)
        {
            string binaire = "";

            do
            {
                decimalNumber = decimalNumber / 2;
                binaire += decimalNumber % 2 == 0 ? "1" : "0";
            }
            while (decimalNumber > 0);

            Console.WriteLine($"{binaire}");
        }
    }
}
