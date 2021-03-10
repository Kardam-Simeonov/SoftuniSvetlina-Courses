using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToArray();

            foreach(int i in numbers)
                sum += i % 2 == 0 ? i : 0;

            Console.WriteLine(sum);
        }
    }
}
