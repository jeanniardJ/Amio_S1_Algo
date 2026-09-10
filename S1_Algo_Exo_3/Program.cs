namespace S1_Algo_Exo_3
{
    internal class Program
    {
        /**
         * The main entry point for the application.
         */
        static void Main(string[] args)
        {
            //TODO : Refoctar the code to use a switch statement to call the different exercises based on user input
            Console.WriteLine("Hello, World of exo three!");
            //Boucle.DoWhileForExo();
            //Boucle.BoucleTwoOfTwoExo();
            Console.WriteLine("\n");
            IntegerSumCalculator.calculateSum();
            Console.WriteLine("\n");
            EvenNumbersSumCalculator.CalculateSumOfFirstNEvenNumbers();
            //Boucle.ValueDecrementExo();
            //Console.WriteLine("\n");
            //MultiplcationTable.ShowMultiplcationTable();
            //Console.WriteLine("\n");
            //BetweenOneAndThree.InputBetweenOneAndThree();
            Console.WriteLine("\n");
            MultipleSumsCalculator.calculateSum();
            //Console.WriteLine("\n");
            //MonthNumberValidator.validateMonthNumberWhile();
            //Console.WriteLine("\n");
            //MonthNumberValidator.validateMonthNumberDoWhile();
            //Console.WriteLine("\n");
            //Factorial.CalculateFactorial();
            //Console.WriteLine("\n");
            //FizzBuzz.RunFizzBuzz();
        }
    }
}
