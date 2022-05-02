using System;
using System.Collections.Generic;

class ConnectedArea
{
    static int width;
    static int height;
    static char[,] matrix;

    static void Main()
    {
        ReadMatrix();
        int maxArea = 0;

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == '1')
                {
                    int area = FindArea(row, col);
                    if (area > maxArea)
                        maxArea = area;
                }
            }
        }

        Console.WriteLine($"The largest connected area of the matrix is: {maxArea}");
    }

    static void ReadMatrix()
    {
        height = int.Parse(Console.ReadLine());
        width = int.Parse(Console.ReadLine());
        
        matrix = new char[height, width];

        for (int row = 0; row < height; row++)
        {
            string inputRow = Console.ReadLine();

            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }
    }

    private static int FindArea(int row, int col)
    {
        if (row >= height || row < 0 || col >= width || col < 0)
            return 0;

        if (matrix[row, col] == '.')
            return 0;

        matrix[row, col] = '.';
        int area = 1;

        area += FindArea(row + 1, col);
        area += FindArea(row - 1, col);
        area += FindArea(row, col + 1);
        area += FindArea(row, col - 1);

        return area;
    }
}
