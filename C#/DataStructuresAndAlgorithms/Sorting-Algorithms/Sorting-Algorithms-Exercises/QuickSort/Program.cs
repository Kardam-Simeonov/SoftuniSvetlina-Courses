using System;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(String.Join(" ", QuickSort.Sort(arr)));
        }
    }

    public class QuickSort
    {
        public static int[] Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void Sort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
                return;

            int pivot = Partition(arr, leftIndex, rightIndex);
            Sort(arr, leftIndex, pivot - 1);
            Sort(arr, pivot + 1, rightIndex);
        }

        private static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
                return leftIndex;

            int i = leftIndex;
            int j = rightIndex + 1;

            while (true)
            {
                while (arr[++i] < arr[leftIndex])
                    if (i == rightIndex)
                        break;

                while (arr[leftIndex] < arr[--j])
                    if (j == leftIndex)
                        break;

                if (i >= j)
                    break;

                Swap(ref arr, i, j);
            }

            Swap(ref arr, leftIndex, j);

            return j;
        }

        static void Swap(ref int[] arr, int toSwap, int swapWith)
        {
            int temp = arr[toSwap];
            arr[toSwap] = arr[swapWith];
            arr[swapWith] = temp;
        }
    }
}
