using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (string word in input)
            {
                if (occurrences.ContainsKey(word.ToLower()))
                    occurrences[word.ToLower()]++;
                else
                    occurrences.Add(word.ToLower(), 1);
            }

            foreach (var word in occurrences.Where(x => x.Value % 2 != 0))
                Console.Write(word.Key + " ");            
        }
    }
}
