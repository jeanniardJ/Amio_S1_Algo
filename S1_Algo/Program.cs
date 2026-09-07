using System.Diagnostics;
using System.Globalization;

namespace S1_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            while (true)
            {
                ChoixExo();

                Console.WriteLine("Voulez-vous continuer ? (O/N)");

                string inputContinue = Console.ReadLine();

                if (inputContinue.ToUpper() != "O")
                {
                    break;
                }
            }
        }
        static void ChoixExo()
        {
            int input;
            Console.WriteLine("Choisissez un exercice de 1 à .... : ");

            //TODO : Faire un affichage des exercices disponibles avec leur numéro correspondant

            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez entrer un nombre valide.");
                return;
            }

            int inputChoix = Convert.ToInt32(input);

            switch (inputChoix)
            {
                case 1:
                    Console.WriteLine("Exercice pair ou impair");
                    Modulo.modulo();
                    break;
                case 2:
                    Console.WriteLine("Exercice le plus grand des deux");
                    FindUpNumber.findUpNumber();
                    break;
                case 3:
                    Console.WriteLine("Exercice signe d'un nombre");
                    SignOfNb.signOfnumber();
                    break;
                case 4:
                    Console.WriteLine("Exercice note");
                    Note.note();
                    break;
                case 5:
                    Console.WriteLine("Exercice signe d'un produit");

                    break;
                case 6:
                    Console.WriteLine("Exercice Réponse");

                    break;
                case 7:
                    Console.WriteLine("Exercice Catégorie");

                    break;
                case 8:
                    Console.WriteLine("Exercice l'impôt sur Zoeglub");

                    break;
                case 9:
                    Console.WriteLine("Exercice facture photocopies");
                    break;
                case 10:
                    Console.WriteLine("Exercice assurance automobile");
                    break;
                case 11:
                    Console.WriteLine("Exercice Prédire l'avenir");
                    break;
                case 12:
                    Console.WriteLine("Exercice les élections législatives");
                    break;
                case 13:
                    Console.WriteLine("Exercice vérification d'une date");
                    break;
                default:
                    Console.WriteLine("Aucun exercice choisi");

                    break;
            }
        }
    }
}
