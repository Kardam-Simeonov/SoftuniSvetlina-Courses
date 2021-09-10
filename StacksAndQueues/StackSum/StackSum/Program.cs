using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numStack = new Stack<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (int num in input)
                numStack.Push(num);

            string[] command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        numStack.Push(int.Parse(command[1]));
                        numStack.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        if (int.Parse(command[1]) <= numStack.Count())
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            numStack.Pop();
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Sum: {numStack.Sum()}");
        }
    }
}
