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

                char inputContinue = Console.ReadKey().KeyChar;

                
                if (inputContinue!= 'o' && inputContinue != 'O')
                {
                    break;
                }
            }
        }
        static void ChoixExo()
        {
            int input;
            Console.WriteLine("Choisissez un exercice de 1 à .... : ");

            String[] exos = new String[]
            {
                "1). Pair ou impair",
                "2). Le plus grand des deux",
                "3). Signe d'un nombre",
                "4). Note",
                "5). Signe d'un produit",
                "6). Réponse",
                "7). Catégorie",
                "8). L'impôt sur Zoeglub",
                "9). Facture photocopies",
                "10). Assurance automobile",
                "11). Prédire l'avenir",
                "12). Les élections législatives",
                "13). Vérification d'une date"
            };

            for (int i = 0; i < exos.Length; i++)
            {
                Console.WriteLine($"Exercice " + exos[i]);
            }

            Console.WriteLine("Ou taper le nombre 0 pour quitter le programme.");
            
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
                    Modulo.modulo();
                    break;
                case 2:
                    FindUpNumber.findUpNumber();
                    break;
                case 3:
                    SignOfNb.signOfnumber();
                    break;
                case 4:
                    Note.note();
                    break;
                case 5:
                    ProduitOfNbr.produitIfPositiveNegative();
                    break;
                case 6:
                    Answer.writeChar();
                    break;
                case 7:
                    AgeOfChild.ageOfChild();
                    break;
                case 8:
                    Zorglub.impot();
                    break;
                case 9:
                    Reprographie.reprographie();
                    break;
                case 10:
                    Assurance.tarif();
                    break;
                case 11:
                    PredictTheFuture.PredictTheClock();
                    break;
                case 12:
                    PredictTheFuture.PredictTheClock();
                    break;
                case 13:
                    break;
                default:
                    Console.WriteLine("Aucun exercice choisi");

                    break;
            }
        }
    }
}
