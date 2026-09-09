using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class GeneralElections
    {
        /*
         * @brief Cette méthode permet de calculer les résultats des élections législatives pour quatre candidats.
         * 
         */
        public static void electionsLegislatives()
        {
            double scoreCandidateA = 0;
            double scoreCandidateB = 0;
            double scoreCandidateC = 0;
            double scoreCandidateD = 0;

            bool isPercentCandidateA;
            bool isPercentCandidateB;
            bool isPercentCandidateC;
            bool isPercentCandidateD;

            Console.WriteLine("Entrez le nombre de voix du candidat A : ");

            scoreCandidateA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez le nombre de voix du candidat B : ");

            scoreCandidateB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez le nombre de voix candidat C : ");

            scoreCandidateC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entrez le nombre de voix candidat D : ");

            scoreCandidateD = Convert.ToDouble(Console.ReadLine());

            //Convertir les scores en pourcentage
            double totalVotes = scoreCandidateA + scoreCandidateB + scoreCandidateC + scoreCandidateD;

            scoreCandidateA = (scoreCandidateA / totalVotes) * 100;
            scoreCandidateB = (scoreCandidateB / totalVotes) * 100;
            scoreCandidateC = (scoreCandidateC / totalVotes) * 100;
            scoreCandidateD = (scoreCandidateD / totalVotes) * 100;

            isPercentCandidateA = scoreCandidateA > 12.5;
            isPercentCandidateB = scoreCandidateB > 12.5;
            isPercentCandidateC = scoreCandidateC > 12.5;
            isPercentCandidateD = scoreCandidateD > 12.5;

            Console.WriteLine("Résultats des élections législatives :");

            Console.WriteLine($"Candidat A : {scoreCandidateA}% - {(isPercentCandidateA ? "Éligible" : "Non éligible")}");
            Console.WriteLine($"Candidat B : {scoreCandidateB}% - {(isPercentCandidateB ? "Éligible" : "Non éligible")}");
            Console.WriteLine($"Candidat C : {scoreCandidateC}% - {(isPercentCandidateC ? "Éligible" : "Non éligible")}");
            Console.WriteLine($"Candidat D : {scoreCandidateD}% - {(isPercentCandidateD ? "Éligible" : "Non éligible")}");

            // Correction de la condition pour vérifier si le candidat A a remporté l'élection
            if (scoreCandidateA > 50)
            {
                Console.WriteLine("Le candidat A a remporté l'élection avec " + scoreCandidateA + "% des voix.");
            }
            else if (scoreCandidateB > 50 || scoreCandidateC > 50 || scoreCandidateD > 50)
            {
                Console.WriteLine("Un autre candidat a remporté l'élection avec plus de 50% des voix.");
            }
            else if (scoreCandidateA > scoreCandidateB && scoreCandidateA > scoreCandidateC && scoreCandidateA > scoreCandidateD)
            {
                Console.WriteLine("Le candidat A est en tête avec " + scoreCandidateA + "% des voix, mais aucun candidat n'a obtenu plus de 50% des voix. Un second tour est nécessaire.");
            }
            else
            {
                Console.WriteLine("Le candidat A n'est pas éligible pour le second tour avec " + scoreCandidateA + "% des voix.");
            }
        }
    }
}
