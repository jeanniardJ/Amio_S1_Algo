using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    /// <summary>
    /// Provides a static method for sorting and displaying an array of integers using the bubble sort algorithm.
    /// </summary>
    internal class BubbleSort
    {
        /// <summary>
        /// Sorts an array of integers in ascending order and writes the sorted values to the console.
        /// </summary>
        public static void SortArray()
        {
            int[] numbers = { 3, 1, 5, 6, 2, 4, 7, 8 };
            int temp = 0;

            for(int x = 0; x < numbers.Length; x++)
            {
                for(int y = 0; y < numbers.Length-1; y++)
                {
                    if (numbers[y+1] < numbers[y])
                    {
                        temp = numbers[y];
                        numbers[y] = numbers[y + 1];
                        numbers[y + 1] = temp;
                    }
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
