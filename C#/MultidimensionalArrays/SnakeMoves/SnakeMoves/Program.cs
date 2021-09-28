using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            int snakePointer = 0;

            char[][] snakePath = new char[input[0]][];

            for (int row = 0; row < input[0]; row++)
            {
                snakePath[row] = new char[input[1]];
                for (int col = 0; col < input[1]; col++)
                {
                    snakePath[row][col] = snake[snakePointer];

                    if (snakePointer == snake.Length - 1)
                        snakePointer = 0;
                    else
                        snakePointer++;
                }

                if (row % 2 != 0)
                    snakePath[row] = snakePath[row].Reverse().ToArray();
            }

            for (int i = 0; i < input[0]; i++)
            {
                for (int j = 0; j < input[1]; j++)
                {
                    Console.Write(snakePath[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
