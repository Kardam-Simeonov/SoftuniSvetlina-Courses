using System;
using System.Linq;

namespace SumMatrixColumns
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

            for (int i = 0; i < input[0]; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input[1]; j++)
                    matrix[i, j] = row[j];
            }

            for (int col = 0; col < input[1]; col++)
            {
                int colSum = 0;

                for (int row = 0; row < input[0]; row++)
                    colSum += matrix[row, col]; 
                
                Console.WriteLine(colSum);
            }
        }
    }
}
