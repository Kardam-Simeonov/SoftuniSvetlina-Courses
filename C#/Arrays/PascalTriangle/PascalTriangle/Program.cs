using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstLastElement = 1;
         

            int[] previousRow = new int[n];
            previousRow[0] = firstLastElement;

            for (int row = 1; row <= n; row++)
            {
                int[] currentRow = new int[row];
                currentRow[0] = firstLastElement;
                currentRow[currentRow.Length - 1] = firstLastElement;

                for (int i = 1; i < currentRow.Length - 1; i++)
                {
                    currentRow[i] = previousRow[i] + previousRow[i - 1];
                }

                previousRow = currentRow;
                Console.WriteLine(string.Join(' ', currentRow));
            }
        }
    }
}
