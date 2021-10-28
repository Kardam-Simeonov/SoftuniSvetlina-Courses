using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Random rand = new Random();
            int originalCount = input.Count;

            for (int i = 0; i < originalCount; i++)
            {
                int randomIndex = rand.Next(0, input.Count);
                Console.WriteLine(input[randomIndex]);
                input.RemoveAt(randomIndex);
            }
        }
    }
}
