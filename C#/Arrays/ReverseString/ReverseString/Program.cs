using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            input = input.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
