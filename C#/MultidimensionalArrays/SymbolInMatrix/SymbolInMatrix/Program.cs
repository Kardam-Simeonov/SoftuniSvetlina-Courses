using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool exists = false;

            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < n; j++)
                    matrix[i, j] = row[j];
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        exists = true;
                        Console.WriteLine($"({row}, {col})");
                    }
                }
            }

            if (!exists)
                Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
