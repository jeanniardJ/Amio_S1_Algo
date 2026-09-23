using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class PrimeNumberChecker
    {
        public static bool IsPrimeNumber(int number)
        {
            bool result = false;
            int compteur = 0;

            //Si le nombre est divisible au dela de lui même et de 1, il n'est pas un nombre premiere
            for (int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    compteur++;
                }
            }

            if(compteur < 3)
            {
                result = true;
            }

            return result;
        }
    }
}