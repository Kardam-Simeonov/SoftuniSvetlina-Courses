using System;
using System.Linq;

namespace SumMatrixElements
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
            int sum = 0;

            for (int i = 0; i < input[0]; i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < input[1]; j++)
                    matrix[i, j] = row[j];
            }

            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);

            foreach (var row in matrix)
                sum += row;

            Console.WriteLine(sum);
        }
    }
}
