using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    internal class ReverseHigherLowerGame
    {
        public static void PlayGame()
        {
            Random randNbr = new Random();

            int nbr = randNbr.Next(100), nbrA, nbrB = 100;

            bool findNbr = false;

            int compteur = 0;

            string inputUser;

            do
            {
                Console.WriteLine($"Je pense que le nombre est {nbr}. (ok/+/-)");
                inputUser = Console.ReadLine();

                //Incremente le nombre d'essais
                compteur++;

                if (inputUser == "ok")
                {
                    Console.WriteLine($"Youpi ! J'ai trouver le nombre {nbr} en {compteur} coups.");
                    findNbr = true;
                }
                else if (inputUser == "+")
                {
                    nbrA = nbr;
                    //Si plus random au dessus du nombre proposer
                    nbr = randNbr.Next(nbrA, nbrB);
                }
                else
                {
                    nbrB = nbr;
                    //Si moins random en dessous du nombre proposer
                    nbr = randNbr.Next(nbrB);
                }

            } while (!findNbr);
        }
    }
}
