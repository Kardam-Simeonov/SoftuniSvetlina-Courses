using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> predicate = new Predicate<int>(x => x % n == 0);

            List<int> result = new List<int>();

            input.Reverse();  
            foreach (int i in input)
            {
                if (!predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
