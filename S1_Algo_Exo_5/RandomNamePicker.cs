using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    /// <summary>
    /// Provides functionality to select random names from a predefined or user-supplied list.
    /// </summary>
    internal class RandomNamePicker
    {
        static string[] nomsDisponibles = { "Alice", "Bob", "Charlie", "David", "Eve",
                                     "Frank", "Grace", "Hank", "Ivy", "Jack",
                                     "Kate", "Leo", "Mia", "Nick", "Olivia",
                                     "Paul", "Quinn", "Rose", "Sam", "Tina" };


        public static void DrawRandomName()
        {
            //string[] noms = inputName();

            //Tirer au sort un nom, puit donner la possibiliter à l'user de définir le nombre de nom tirer au sort
            string[] nomTirer = randomName(nomsDisponibles, 3);

            Console.WriteLine($"Les noms tirer au sort sont :");

            for(int n = 0; n < nomTirer.Length; n++)
            {
                Console.WriteLine($"Le {n + 1} est {nomTirer[n]}");
            }
        }

        /// <summary>
        /// Demande à l'utilisateur d'entree 12 nom, et verifier si il n'est pas déja enregistrer.
        /// </summary>
        /// <returns>Tableau de nom</returns>
        static string[] inputName()
        {
            string[] noms = new string[12];

            //Verifier qu'un nom entree par l'utilisateur n'est pas déja enregistrer dans le tableau
            for (int n = 0; n < 12; n++)
            {
                bool isFind = false;
                string inputNom;

                do
                {
                    Console.WriteLine("Rentrer un nom : ");

                    inputNom = Console.ReadLine();

                    for (int y = 0; y < noms.Length; y++)
                    {
                        if (noms[y] == inputNom)
                        {
                            Console.WriteLine("Ce nom existe déja !");
                            isFind = true;
                            break;
                        }
                    }
                }
                while (isFind);

                noms[n] = inputNom;
            }

            return noms;
        }

        /// <summary>
        /// Tirer au sort le nom d'un ou plusieurs utilisateurs
        /// </summary>
        /// <param name="names">Tableau de noms</param>
        /// <param name="nbr">Nombre d'utilisateur à tirer au sort</param>
        static string[] randomName(string[] names, int nbr)
        {
            Random rnd = new();
            string[] nomTirer = new string[nbr];
            string nom;
            bool isFind = false;

            //Verifier que l'utilisateur n'a pas été tirer au sort 2, sinon relancer le tirage au sort
            for (int n = 0; n < nbr; n++)
            {
                nom = names[rnd.Next(names.Length)];

                for (int y = 0; y < nomTirer.Length; y++)
                {
                    if (nomTirer[y] == nom)
                    {
                        Console.WriteLine("Ce nom est déja tirer au sort!");
                        n = 0;
                    }
                }

                nomTirer[n] = nom;
            }

            return nomTirer;
        }
    }
}
