using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int upperSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length - (i + arr.Length - i))
            }
        }
    }
}
