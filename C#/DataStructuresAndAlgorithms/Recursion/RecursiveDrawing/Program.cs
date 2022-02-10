using System;

namespace RecursiveDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DrawFigure(int.Parse(Console.ReadLine())));
        }

        static string DrawFigure(int n)
        {
            string DrawTop(int n)
            {
                if (n == 1)
                    return "*";

                return $"{new string('*', n)}\n{DrawTop(n - 1)}";
            }

            string DrawBottom(int n, int current)
            {
                if (current == n)
                    return new string('#', current);

                return $"{new string('#', current)}\n{DrawBottom(n, current + 1)}";
            }

            return $"{DrawTop(n)}\n{DrawBottom(n, 1)}";
        }
    }
}
