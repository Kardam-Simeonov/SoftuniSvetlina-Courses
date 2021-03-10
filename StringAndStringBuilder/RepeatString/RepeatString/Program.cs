using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            foreach (string word in arr)
            {
                foreach (char letter in word)
                {
                    Console.Write(word);
                }
            }
        }
    }
}
