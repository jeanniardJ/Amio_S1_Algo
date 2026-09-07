namespace Eval_Algo_Finale_CDA13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
        }

        /*
         * Cette méthode demande à l'utilisateur de saisir 15 nombres entiers compris entre 1 et 5,
         * puis affiche un tableau de fréquence sous forme d'histogramme horizontal.
         */
        void frequencyTable()
        {
            //Demander à l'utilisateur de saisir 15 nombres entiers compris entre 1 et 5
            //Verifier que les nombres saisis sont bien compris entre 1 et 5
            int[] numbers = new int[15];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Veuillez saisir le nombre entier {i + 1} (compris entre 1 et 5) :");
                int input;
                while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 5)
                {
                    Console.WriteLine("Entrée invalide. Veuillez saisir un nombre entier compris entre 1 et 5 :");
                }
                numbers[i] = input;
            }

            //Afficher les nombres saisis
            Console.WriteLine("Données :");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            //Affiche une histogramme horizontal des nombres saisis
            Console.WriteLine("\nHistogramme :");
            for (int i = 1; i <= 5; i++)
            {
                int count = numbers.Count(n => n == i);
                Console.WriteLine($"{i}: {new string('█', count)} ({count})");
            }
        }

        void theThreeLargest()
        {

        }
    }
}
