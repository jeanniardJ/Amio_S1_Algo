using System.Runtime.CompilerServices;

namespace ConsoleHello
{
    internal class HelloWorld
    {
        public static void helloWorld()
        {
            // Affichage de la phrase demandant le nom (sans sauter de ligne)
            Console.Write("Rentrez votre nom : ");
            // Récupération du nom de l'utilisateur
            string Nom = Console.ReadLine();
            // Affichage de "bonjour " suivi du nom de l'utilisateur
            Console.WriteLine("Bonjour " + Nom);
            // Autre manière de faire
            Console.WriteLine($"Bonjour {Nom}");
        }

        //string to float
        public static void convertionType()
        {
            string nombre;
            float number2;

            message();

            nombre = Console.ReadLine();

            if (nombre != null)
            {
                try
                {
                    number2 = float.Parse(nombre);
                    Console.WriteLine($"Nombre convertis : {number2}");
                }
                catch (Exception e)
                {
                    convertionType();
                }
            }

        }

        private static void message()
        {
            Console.WriteLine("Entre un nombre : ");
        }
    }
}
