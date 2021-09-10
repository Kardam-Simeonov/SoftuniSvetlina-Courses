using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> actionHistory = new Stack<string>();
            StringBuilder currentString = new StringBuilder();
            actionHistory.Push(currentString.ToString());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "1":
                        currentString.Append(input[1]);
                        actionHistory.Push(currentString.ToString());
                        break;
                    case "2":
                        currentString.Remove(currentString.Length - int.Parse(input[1]), int.Parse(input[1]));
                        actionHistory.Push(currentString.ToString());
                        break;
                    case "3":
                        Console.WriteLine(currentString[int.Parse(input[1]) - 1]);
                        break;
                    case "4":
                        if (actionHistory.Count() > 0)
                        {
                            actionHistory.Pop();
                            currentString = new StringBuilder().Append(actionHistory.Peek());
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
