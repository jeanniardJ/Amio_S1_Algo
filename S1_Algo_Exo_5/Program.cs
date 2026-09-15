namespace S1_Algo_Exo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\n");
            Console.WriteLine($"{PalindromeChecker.ReverseString("Bonjour")}");
            Console.WriteLine($"{(PalindromeChecker.EstPalindrome("Bonjour") ? "Ce mot est un palindrome" : "Ce mot n'est pas un palindrome")}");
        }
    }
}
