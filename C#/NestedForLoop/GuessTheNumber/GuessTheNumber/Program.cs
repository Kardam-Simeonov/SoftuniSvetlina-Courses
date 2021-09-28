using Microsoft.VisualBasic;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(1, 100);
            int tries = 1;

            while (true)
            {
                Console.Write("Guess: ");
                int input = int.Parse(Console.ReadLine());

                if (input == num)
                {
                    Console.WriteLine($"CORRECT");
                    Console.WriteLine($"Number of Tries: {tries}");
                    break;
                }
                else if (num > input)
                {
                    Console.WriteLine("Higher");
                    tries++;
                }
                else if (num < input)
                {
                    Console.WriteLine("Lower");
                    tries++;
                }
            }
        }
    }
}
