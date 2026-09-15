using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class PalindromeChecker
    {
        public static String ReverseString(string mot)
        {
            
            int motLenght = mot.Length-1;
            int x = motLenght;
            char[] chaineCaraInver = new char[motLenght+1];

            //Console.WriteLine(mot.Reverse().ToArray());

            for (int i = 0; i <= motLenght; i++)
            {
                Console.WriteLine($"{mot[i]} : {x}");
                chaineCaraInver[i] = mot[x];
                x--;
            }

            return new string(chaineCaraInver);
        }

        public static bool EstPalindrome(string mot)
        {
            if (mot == ReverseString(mot))
            {

            }


            return true;
        }
    }
}
