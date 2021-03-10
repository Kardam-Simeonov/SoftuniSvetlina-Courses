using System;
using System.Text.RegularExpressions;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            string input = Console.ReadLine();

            foreach (string word in bannedWords)
                input = Regex.Replace(input, word, new string('*', word.Length));

            Console.WriteLine(input);
        }
    }
}
