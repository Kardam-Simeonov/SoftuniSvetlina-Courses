using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openingBrackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    openingBrackets.Push(i);

                else if (input[i] == ')')
                {
                    for (int j = openingBrackets.Pop(); j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
