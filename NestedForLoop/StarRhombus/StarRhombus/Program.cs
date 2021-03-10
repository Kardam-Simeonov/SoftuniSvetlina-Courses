using System;

namespace StarRhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                for (int i = 0; i <= input - row; i++)
                    Console.Write(' ');

                for (int col = 1; col <= row; col++)
                    Console.Write("* ");

                Console.WriteLine();

            }

            for (int row = input - 1; row >= 1; row--)
            {
                for (int i = 1; i <= input - row + 1; i++)
                    Console.Write(' ');

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");

                    if (col == row)
                        Console.WriteLine();
                }
            }

        }
    }
}
