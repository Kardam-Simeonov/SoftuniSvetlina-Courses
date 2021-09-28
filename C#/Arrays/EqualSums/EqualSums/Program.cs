using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int l = i - 1; l >= 0; l--)
                    leftSum += numbers[l];

                for (int r = i + 1; r < numbers.Length; r++)
                    rightSum += numbers[r];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("no");
        }
    }
}
