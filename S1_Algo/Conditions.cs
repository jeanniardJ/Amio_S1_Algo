using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace S1_Algo
{
    internal class Conditions
    {
        public static void condition()
        {
            int Nombre = 10;

            bool Booleen = false;

            string Chaine = "test";

            Console.WriteLine(Nombre != 10 || Booleen || Chaine == "test");
            Console.WriteLine(Booleen != false);
            Console.WriteLine(Nombre % 4 != 0);
            Console.WriteLine(Chaine == "test" || Booleen == true);
            Console.WriteLine(Nombre > 0 && Chaine != "test");
            Console.WriteLine(Booleen || true);
            Console.WriteLine(Nombre <= 10);
            Console.WriteLine(Nombre % 5 == 0);
        }

        public static void logique()
        {
            Console.Write("Rentrez un nombre : ");
            string Reponse = Console.ReadLine();
            int Nombre = int.Parse(Reponse);
            if (Nombre < 50)
            {
                Nombre = Nombre * 2;
            }
            else
            {
                Nombre = Nombre * 3;
            }
        }

        public static void calculCinquante()
        {
            Console.Write("Rentrez un nombre : ");
            string Reponse = Console.ReadLine();
            int Nombre = int.Parse(Reponse);
            if (Nombre < 50)
            {
                Nombre = Nombre * 2;
            }
            else
            {
                if (Nombre > 50)
                {
                    Nombre = Nombre - 5;
                }
                else
                {
                    Nombre = Nombre + 12;
                }
            }
        }

        public static void nombre()
        {
            Console.Write("Rentrez un nombre : ");
            string Reponse = Console.ReadLine();
            int Nombre = int.Parse(Reponse);

            if (Nombre > 10 || Nombre == 5)
            {
                Console.WriteLine("Youpi !");
            }
            else
            {
                Console.WriteLine("Trololo !");
            }
        }

        public static void trololo()
        {
            Console.Write("Rentrez un nombre : ");
            string Reponse = Console.ReadLine();
            int Nombre = int.Parse(Reponse);

            if (!(Nombre == 100))
            {
                Console.WriteLine("Youpi !");
            }
            else
            {
                Console.WriteLine("Trololo !");
            }
        }

        public static void test()
        {
            int Nombre = 12;

            bool Booleen = false;

            string Chaine = "Test";

            Console.WriteLine(Chaine + "2");
            Console.WriteLine(Nombre - 4 == 9);
            Console.WriteLine(Nombre % 4 == 2);
            //Console.WriteLine(Nombre + 10 = 22);
            Console.WriteLine(Chaine != "Toto");
            Console.WriteLine(Nombre / 2);
        }
    }
}
