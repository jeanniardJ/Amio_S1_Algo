using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    internal class MultiplcationTable
    {
        /**
         * This method displays the multiplication table of a number entered by the user.
         * It prompts the user to enter a number between 0 and 9, and then prints the multiplication table for that number from 1 to 10.
         */
        public static void ShowMultiplcationTable()
        {
            int nbrInput = 0;

            Console.WriteLine("Enter a number to display its multiplication table (0-9): ");

            nbrInput = Console.ReadKey().KeyChar - '0';

            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{nbrInput} x {i} = {nbrInput * i}");
            }
        }
    }
}
