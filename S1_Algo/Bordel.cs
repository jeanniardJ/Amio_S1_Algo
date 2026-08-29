using System.ComponentModel.DataAnnotations;

namespace S1_Algo
{
    internal class Bordel
    {
        private String propA = "fdklsjfdls";
        
        private int propBInt = 7843;

        private int propCInt = 45454;

        private char propChar = 'b';

        private double propDouble = 0.0;

        //Méthode static de test de calcul
        public static void methodeDeCalcul()
        {
            int varA = 5446;
            int varB = 5464;

            Console.WriteLine("Test : " + (varA + varB));
        }

        //Méthode d'affichage de calcul des propriety de type private 
        public void affichageCalcul()
        {
            Console.WriteLine(propCInt + propBInt);
        }

        public void affichageText()
        {
            Console.WriteLine("String : " + propA);
        }

        public void affichageVariable()
        {
            int Variable1 = 12 / 5;
            Console.WriteLine("Calcul : \n" + Variable1 + "\n");

            int n1 = 3;
            int n2 = 2;
            float resultat = n1 / n2;

            Console.WriteLine("Calcul n1 / n2 : " + resultat + "\n");

            int Variable2 = 13 % 5;

            Console.WriteLine("Calcul 13 % 5 : " + Variable2);

            int Nombre1 = 13;
            int Nombre2 = 4;
            int Resultat = Nombre1 % Nombre2;

            Console.WriteLine("Calcul Nombre1 % Nombre2 : " + Resultat + "\n");

            int Variable3 = 3 + 8 * 2;

            Console.WriteLine("Calcul 3 + 8 * 2 : " + Variable3 + "\n");

            bool Variable4 = false;
            bool Variable5 = true && !Variable4;

            Console.WriteLine("Retour true && !Variable4 : " + Variable5 + "\n");
        }

        public void exercice8()
        {
            decimal y = 7 / 2;
            decimal z = y * 3;
            bool Variable1 = 3 * 2 - 7 < (4 / 8 - 2);

            Console.WriteLine("x = 4 > 2; -> " + (4 > 2));

            Console.WriteLine("y = 7 / 2; -> " + y);

            Console.WriteLine("z = y * 3; -> " + z);

            Console.WriteLine("a = (z == 10); -> " + (z == 10));

            Console.WriteLine("3 * 2 - 7 < (4 / 8 - 2); -> " + Variable1);
        }
    }
}
