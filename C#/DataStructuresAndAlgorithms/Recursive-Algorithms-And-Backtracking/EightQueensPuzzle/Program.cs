using System;
using System.Collections.Generic;

namespace EightQueensPuzzle
{
    internal class Program
    {
        static bool[,] board = new bool[8, 8];
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        static void Main(string[] args)
        {
            PutQueens(0);
        }

        static void PutQueens(int row)
        {
            if (row == 8)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < 8; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkPositions(row, col);
                    }
                }
            }
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied =
                attackedRows.Contains(row) ||
                attackedColumns.Contains(col) ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRightDiagonals.Contains(col + row);

            return !positionOccupied;
        }
        private static void MarkPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(col + row);
            board[row, col] = true;
        }
        private static void UnmarkPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(col + row);
            board[row, col] = false;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (board[row, col])
                        Console.Write("* ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
