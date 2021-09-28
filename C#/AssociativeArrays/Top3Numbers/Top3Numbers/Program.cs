using System;
using System.Linq;

namespace Top3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(num => num)
                .Take(3)
                .ToList()
                .ForEach(el => Console.Write(el + " "));
        }
    }
}
