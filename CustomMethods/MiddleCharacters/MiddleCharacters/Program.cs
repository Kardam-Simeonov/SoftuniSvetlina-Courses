using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }

        static void PrintMiddleChar(string input)
        {
            if (input.Length % 2 != 0)
                Console.WriteLine(input[input.Length / 2]);
            else
            {
                Console.Write($"{input[(input.Length / 2) - 1]}{input[input.Length / 2]}");
                
            }
        }
    }
}
