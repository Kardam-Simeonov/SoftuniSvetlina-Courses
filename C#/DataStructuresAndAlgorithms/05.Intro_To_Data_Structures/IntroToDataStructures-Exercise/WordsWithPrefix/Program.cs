using rm.Trie;
using System;

namespace WordsWithPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string prefix = Console.ReadLine();

            foreach (string word in input)
            {
                trie.AddWord(word);
            }

            Console.WriteLine(trie.Count());
            Console.WriteLine(trie.UniqueCount());
            Console.WriteLine(string.Join(", ", trie.GetWords()));
            Console.WriteLine(string.Join(", ", trie.GetWords(prefix)));
            trie.RemovePrefix(prefix);
            Console.WriteLine(string.Join(", ", trie.GetWords()));           
        }
    }
}
