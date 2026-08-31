namespace S1_Algo
{
    internal class Zorglub
    {
        /*
         * Exercice 10 : Impot
         * 
         */
        public static void impot()
        {
            int age;
            string sexe;

            Console.WriteLine("Quel est votre age ?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est votre sexe ? (H/F)");
            sexe = Console.ReadLine();

            if (sexe == "H" && age >= 20)
            {
                Console.WriteLine("Vous êtes imposable");
            }
            else if (sexe == "F" && age >= 18 && age <= 35)
            {
                Console.WriteLine("Vous êtes imposable");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas imposable");
            }
        }
    }
}
