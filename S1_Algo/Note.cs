using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class Note
    {
        /*
         * Write a program that asks the user for a note (a number between 0 and 20) and displays:
         * - "Admis" if the note is greater than or equal to 10
         * - "Rattrapage" if the note is less than 10 but greater than or equal to 8
         * - "Echec" if the note is less than 8
         */
        public static void note()
        {
            Console.WriteLine("Type a note : ");
            int note = Convert.ToInt32(Console.ReadLine());

            if (note >= 10)
            {
                Console.WriteLine("Admin");
            }
            else if (note < 10 && note >= 8)
            {
                Console.WriteLine("Ratrapage");
            }
            else if (note < 8)
            {
                Console.WriteLine("Echec");
            }
        }
    }
}
