using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintMatrix(num);
        }

        static void PrintMatrix(int num)
        {
            for (int col = 1; col <= num; col++)
            {
                for (int row = 1; row <= num; row++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
