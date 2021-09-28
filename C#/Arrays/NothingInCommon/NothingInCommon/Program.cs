using System;
using System.Collections.Generic;
using System.Linq;

namespace NothingInCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Tuple<int, int>> valuePairs = new HashSet<Tuple<int, int>>();

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
                for (int n = i + 1; n < arr.Length; n++)
                    if (arr[i] + arr[n] == sum)
                        valuePairs.Add(new Tuple<int, int> (arr[i], arr[n] ));

            foreach (var pair in valuePairs)
                Console.WriteLine($"{pair.Item1} {pair.Item2}");
        }
    }
}
