using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class StringCompressor
    {
        public static void CompressString(string chrMot)
        {
            int nbrCarc = chrMot.Length;

            char[] splitMot = new char[chrMot.Length];
            string valueFind = "";


            for (int i = 0; i < nbrCarc; i++)
            {
                int compteur = 0;

                //Prendre la premiere valeur du tableau et la comparer avec la valeur suivant du tableau
                //Si la valeur 'x' ne correspond pas à la valeur suivant, alors svg le nombre, et remettre le compteur à 0
                //Utilise string pour svg, le nombre doit etre avant la lettre compteur.
                for (int y = 0; y < nbrCarc; y++)
                {
                    if (chrMot[i] == chrMot[y])
                    {
                        compteur++;
                    }

                }

                //Il faut recuperer le nombre de fois que l'on à trouver la lettre et l'associer à sa lettre une seule fois

                Console.WriteLine($" {chrMot[i]} : {compteur}");
                compteur = 0;
            }

            Console.WriteLine(valueFind);
        }

        // défintioon de la fonction, correction
        string Compression(string chaine)
        {
            string res = ""; //Variable de resultat
            // gestion premier caractère
            int compteur = 1;
            char lettrePrecedente = chaine[0];

            // gestion 2eme caractère jusqu'à l'avant dernier
            for (int i = 1; i < chaine.Length - 1; i++)
            {
                if (lettrePrecedente == chaine[i])// Si elle n'est pas different
                {
                    compteur++;
                }
                else
                {
                    res += (compteur > 1 ? compteur.ToString() : "") + lettrePrecedente; //Ternaire
                    compteur = 1;
                    lettrePrecedente = chaine[i];
                }
            }

            // gestion dernier caractère
            if (lettrePrecedente != chaine[chaine.Length - 1])
            {
                res += (compteur > 1 ? compteur.ToString() : "") + lettrePrecedente;
                res += chaine[chaine.Length - 1];
            }
            else
            {
                compteur++;
                res += (compteur > 1 ? compteur.ToString() : "") + lettrePrecedente;
            }

            return res;
        }
    }
}
