using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo_Exo_3
{
    internal class ChangeCalculator
    {
        public static void CalculateChange()
        {
            int sommeSell = 0;
            int inputPrixItem = 0;
            int inputMoney = 0;
            int sommeRendre = 0;
            int compteTen = 0;
            int compteFive = 0;
            int compteOne = 0;

            Console.WriteLine("Veuillez rentrer un à un les différent prix : ");

            do
            {
                inputPrixItem = int.Parse(Console.ReadLine());
                sommeSell += inputPrixItem;
            } while (inputPrixItem != 0);

            Console.WriteLine($"Montant de la facture : {sommeSell}");

            Console.Write("Montant versé ? : ");

            inputMoney = int.Parse(Console.ReadLine());

            //Prendre la valeur inputMoney puis faire inputMoney - sommeSell = qui donne la somme à rendre
            sommeRendre = inputMoney - sommeSell;

            //Combien de billets de 10, de 5 et de 1. Il faut compte combien de billets pouvons nous rendre dans
            Console.WriteLine($"Somme à rendre : {sommeRendre}");
            
            if (sommeRendre % 10 != 0)
            {
                compteTen = sommeRendre / 10;//Le nombre de billets de 10 à rendre
                sommeRendre = sommeRendre % 10;
            }
            
            if (sommeRendre % 5 != 0)
            {
                compteFive = sommeRendre / 5;
                sommeRendre = sommeRendre % 5;
            }

            if (sommeRendre > 0)
            {
                compteOne = sommeRendre / 1;
                sommeRendre = sommeRendre % 1;
            }

            Console.WriteLine($"Rendu monaie : \n\t {compteTen} de billet(s) de 10, \n\t {compteFive} de billet(s) de 5, \n\t {compteOne} de billet(s) de 1");
        }
    }
}
