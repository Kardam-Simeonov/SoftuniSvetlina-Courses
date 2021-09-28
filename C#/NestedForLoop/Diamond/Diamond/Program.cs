using System;
using System.Runtime.InteropServices.ComTypes;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string ('-', (n / 2) - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', 2*i));
                Console.Write("*");
                Console.WriteLine(new string('-', (n / 2) - 1 - i));
            }

            for (int i = n / 2 - 2; i >= 0; i--)
            {
                Console.Write(new string('-', (n / 2) - 1 - i));
                Console.Write("*");
                Console.Write(new string('-', 2 * i));
                Console.Write("*");
                Console.WriteLine(new string('-', (n / 2) - 1 - i));
            }


        }
    }
}
