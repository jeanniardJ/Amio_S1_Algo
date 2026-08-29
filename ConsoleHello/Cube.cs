namespace ConsoleHello
{
    internal class Cube
    {
        public static void affichageCubeInt()
        {
            string entree;
            int nombre;

            Console.WriteLine("Rentrez un nombre entier : ");

            entree = Console.ReadLine();
            nombre = int.Parse(entree);

            int resultNb = nombre * nombre * nombre;

            Console.WriteLine($"Cube du nombre {entree}, est égale : {resultNb}");

        }

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
