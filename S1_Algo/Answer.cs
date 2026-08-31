using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class Answer
    {
        /*
         * Write a program that asks the user for a character and displays:
         * - "Vous avez rentré la lettre O" if the character is 'o' or 'O'
         * - "Vous avez rentré la lettre N" if the character is 'n' or 'N'
         * - "???" for any other character
         */
        public static void writeChar()
        {
            Console.WriteLine("Rentrez un caractère : ");
            //char c = Convert.ToChar(Console.ReadLine());

            char c = Console.ReadKey().KeyChar;

            if (c == 'o' || c == 'O')
            {
                Console.WriteLine("Vous avez rentré la lettre O");
            }
            else if(c == 'n' || c == 'N')
            {
                Console.WriteLine("Vous avez rentré la lettre N");
            }
            else
            {
                Console.WriteLine("???");
            }
        }
    }
}
