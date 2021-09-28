using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (numbers.ContainsKey(input[i]))
                    numbers[input[i]]++;
                
                else
                    numbers.Add(input[i], 1);
                
            }

            foreach (var currentNum in numbers)
            {
                Console.WriteLine($"{currentNum.Key} -> {currentNum.Value}");
            }

        }
    }
}
