using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class GeneralElections
    {
        public static void electionsLegislatives()
        {
            string result = "Favorable";
            double[] scoreCandidate = new double[4];

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Entrez le score du candidat {i + 1} :");
                scoreCandidate[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            //Si un candidat obtient plus de 50% des voix, il est élu.
            //Si aucun candidat n'obtient plus de 50% des voix, un second tour est organisé entre les candidats ayant obtenu au moins 12,5% des voix au premier tour.

            for (int i = 0; i <= 3; i++)
            {
                if (scoreCandidate[i] > 50)
                {
                    result = $"Le candidat {i + 1} est élu.";
                    break;
                }
                else
                {
                    //TODO: Implement second round logic
                }
            }
        }
    }
}
