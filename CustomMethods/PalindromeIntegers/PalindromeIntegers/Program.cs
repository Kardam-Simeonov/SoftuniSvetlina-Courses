using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeNumbers();
        }

        static void PalindromeNumbers()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    System.Environment.Exit(0);

                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                
                string palindrome = new string(charArray);
                if (input == palindrome)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }
        }
    }
}
