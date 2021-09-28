using System;
using System.Linq;

namespace CountOfCharsAppearing
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            

            foreach(char letter in word)
            {
                if (word.Count(f => (f == letter))== 1)
                    Console.Write(letter + " ");
            }
        }
    }
}
