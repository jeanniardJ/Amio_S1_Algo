using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class ArraySumCalculator
    {
        public static void CalculateArraySum()
        {
            int[] tableA = { 4, 8, 7, 9, 1, 5, 4, 6 };
            int[] tableB = { 7, 6, 5, 2, 1, 3, 7, 4 };
            int[] tableTemp = new int[8];

            //for (int i = 0; i < 8; i++)
            //{
            //    tableTemp[i] = tableA[i] + tableB[i];
            //}

            tableTemp = SumArrays(tableA, tableB);

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{tableTemp[i]}{(i + 1 == tableTemp.Length ? ";" : ",")}");
            }
        }

        public static int[] SumArrays(int[] tableA, int[] tableB)
        {

            int[] tableTemp = new int[tableA.Length];

            for (int i = 0; i < 8; i++)
            {
                tableTemp[i] = tableA[i] + tableB[i];
            }

            return tableTemp;
        }
    }
}
