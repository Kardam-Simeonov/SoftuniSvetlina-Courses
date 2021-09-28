using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diagonalSum = 0;

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                    matrix[i, j] = row[j];
            }

            for (int pos = 0; pos < n; pos++)
            {
                diagonalSum += matrix[pos, pos];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
