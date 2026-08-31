namespace ConsoleHello
{
    internal class Cube
    {
        /*
         * Write a program that asks the user for a number and displays its cube.
         * The program should be able to handle both integer and decimal numbers.
         */
        public static void affichageCubeInt()
        {
            string entree;
            int nombre;

            Console.WriteLine("Rentrez un nombre entier : ");

            entree = Console.ReadLine();
            nombre = int.Parse(entree);

            //int resultNb = nombre * nombre * nombre;
            int resultNb = (int)Math.Pow(nombre, 3);

            Console.WriteLine($"Cube du nombre {entree}, est égale : {resultNb}");

        }

        /*
         * Write a program that asks the user for a number and displays its cube.
         * The program should be able to handle both integer and decimal numbers.
         */
        public static void affichageCubeDouble()
        {
            string entree;
            double nombre;

            Console.WriteLine("Rentrez un nombre à vergule : ");

            entree = Console.ReadLine();

            nombre = double.Parse(entree);

            double resultNb = nombre * nombre * nombre;

            Console.WriteLine($"Cube du nombre {entree}, est égale : {resultNb}");

        }
    }
}
