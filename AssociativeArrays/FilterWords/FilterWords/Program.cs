using System;
using System.Linq;

namespace FilterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(n => n.Length % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
