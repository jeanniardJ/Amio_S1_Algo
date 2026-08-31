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

            Console.WriteLine("Le signe du produit est positif");

            Console.WriteLine("Le signe du produit est négatif");
        } 
    }
}
