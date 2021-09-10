using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> inputStack = new Stack<string>();


            for (int i = input.Length - 1; i >= 0; i--)
                inputStack.Push(input[i]);

            int result = int.Parse(inputStack.Pop());

            while (inputStack.Count() > 0)
            {
                string numOperator = inputStack.Pop();
                int num = int.Parse(inputStack.Pop());

                if (numOperator == "+")
                    result += num;
                else
                    result -= num;
            }

            Console.WriteLine(result);
        }
    }
}
