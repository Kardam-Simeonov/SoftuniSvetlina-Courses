using System;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string lastWord = Console.ReadLine();

            firstWord = firstWord.ToLower();
            lastWord = lastWord.ToLower();

            if (firstWord == lastWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
