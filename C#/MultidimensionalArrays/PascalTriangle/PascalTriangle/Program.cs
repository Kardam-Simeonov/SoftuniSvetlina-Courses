using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 1)
                Environment.Exit(0);

            long[,] matrix = new long[n, n];

            matrix[0, 0] = 1;

            for (int row = 1; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    long leftNum = 0;
                    long rightNum = matrix[row - 1, col];

                    try
                    {
                        leftNum = matrix[row - 1, col - 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                    }

                    matrix[row, col] = leftNum + rightNum;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
