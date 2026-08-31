namespace S1_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Console.WriteLine(Math.Sqrt(64));

            int variableInt = 36;
            float variableFloat = 1.0f;
            bool variableBool = false;
            String variableString = "dsfkldnsfl";
            char variableChar = '"';


            Console.Write("Hello, World! : \n" +
                "variable Int : " + variableInt + "\n" +
                "variable float : " + variableFloat + "\n");

            //Méthode static
            Bordel.methodeDeCalcul();

            //Méthode appel par l'objet
            Bordel lol = new Bordel();
            lol.affichageCalcul();
            lol.affichageText();

            //Conditionnelle
            TestConditionnel.condition();

            //Logique ||
            TestConditionnel.logique();

            //Affichage variable
            //lol.affichageVariable();

            //Affichage exo 8
            //lol.exercice8();

            //Using console read/write
            //AffichageConsole.demandePrenom();

            //Conditions
            //Console.WriteLine("Conditions : ");
            //Conditions.condition();
            //Conditions.logique();
            //Conditions.calculCinquante();
            //Conditions.nombre();
            //Conditions.trololo();
            //Conditions.test();
            Console.WriteLine("FindUpNumber : ");
            //FindUpNumber.findUpNumber();
            Class1.TestUnsafe();
        }
    }
}
