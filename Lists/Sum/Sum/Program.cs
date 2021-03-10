using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int listLen = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < listLen; i++)
                numbers.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine(numbers.Sum());
        }
    }
}
