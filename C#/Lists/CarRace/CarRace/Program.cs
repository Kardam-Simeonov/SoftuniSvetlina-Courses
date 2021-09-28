using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftSum = 0;
            double rightSum = 0;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    leftSum *= 0.8;
                }
                if (numbers[numbers.Count - 1 - i] == 0)
                {
                    rightSum *= 0.8;
                }

                leftSum += numbers[i];
                rightSum += numbers[numbers.Count - 1 - i];
            }
            if (leftSum < rightSum && Math.Floor(leftSum) == leftSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else if (leftSum < rightSum && Math.Floor(leftSum) != leftSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum:F1}");
            }
            else if (leftSum > rightSum && Math.Floor(rightSum) != rightSum)
            {
                Console.WriteLine($"The winner is right with total time: {rightSum:F1}");
            }
            else if (leftSum > rightSum && Math.Floor(rightSum) == rightSum)
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
