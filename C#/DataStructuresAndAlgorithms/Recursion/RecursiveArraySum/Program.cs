using System;
using System.Linq;

namespace RecursiveArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(FindSum(arr, 0));
        }

        static int FindSum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
                return arr[index];

            return arr[index] + FindSum(arr, index + 1);
        }
    }
}
