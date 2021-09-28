using System;
using System.Collections.Generic;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> countingChars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (countingChars.ContainsKey(input[i]) == false)
                    {
                        countingChars.Add(input[i], 0);
                    }
                    countingChars[input[i]]++;
                }
            }

            foreach (var kvp in countingChars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
