using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (int num in numbers)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts.Add(num, 1);
            }

            foreach (var num in counts)
                Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}
