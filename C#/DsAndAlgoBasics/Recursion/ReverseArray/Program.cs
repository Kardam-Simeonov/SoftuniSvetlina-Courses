using System;
using System.Linq;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(ReverseArray(arr, arr.Length - 1));
        }

        static string ReverseArray(int[] arr, int index)
        {
            if (index == 0)
                return $"{arr[index]}";

            return $"{arr[index]} {ReverseArray(arr, index - 1)}";
        }
    }
}
