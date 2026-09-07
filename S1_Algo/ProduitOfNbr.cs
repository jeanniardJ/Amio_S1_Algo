namespace S1_Algo
{
    internal class ProduitOfNbr
    {
        static public void produitIfPositiveNegative()
        {
            Console.WriteLine("Rentrez un premier nombre : ");
            int nbr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rentrez un deuxième nombre : ");
            int nbr2 = Convert.ToInt32(Console.ReadLine());
            string result = "";
            //string result = (nbr1 > 0 && nbr2 > 0) ? "Le produit est positif" : (nbr1 < 0 && nbr2 < 0) ? "Le produit est positif" : "Le produit est négatif";

            if ((nbr1 > 0 && nbr2 > 0) || (nbr1 < 0 && nbr2 < 0))
            {
                result = "Le produit est positif";
            }
            else if(nbr1 == 0 || nbr2 == 0)
            {
                result = "Le produit est zéro";
            }
            else
            {
                result = "Le produit est négatif";
            }

            Console.WriteLine($"Le produit de {nbr1} et {nbr2} est : {result}");

        } 
    }
}
