using System;
using System.Linq;

namespace SomethingInCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            Console.WriteLine(String.Join(" ", arrTwo.Intersect(arrOne)));
        }
    }
}
