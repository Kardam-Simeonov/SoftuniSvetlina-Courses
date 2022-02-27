using System;
using System.Linq;

namespace SpiralMatrix
{
    internal class Program
    {
        static int[,] matrix;

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            SpiralPrint(rows, columns);
        }

        static void SpiralPrint(int rows, int columns)
        {
            int i, startRow = 0, startColumn = 0;

            while (startRow < rows && startColumn < columns)
            {
                // Print the first row
                // from the remaining rows
                for (i = startColumn; i < columns; ++i)
                {
                    Console.Write(matrix[startRow, i] + " ");
                }
                startRow++;

                // Print the last column from the
                // remaining columns
                for (i = startRow; i < rows; ++i)
                {
                    Console.Write(matrix[i, columns - 1] + " ");
                }
                columns--;

                // Print the last row from
                // the remaining rows
                if (startRow < rows)
                {
                    for (i = columns - 1; i >= startColumn; --i)
                    {
                        Console.Write(matrix[rows - 1, i] + " ");
                    }
                    rows--;
                }

                // Print the first column from
                // the remaining columns
                if (startColumn < columns)
                {
                    for (i = rows - 1; i >= startRow; --i)
                    {
                        Console.Write(matrix[i, startColumn] + " ");
                    }
                    startColumn++;
                }
            }
        }

    }
}
