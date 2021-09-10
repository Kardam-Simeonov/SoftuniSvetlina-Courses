using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> isleQueue = new Queue<string>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (isleQueue.Count > 0)
                    {
                        Console.WriteLine(isleQueue.Dequeue());
                    }
                }
                else
                {
                    isleQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{isleQueue.Count} people remaining.");
        }
    }
}
