using System;
using System.Collections.Generic;
using System.Linq;

namespace FindIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            string wordToAdd = Console.ReadLine();

            input.Add(wordToAdd);

            input = InsertionSort(input);

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == wordToAdd)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static List<string> InsertionSort(List<string> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                for (int k = i; k > 0; k--)
                {
                    if (String.Compare(arr[k - 1], arr[k]) > 0)
                        Swap(k - 1, k, arr);

                    else
                        break;
                }
            }

            return arr;
        }

        static void Swap(int toSwap, int swapWith, List<string> arr)
        {
            string temp = arr[toSwap];
            arr[toSwap] = arr[swapWith];
            arr[swapWith] = temp;
        }
    }
}
