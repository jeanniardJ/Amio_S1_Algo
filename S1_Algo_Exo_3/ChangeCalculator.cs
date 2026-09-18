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

            Console.WriteLine("Veuillez rentrer un à un les différent prix : ");

            do
            {
                int.TryParse(Console.ReadLine(), out inputPrixItem);
                sommeSell += inputPrixItem;
            } while (inputPrixItem != 0);

            Console.WriteLine($"Montant de la facture : {sommeSell}");

            Console.Write("Montant versé ? : ");

            int.TryParse(Console.ReadLine(), out inputMoney);

            //Prendre la valeur inputMoney puis faire inputMoney - sommeSell = qui donne la somme à rendre
            sommeRendre = inputMoney - sommeSell;

            //Combien de billets de 10, de 5 et de 1. Il faut compte combien de billets pouvons nous rendre dans
            Console.WriteLine($"Somme à rendre : {sommeRendre}");
            
            compteTen = sommeRendre / 10;//Le nombre de billets de 10 à rendre
            sommeRendre = sommeRendre % 10;
            compteFive = sommeRendre / 5;
            sommeRendre = sommeRendre % 5;

            Console.WriteLine($"Rendu monaie : \n\t {compteTen} de billet(s) de 10, \n\t {compteFive} de billet(s) de 5, \n\t {sommeRendre} de billet(s) de 1");
        }
    }
}
