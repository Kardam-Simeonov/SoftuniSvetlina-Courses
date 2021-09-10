using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                matrix.Add(input.ToList());
            }

            for (int row = 0; row < matrix.Count() - 1; row++)
            {
                if (matrix[row].Count() == matrix[row + 1].Count())
                {
                    for (int i = 0; i < matrix[row].Count; i++)
                        matrix[row][i] *= 2;

                    for (int i = 0; i < matrix[row + 1].Count; i++)
                        matrix[row + 1][i] *= 2;
                }
                else
                {
                    for (int i = 0; i < matrix[row].Count; i++)
                        matrix[row][i] /= 2;

                    for (int i = 0; i < matrix[row + 1].Count; i++)
                        matrix[row + 1][i] /= 2;
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                switch (command[0])
                {
                    case "Add":
                        try
                        {
                            matrix[row][col] += int.Parse(command[3]);
                        }
                        catch (System.Exception)
                        {
                        }
                        break;
                    case "Subtract":
                        try
                        {
                            matrix[row][col] -= int.Parse(command[3]);
                        }
                        catch (System.Exception)
                        {
                        }
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }

            for (int row = 0; row < matrix.Count; row++)
            {
                matrix[row].ForEach(x => Console.Write($"{x} "));
                Console.WriteLine();
            }
        }
    }
}
