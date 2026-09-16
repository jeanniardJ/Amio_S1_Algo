using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class StringCompressor
    {
        public static void CompressString(string chrMot)
        {
            int nbrCarc = chrMot.Length;
            int compteur = 0;
            char[] splitMot = new char[chrMot.Length];

            for (int i = 0; i < nbrCarc; i++)
            {
                if (i > 1)
                {
                    if (chrMot[i-1] != chrMot[i])
                    {
                        compteur++;
                        Console.WriteLine($"{chrMot[i-1]} et {chrMot[i]}");
                    }
                }
            }
        }
    }
}
