using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            foreach (double num in input)
            {
                if (occurrences.ContainsKey(num))
                    occurrences[num]++;
                else
                    occurrences.Add(num, 1);
            }

            foreach (var num in occurrences)
                Console.WriteLine($"{num.Key} - {num.Value} times");
        }
    }
}
