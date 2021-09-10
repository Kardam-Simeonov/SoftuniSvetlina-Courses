using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = input[1];
            int x = input[2];

            Queue<int> numQueue = new Queue<int>();

            List<int> enqueNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            enqueNums.ForEach(x => numQueue.Enqueue(x));

            for (int i = 0; i < m; i++)
            {
                numQueue.Dequeue();
            }

            if (numQueue.Count() > 0)
                if (numQueue.Contains(x))
                    Console.WriteLine("true");
                else
                    Console.WriteLine(numQueue.Min());
            else
                Console.WriteLine(0);
        }
    }
}
