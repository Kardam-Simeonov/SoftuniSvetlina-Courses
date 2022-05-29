using System;
using System.Linq;

namespace MatrixPath1to9
{
    internal class Program
    {
        static int[,] matrix;
        static bool isFirstSearch;

        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            ReadMatrix(height, width);

            bool pathExists = SearchPath(0, 0);

            if (pathExists)
                Console.WriteLine("Path 1..9 is found!");

            else
                Console.WriteLine("Path 1..9 is not found!");
        }

        private static bool SearchPath(int height, int width)
        {
            //down
            if (height != matrix.GetLength(0) - 1)
                if (SearchPathUtil(height + 1, width, matrix[height, width]))
                    return true;

            //right 
            if (width != matrix.GetLength(1))
                if (SearchPathUtil(height, width + 1, matrix[height, width]))
                    return true;

            //left
            if (width != 0)
                if (SearchPathUtil(height, width - 1, matrix[height, width]))
                    return true;

            //up
            if (height != 0)
                if (SearchPathUtil(height - 1, width, matrix[height, width]))
                    return true;

            return false;
        }

        private static bool SearchPathUtil(int height, int width, int prevValue)
        {
            if (matrix[height, width] != prevValue + 1)
                return false;

            if (matrix[height, width] == 9 && prevValue == 8)
                return true;

            //down
            if (height != matrix.GetLength(0) - 1)
                if (SearchPathUtil(height + 1, width, matrix[height, width]))
                    return true;

            //right 
            if (width != matrix.GetLength(1) - 1)
                if (SearchPathUtil(height, width + 1, matrix[height, width]))
                    return true;

            //left
            if (width != 0)
                if (SearchPathUtil(height, width - 1, matrix[height, width]))
                    return true;

            //up
            if (height != 0)
                if (SearchPathUtil(height - 1, width, matrix[height, width]))
                    return true;

            return false;
        }

        private static void ReadMatrix(int height, int width)
        {
            matrix = new int[height, width];
            isFirstSearch = true;

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
