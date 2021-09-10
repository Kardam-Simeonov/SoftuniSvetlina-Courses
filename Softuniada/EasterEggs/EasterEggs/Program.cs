using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int descendingColors = rows;

            for (int i = 0; i < rows; i++)
            {
                Console.Write(new string(' ', i));
                for (int j = 1; j <= descendingColors; j++)
                    Console.Write(j);

                for (int j = descendingColors - 1; j >= 1; j--)
                    Console.Write(j);

                descendingColors--;
                Console.WriteLine();
            }
        }
    }
}
