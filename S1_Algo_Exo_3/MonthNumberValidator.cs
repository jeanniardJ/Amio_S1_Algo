using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    /**
     * This class is responsible for validating a month number input by the user.
     * It ensures that the input is between 1 and 12, inclusive.
     */
    internal class MonthNumberValidator
    {
        public static void validateMonthNumberWhile()
        {
            int monthNumber;

            Console.WriteLine("Please enter a month number (1-12):");

            monthNumber = int.Parse(Console.ReadLine());

            while(monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                monthNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"You entered a valid month number: {monthNumber}");
        }

        public static void validateMonthNumberDoWhile()
        {
            int monthNumber;
            int x = 0;

            Console.WriteLine("Please enter a month number (1-12):");

            do
            {
                if (x > 0)
                {
                    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
                }
                monthNumber = int.Parse(Console.ReadLine());
                x++;
            }
            while (monthNumber < 1 || monthNumber > 12);
            
            Console.WriteLine($"You entered a valid month number: {monthNumber}");
        }
    }
}
