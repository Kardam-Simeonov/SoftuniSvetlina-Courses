using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            CheckSign(input);
        }

        static void CheckSign(int num)
        {
            if (num > 0)
                Console.WriteLine($"The number {num} is positive");
            else if (num < 0)
                Console.WriteLine($"The number {num} is negative");
            else if (num == 0)
                Console.WriteLine($"The number {num} is zero");
        }
    }
}
