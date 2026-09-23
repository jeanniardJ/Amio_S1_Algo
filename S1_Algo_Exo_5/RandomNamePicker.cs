using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_5
{
    internal class RandomNamePicker
    {
        public static void DrawRandomName()
        {
            string[] noms = inputName();

            //Tirer au sort un nom, puit donner la possibiliter à l'user de définir le nombre de nom tirer au sort
            randomName(noms);
        }

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

        static void randomName(string[] names)
        {

        }
    }
}
