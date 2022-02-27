using System;

namespace CoffeeCups
{
    internal class Program
    {
        static int width;
        static int height;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            width = 3 * n + 6;
            height = 3 * n + 1;

            DrawFoam(n);
            DrawTop(n, name);
            DrawBottom(n, name);
        }

        private static void DrawBottom(int n, string name)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', i));
                Console.WriteLine($"\\{new string('@', (n * 2 + name.Length) - 2 * i)}/");
            }
            Console.WriteLine(new string('-', width - 1));
        }

        static void DrawTop(int n, string name)
        {
            Console.WriteLine(new string('=', width - 1));

            for (int i = 0; i < (n - 2) / 2; i++)

                Console.WriteLine($"|{new string('~', width - 2 - n)}|{new string(' ', (width - 1) - (2 * n + name.Length + 2))}|");
           

            Console.WriteLine($"|{new string('~', n)}{name.ToUpper()}{new string('~', n)}|{new string(' ', (width - 1) - (2 * n + name.Length + 2))}|");

            for (int i = 0; i < (n - 3) / 2; i++)
                Console.WriteLine($"|{new string('~', width - 2 - n)}|{new string(' ', (width - 1) - (2 * n + name.Length + 2))}|");
            

            Console.WriteLine(new string('=', width - 1));
        }

        static void DrawFoam(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n));
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("~ ");
                }
                Console.WriteLine();
            }
        }
    }
}
