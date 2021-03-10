using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToArray();

            foreach (int i in numbers)
                result += i % 2 == 0 ? i : -i;

            Console.WriteLine(result);
        }
    }
}
