using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class blockWhile
    {
        public static void affichageWhile()
        {
            int i = 1;
            Console.WriteLine("While : ");

            while (i < 21)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void affichageDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine("i = " + i);
                i++;
            } while (i < 21);
        }
    }
}
