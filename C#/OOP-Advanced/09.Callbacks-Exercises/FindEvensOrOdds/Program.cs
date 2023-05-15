using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Predicate<int> predicate = command == "even" ? new Predicate<int>(x => x % 2 == 0) : new Predicate<int>(x => x % 2 != 0);

            List<int> result = new List<int>();

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
