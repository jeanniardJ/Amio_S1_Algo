namespace S1_Algo_Exo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine("\n");
            //Greeting.AskForName();
            //Console.WriteLine("\n");
            //SumCalculator.ReadTwoIntegers();
            //Console.WriteLine("\n");
            //EvenNumberChecker.GetNumber();
            //Console.WriteLine("\n");
            //Console.WriteLine($"La mention de l'utilisateur est {MentionCalculator.GetMention(16)}");
            //Console.WriteLine("\n");
            //Console.WriteLine($"La distance est de {DistanceCalculator.PointDistanceCalculator(5, 2, 6, 5)}");
            //Console.WriteLine("\n");
            //Console.WriteLine("Crée une question de type oui/non");
            //YesNoQuestionHandler.SetQuestion(Console.ReadLine());
            //Console.WriteLine("Répondé à la question par oui ou non");
            //YesNoQuestionHandler.AskYesNoQuestion(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Entree un nombre : ");
            //bool result = PrimeNumberChecker.IsPrimeNumber(int.Parse(Console.ReadLine()));
            for(int n = 1; n < 101; n++)
            {
                bool result = PrimeNumberChecker.IsPrimeNumber(n);
                Console.WriteLine($"Le nombre {n} {(result ? "est premiere" : "n'est pas premiere")}");
            }
            //Console.WriteLine("\n");
            //BinaryConverter.ConvertToBinary(42);
            //Console.WriteLine("\n");
            //FactorialCalculator.CalculateFactorial(12);
        }
    }
}
