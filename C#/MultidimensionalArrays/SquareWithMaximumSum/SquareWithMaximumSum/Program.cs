using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[input[0], input[1]];
            int[,] subMatrix = new int[2, 2];
            int largestSum = int.MinValue;

            for (int i = 0; i < input[0]; i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < input[1]; j++)
                    matrix[i, j] = row[j];
            }

            for (int row = 0; row < input[0] - 1; row++)
            {
                for (int col = 0; col < input[1] - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currentSum > largestSum)
                    {
                        largestSum = currentSum;
                        subMatrix[0, 0] = matrix[row, col];
                        subMatrix[0, 1] = matrix[row, col + 1];
                        subMatrix[1, 0] = matrix[row + 1, col];
                        subMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{subMatrix[0, 0]} {subMatrix[0, 1]}\n{subMatrix[1, 0]} {subMatrix[1, 1]}");
            Console.WriteLine(largestSum);
        }
    }
}
