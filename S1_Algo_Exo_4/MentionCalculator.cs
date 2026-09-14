using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_4
{
    internal class MentionCalculator
    {
        public static String GetMention(int grade)
        {
            switch (grade) {
                case < 10:
                    return "Echec";
                case < 12:
                    return "Passable";
                case < 14:
                    return "Assez bien";
                case < 16:
                    return "Bien";
                default:
                    return "Trés bien";
            }
        }
    }
}
