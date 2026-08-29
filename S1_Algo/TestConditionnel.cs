using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class TestConditionnel()
    {
        public static void condition()
        {
            bool logique1 = false && false;
            bool logique2 = false && true;
            bool logique3 = true && false;
            bool logique4 = true && true;

            Console.WriteLine(logique1);
            Console.WriteLine(logique2);
            Console.WriteLine(logique3);
            Console.WriteLine(logique4);
            Console.WriteLine("\n");
        }

        public static void logique()
        {
            bool logique1 = false || false;
            bool logique2 = false || true;
            bool logique3 = true || false;
            bool logique4 = true || true;

            Console.WriteLine(logique1);
            Console.WriteLine(logique2);
            Console.WriteLine(logique3);
            Console.WriteLine(logique4);
        }
    }
}
