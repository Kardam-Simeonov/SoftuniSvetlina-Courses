using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[input[0], input[1]];
            int equalInstances = 0;


            for (int i = 0; i < input[0]; i++)
            {
                char[] row = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int j = 0; j < input[1]; j++)
                    matrix[i, j] = row[j];
            }

            for (int row = 0; row < input[0] - 1; row++)
            {
                for (int col = 0; col < input[1] - 1; col++)
                {
                    char currentChar = matrix[row, col];

                    if (matrix[row + 1, col] == currentChar && matrix[row, col + 1] == currentChar && matrix[row + 1, col + 1] == currentChar) //May the gods have mercy on my soul
                        equalInstances++;
                }
            }

            Console.WriteLine(equalInstances);
        }
    }
}
