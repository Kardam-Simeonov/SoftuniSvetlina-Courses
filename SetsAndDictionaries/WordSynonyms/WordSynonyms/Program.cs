using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonyms.ContainsKey(word))
                    synonyms[word].Add(synonym);
                else
                    synonyms.Add(word, new List<string>() { synonym });
            }

            foreach (var word in synonyms)
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
        }
    }
}
