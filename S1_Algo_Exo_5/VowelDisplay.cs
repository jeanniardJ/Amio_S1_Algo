using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class VowelDisplay
    {
        public static void DisplayVowels()
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y' };
            for(int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine($"Voyelle {vowels[i]}");
            }
            
        }
    }
}