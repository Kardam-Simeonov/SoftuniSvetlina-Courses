using System;
using System.Linq;

namespace MatrixPath
{
    internal class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            ReadMatrix(height, width);

            bool pathExists = SearchPath(0, 0, matrix[0, 0]);

            if (pathExists)
                Console.WriteLine("There is a path!");

            else
                Console.WriteLine("No path!");
        }

        private static bool SearchPath(int height, int width, int prevValue)
        {
            if (height + width != 0)
                if (matrix[height, width] <= prevValue)
                    return false;

            if (height == matrix.GetLength(0) - 1)
                return true;

            if (width != 0)
                if (SearchPath(height + 1, width - 1, matrix[height, width]))
                    return true;

            if (SearchPath(height + 1, width, matrix[height, width]))
                return true;

            if (width != matrix.GetLength(1) - 1)
                if (SearchPath(height + 1, width + 1, matrix[height, width]))
                    return true;

            return false;
        }

        private static void ReadMatrix(int height, int width)
        {
            matrix = new int[height, width];

            for (int row = 0; row < height; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
