using System;
using System.Linq;

namespace MaximalSum3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[input[0], input[1]];
            int[,] highestSubMatrix = new int[3, 3];
            long largestSum = long.MinValue;

            for (int i = 0; i < input[0]; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input[1]; j++)
                    matrix[i, j] = row[j];
            }

            for (int row = 0; row < input[0] - 2; row++)
            {
                for (int col = 0; col < input[1] - 2; col++)
                {
                    int[,] currentSubMatrix = SubMatrix(matrix, row, col);
                    long currentSum = 0;

                    foreach (int num in currentSubMatrix)
                        currentSum += num;

                    if (currentSum > largestSum)
                    {
                        largestSum = currentSum;
                        highestSubMatrix = currentSubMatrix;
                    }
                }
            }

            Console.WriteLine($"Sum = {largestSum}");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{highestSubMatrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] SubMatrix(int[,] matrix, int row, int col)
        {
            int[,] subMatrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    subMatrix[i, j] = matrix[row + i, col + j];
                }
            }

            return subMatrix;
        }
    }
}
