using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class YesNoQuestionHandler
    {
        public static string SetQuestion(string question)
        {
            Console.WriteLine($"{question} (oui/non)");

            return Console.ReadLine();
        }
    }
}
