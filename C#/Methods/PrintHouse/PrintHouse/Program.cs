using System;
using System.Runtime.InteropServices;

namespace PrintHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine($"{n} is invalid number");
                System.Environment.Exit(0);
            }
            PrintTop(n);
            PrintFoot(n);
        }

        static void PrintTop(int n)
        {
            if (n % 2 == 0)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int i = 0; i <= n - row; i++)
                        Console.Write(' ');

                    for (int col = 1; col <= row; col++)
                        Console.Write("**");

                    Console.WriteLine();

                }
            }

            else if (n % 2 != 0)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int i = 0; i <= n - row; i++)
                        Console.Write(' ');

                    for (int col = 1; col <= row; col++)
                    {
                        if (col == 1)
                            Console.Write("*");
                        else
                            Console.Write("**");
                    }

                    Console.WriteLine();

                }
            }
        }

        static void PrintFoot(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                Console.Write("  ");
                Console.Write("|");

                if (n % 2 == 0)
                    for (int col = 1; col <= n * 2 - 4; col++)
                        Console.Write("*");
                else
                    for (int col = 1; col <= n * 2 - 5; col++)
                        Console.Write("*");

                Console.WriteLine("|");
            }
        }
    }
}
