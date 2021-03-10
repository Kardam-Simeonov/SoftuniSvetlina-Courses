using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArrays = Console.ReadLine()
                .Split()
                .ToArray();

            string[] secondArrays = Console.ReadLine()
                .Split()
                .ToArray();


            string[] result = secondArrays.Intersect(firstArrays).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }

    }
}
