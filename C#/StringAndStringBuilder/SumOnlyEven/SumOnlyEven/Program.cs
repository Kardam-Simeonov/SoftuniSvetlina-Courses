using System;
using System.Linq;

namespace SumOnlyEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();
            int evenSum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenSum += num;
            }

            Console.WriteLine(evenSum);
        }
    }
}
