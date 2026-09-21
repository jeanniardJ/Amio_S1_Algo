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
            
            char[] splitMot = new char[chrMot.Length];
            char valueFind;
            

            for (int i = 0; i < nbrCarc; i++)
            {
                int compteur = 0;
                //Prendre la premiere valeur du tableau puis la comparer avec les autres jusqu'a trouver une diff,
                //si diff prendre l'index de cette valeur est comparer au index suivant

                if (i < chrMot.Length-1 && chrMot[i] == chrMot[i + 1])
                {
                    compteur++;
                }

                Console.WriteLine($" {chrMot[i]} : {compteur}");
            }
        }
    }
}
