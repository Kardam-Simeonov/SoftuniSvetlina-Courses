using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToArray();

            int[] arrayTwo = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToArray();

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    System.Environment.Exit(0);
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {arrayOne.Sum()}");
        }
    }
}
