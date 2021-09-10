using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> boxOfClothes = new Stack<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (int item in input.Reverse())
                boxOfClothes.Push(item);

            int rackCapacity = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int rackCount = 1;

            while (boxOfClothes.Count > 0)
            {
                if (currentSum + boxOfClothes.Peek() <= rackCapacity)
                {
                    currentSum += boxOfClothes.Pop();
                }
                else
                {
                    currentSum = boxOfClothes.Pop();
                    rackCount++;
                }  
            }

            Console.WriteLine(rackCount);
        }
    }
}
