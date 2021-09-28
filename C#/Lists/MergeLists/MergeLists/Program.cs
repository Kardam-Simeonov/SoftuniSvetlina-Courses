using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> mergedList = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    mergedList.Add(firstList[i]);
                    mergedList.Add(secondList[i]);
                }
                for (int i = secondList.Count; i < firstList.Count; i++)
                    mergedList.Add(firstList[i]);
            }
            else
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    mergedList.Add(firstList[i]);
                    mergedList.Add(secondList[i]);
                }
                for (int i = firstList.Count; i < secondList.Count; i++)
                    mergedList.Add(secondList[i]);
            }

            Console.WriteLine(String.Join(' ', mergedList));
        }
    }
}
