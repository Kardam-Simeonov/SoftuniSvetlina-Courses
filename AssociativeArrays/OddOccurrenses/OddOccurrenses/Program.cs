using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrenses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string item in words)
            {
                string word = item.ToLower();

                if (counts.ContainsKey(word))
                    counts[word]++;
                else
                    counts.Add(word, 1);
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                    Console.Write(count.Key + " ");
            }
        }
    }
}
