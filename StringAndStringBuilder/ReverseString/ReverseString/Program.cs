using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsToReverse = new List<string>(); 

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                    break;

                wordsToReverse.Add(input);
            }

            ReverseString(wordsToReverse);
        }

        static void ReverseString(List<string> wordsToReverse)
        {
            string[] reversedWords = new string[wordsToReverse.Count];

            for (int n = 0; n < wordsToReverse.Count; n++)
            {
                for (int i = wordsToReverse[n].Length - 1; i >= 0; i--)
                    reversedWords[n] += wordsToReverse[n][i];
            }

            for (int i = 0; i < wordsToReverse.Count; i++)
            {
                Console.WriteLine($"{wordsToReverse[i]} = {reversedWords[i]}");
            }
        }
    }
}
