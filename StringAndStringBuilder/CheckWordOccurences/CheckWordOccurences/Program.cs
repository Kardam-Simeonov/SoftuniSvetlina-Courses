using System;

namespace CheckWordOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string keyword = "the";

            string[] words = input.Split();
            int matches = 0;

            foreach (string word in words)
            {
                if (word == keyword)
                    matches++;
            }

            Console.WriteLine(matches);
        }
    }
}
