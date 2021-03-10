using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int i = 1; i <= num - 2; i++)
                Console.Write("- ");
            
            Console.WriteLine("+");

            for (int row = 1; row <= num - 2; row++)
            {
                Console.Write("| ");
                for (int i = 1; i <= num - 2; i++)
                    Console.Write("- ");

                Console.WriteLine("|");
            }

            Console.Write("+ ");
            for (int i = 1; i <= num - 2; i++)
                Console.Write("- ");

            Console.WriteLine("+");
        }
    }
}
