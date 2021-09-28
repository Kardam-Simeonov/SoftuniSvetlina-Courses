using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingParanthesses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openingBrackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    openingBrackets.Push(input[i]);
                }

                if (input[i] == '}' || input[i] == ')' || input[i] == ']')
                {
                    if (openingBrackets.Count() <= 0)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                    if (input[i] == '}' && openingBrackets.Peek() == '{' || input[i] == ')' && openingBrackets.Peek() == '(' || input[i] == ']' && openingBrackets.Peek() == '[')
                    {
                        openingBrackets.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }    
                }
            }

            Console.WriteLine("YES");
        }
    }
}
