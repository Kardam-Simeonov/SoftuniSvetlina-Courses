using System;
using System.Linq;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(String.Join(" ", InsertionSort(arr)));
        }

        static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    if (arr[k - 1] > arr[k])
                        Swap(ref arr[k - 1], ref arr[k]);

                    else
                        break;
                }
            }

            return arr;
        }

        static void Swap(ref int toSwap, ref int swapWith)
        {
            int temp = toSwap;
            toSwap = swapWith;
            swapWith = temp;
        }
    }
}
