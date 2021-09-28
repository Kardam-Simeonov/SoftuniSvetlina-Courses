using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numQueue = new Queue<int>(input);
            int len = numQueue.Count();

            for (int i = 0; i < len; i++)
            {
                if (numQueue.Peek() % 2 != 0)
                {
                    numQueue.Dequeue();
                }
                else
                {
                    int evenNum = numQueue.Dequeue();
                    numQueue.Enqueue(evenNum);
                }
            }

            Console.WriteLine(String.Join(", ", numQueue));
        }
    }
}
