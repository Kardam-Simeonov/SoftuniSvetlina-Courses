using System;
using System.Text.RegularExpressions;

namespace FindLetterDigitAndSymbolCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection uppercaseLetters = Regex.Matches(input, @"[A-Z]");
            MatchCollection lowercaseLetters = Regex.Matches(input, @"[a-z]");
            MatchCollection digits = Regex.Matches(input, @"\d");
            MatchCollection symbols = Regex.Matches(input, @"[^a-zA-Z\d]");

            Console.WriteLine($"uppercase: {uppercaseLetters.Count}");
            Console.WriteLine($"lowercase: {lowercaseLetters.Count}");
            Console.WriteLine($"digits: {digits.Count}");
            Console.WriteLine($"other symbols: {symbols.Count}");
        }
    }
}
