using System;
using System.Linq;

namespace SortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(String.Join(' ', Sort(arr)));
        }

        static int[] Sort(int[] arr)
        {
            int len = arr.Length - 1;

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                else
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
