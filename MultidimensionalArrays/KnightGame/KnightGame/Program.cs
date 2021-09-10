using System;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int knightEliminations = 0;

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                    matrix[row, col] = input[col];
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'K')
                    {
                        try
                        {
                            if (matrix[row - 2, col + 1] == 'K')                  
                            {
                                matrix[row - 2, col + 1] = '0';
                                knightEliminations++;
                            }
                        }
                        catch(IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            if (matrix[row - 2, col - 1] == 'K')
                            {
                                matrix[row - 2, col - 1] = '0';
                                knightEliminations++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            if (matrix[row + 2, col + 1] == 'K')
                            {
                                matrix[row + 2, col + 1] = '0';
                                knightEliminations++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            if (matrix[row + 2, col - 1] == 'K')
                            {
                                matrix[row + 2, col - 1] = '0';
                                knightEliminations++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            if (matrix[row + 1, col + 2] == 'K')
                            {
                                matrix[row + 1, col + 2] = '0';
                                knightEliminations++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            if (matrix[row - 1, col + 2] == 'K')
                            {
                                matrix[row - 1, col + 2] = '0';
                                knightEliminations++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        try
                        {
                            if (matrix[row + 1, col - 2] == 'K')
                            {
                                matrix[row + 1, col - 2] = '0';
                                knightEliminations++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {

                        }
                        try
                        {
                            if (matrix[row - 1, col - 2] == 'K')
                            {
                                matrix[row - 1, col - 2] = '0';
                                knightEliminations++;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                    }
                }
            }
            Console.WriteLine(knightEliminations);
        }

    }
}
