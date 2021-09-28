using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> table = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                foreach (string element in input)
                    table.Add(element);
            }

            foreach (var element in table.OrderBy(x => x))
                Console.Write($"{element} ");
        }
    }
}
