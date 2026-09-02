using System.Diagnostics;
using System.Globalization;

namespace S1_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            while (true)
            {
                ChoixExo();
                Console.WriteLine("Voulez-vous continuer ? (O/N)");
                string inputContinue = Console.ReadLine();
                if (inputContinue.ToUpper() != "O")
                {
                    break;
                }
            }
        }
        static void ChoixExo()
        {
            Console.WriteLine("Choisissez un exercice de 1 à .... : ");
            int inputChoix = Convert.ToInt32(Console.ReadLine());

            switch (inputChoix)
            {
                case 1:
                    Console.WriteLine("Exercice pair ou impair");
                    Modulo.modulo();
                    break;
                case 2:

                    break;
                default:
                    Console.WriteLine("Aucun exercice choisi");

                    break;
            }
        }
    }
}
