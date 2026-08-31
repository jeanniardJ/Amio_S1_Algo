using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Algo
{
    internal class Reprographie
    {
        public static void reprographie()
        {
            //Prix des 10 premiers copie est à 0.10€
            //Les 20 copies suivantes sont à 0.09€
            //Et au-delà, le prix est de 0.08€
            double prix = 0.0;
            int copies = 0;
            Console.WriteLine("Combien de copies voulez-vous faire ?");
            copies = Convert.ToInt32(Console.ReadLine());

            if(prix <= 10)
            {
                prix = copies * 0.10;
            }
            else if(prix > 10 && prix <= 30)
            {
                prix = (10 * 0.10) + ((copies - 10) * 0.09);
            }
            else
            {
                prix = (10 * 0.10) + (20 * 0.09) + ((copies - 30) * 0.08);
            }
            Console.WriteLine("Le prix total est de : " + prix + "€");
        }
    }
}
