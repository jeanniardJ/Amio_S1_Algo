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
            string imposable = "Vous n'êtes pas imposable";

            Console.WriteLine("Quel est votre age ?");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quel est votre sexe ? (H/F)");

            sexe = Console.ReadKey().KeyChar.ToString().ToUpper();

            imposable = (sexe == "H" && age >= 20) || (sexe == "F" && age >= 18 && age <= 35) ? "Vous êtes imposable" : "Vous n'êtes pas imposable";    

            Console.WriteLine($"\n{imposable}");
        }
    }
}
