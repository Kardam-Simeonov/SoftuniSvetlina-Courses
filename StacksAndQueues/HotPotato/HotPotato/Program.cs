using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(input);

            while (children.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        string removedChild = children.Dequeue();
                        Console.WriteLine($"Removed {removedChild}");
                    }
                    else
                    {
                        string current = children.Dequeue();
                        children.Enqueue(current);
                    }
                }
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
