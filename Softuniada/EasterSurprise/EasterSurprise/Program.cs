using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterSurprise
{
    class Program
    {
        static string[][] boxMatrix;
        static string symbolFound;
        static string symbolMark;
        static int currentRow;
        static int currentCol;
        static Stack<Tuple<int, int>> traveledPath = new Stack<Tuple<int, int>>();
        static void Main(string[] args)
        {
            Init();

            while (Search())
            {
            }

            for (int i = 0; i < boxMatrix.Length; i++)
            {
                Console.WriteLine(String.Join("", boxMatrix[i]));
            }
            
        }
        static bool Search()
        {
            if (currentRow != 0 && boxMatrix[currentRow - 1][currentCol] == symbolMark)
            {
                traveledPath.Push(new Tuple<int, int>(currentRow, currentCol));

                currentRow--;
                boxMatrix[currentRow][currentCol] = symbolFound;
                return true;
            }

            else if (currentCol != boxMatrix[currentRow].Length - 1 && boxMatrix[currentRow][currentCol + 1] == symbolMark)
            {
                traveledPath.Push(new Tuple<int, int>(currentRow, currentCol));

                currentCol++;
                boxMatrix[currentRow][currentCol] = symbolFound;
                return true;
            }

            else if (currentRow != boxMatrix.Length - 1 && boxMatrix[currentRow + 1][currentCol] == symbolMark)
            {
                traveledPath.Push(new Tuple<int, int>(currentRow, currentCol));

                currentRow++;
                boxMatrix[currentRow][currentCol] = symbolFound;
                return true;
            }

            else if (currentCol != 0 && boxMatrix[currentRow][currentCol - 1] == symbolMark)
            {
                traveledPath.Push(new Tuple<int, int>(currentRow, currentCol));

                currentCol--;
                boxMatrix[currentRow][currentCol] = symbolFound;
                return true;
            }
            else if (traveledPath.Count() != 0)
            {
                var previousCoordinates = traveledPath.Pop();
                currentRow = previousCoordinates.Item1;
                currentCol = previousCoordinates.Item2;
                return true;
            }

            return false;
        }
        static void Init()
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            boxMatrix = new string[rows][];

            for (int row = 0; row < boxMatrix.Length; row++)
            {
                boxMatrix[row] = new string[cols];
                string[] inputRow = Console.ReadLine().Split();

                for (int col = 0; col < boxMatrix[row].Length; col++)
                {
                    boxMatrix[row][col] = inputRow[col];
                }
            }

            symbolFound = Console.ReadLine();
            int[] initialSymbol = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            currentRow = initialSymbol[0];
            currentCol = initialSymbol[1];

            symbolMark = boxMatrix[currentRow][currentCol];
            boxMatrix[currentRow][currentCol] = symbolFound;
        }
    }
}
