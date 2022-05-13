using System;

namespace ShuffleWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            foreach (string word in FisherYates(words))
            {
                Console.WriteLine(word);
            }
        }

        static string[] FisherYates(string[] words)
        {
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int j = random.Next(i, words.Length);

                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }

            return words;
        }
    }
}
