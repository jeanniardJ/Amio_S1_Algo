using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class YesNoQuestionHandler
    {
        public static void SetQuestion(string question)
        {
            Console.WriteLine($"{question}");
        }

        public static void AskYesNoQuestion(string answer)
        {
            Console.WriteLine($"La réponse à la question est {answer}");
        }
    }
}
