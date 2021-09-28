using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                    matrix[i, j] = row[j];
            }

            string[] command = Console.ReadLine().Split();

            while(command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                switch (command[0])
                {
                    case "Add":
                        if ((row > n - 1 || col > n - 1) || (row < 0 || col < 0))
                            Console.WriteLine("Invalid coordinates");
                        else
                            matrix[row, col] += int.Parse(command[3]);
                        break;
                    case "Subtract":
                        if ((row > n - 1 || col > n - 1) || (row < 0 || col < 0))
                            Console.WriteLine("Invalid coordinates");
                        else
                            matrix[row, col] -= int.Parse(command[3]);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
