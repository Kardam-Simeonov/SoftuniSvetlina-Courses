using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
                if (ch != ' ')
                    if (charCount.ContainsKey(ch))
                        charCount[ch]++;
                    else
                        charCount.Add(ch, 1);

            foreach (var ch in charCount)
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
        }
    }
}
