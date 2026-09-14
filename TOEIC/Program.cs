using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace TOEIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string userName = retrieveUserName();
            int userTOIECScore = retrieveTOEICScore();

            printWelcomMessage(userName, userTOIECScore);

            string retrieveUserName()
            {
                Console.Write("Veuillez saisir votre nom : ");
                return Console.ReadLine();
            }

            int retrieveTOEICScore()
            {
                bool result;
                int nombre;

                do
                {
                    Console.WriteLine("Veuillez saisir votre score au TOEIC : ");
                    string inputUser = Console.ReadLine();
                    
                    result = int.TryParse(inputUser, out nombre) ? true : false;

                    Console.WriteLine($"Votre score n'est pas valide");
                } while (!result);

                return nombre;
            }

            void printWelcomMessage(string userName, int userTOIECScore)
            {
                Console.WriteLine("*****************\r\n** Bienvenue ! **\r\n*****************");
                Console.WriteLine($"Bonjour {userName}.");
                Console.WriteLine("Nous sommes ravies de t'accuillir parmis nous.");
                GetToeicFeedbackMessage(userTOIECScore);
            }

            void GetToeicFeedbackMessage(int userTOIECScore)
            {
                switch (userTOIECScore)
                {
                    case < 650:
                        Console.WriteLine("Ne vous découragez pas le TOEIC est une épreuve qui nécessite de la ténacité !");
                        break;
                    case < 850:
                        Console.WriteLine($"Félicitations pour votre score de {userTOIECScore} au TOIEC \u263B");
                        break;
                    case >= 850:
                        Console.WriteLine($"Incroyable ! Félicitations pour votre score de {userTOIECScore} au TOIEC");
                        break;
                }
            }
        }

    }
}
