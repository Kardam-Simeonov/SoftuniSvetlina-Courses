using System;
using System.Collections.Generic;
using System.Linq;

namespace Needles
{
    public class Needles
    {
        public static void Main()
        {
            int[] length = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] needles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int previous = numbers[length[0] - 1];

            for (int i = length[0] - 1; i >= 0; i--)
            {
                if (numbers[i] == 0)
                {
                    numbers[i] = previous;
                }
                previous = numbers[i];
            }

            List<int> result = new List<int>();

            for (int i = 0; i < length[1]; i++)
            {
                bool isIndex = false;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[j] >= needles[i])
                    {
                        result.Add(j);
                        isIndex = true;
                        break;
                    }
                }
                if (!isIndex)
                {
                    int index = numbers.Count - 1;

                    while (index > 0 && numbers[index] == 0)
                    {
                        index--;
                    }
                    if (numbers[index] == 0)
                    {
                        index--;
                    }
                    result.Add(index + 1);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }


    /*
    internal class Program
    {
        static int[] arr;
        static List<KeyValuePair<int, int>> needles;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            arr = new int[input.Length];
            Array.Copy(input, arr, input.Length);

            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            needles = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < input.Length; i++)
                needles.Add(new KeyValuePair<int, int>(input[i], -1));

            FitNeedles();
            Console.WriteLine(String.Join(" ", needles.Select(x => x.Value)));
        }

        static void FitNeedles()
        {
            for (int i = 0; i < needles.Count; i++)
            {
                if (arr[0] >= needles[i].Key)
                {
                    needles[i] = new KeyValuePair<int, int>(needles[i].Key, 0);
                }
                else
                {
                    for (int j = 1; j < arr.Length; j++)
                    {
                        if (arr[j - 1] != 0)
                        {
                            int current = arr[j];

                            if (arr[j] == 0)
                            {
                                for (int k = j; k < arr.Length; k++)
                                {
                                    if (arr[k] != 0)
                                    {
                                        current = arr[k];
                                        break;
                                    }
                                }
                            }
                            if (arr[j - 1] <= needles[i].Key && needles[i].Key <= current)
                            {
                                needles[i] = new KeyValuePair<int, int>(needles[i].Key, j);
                                break;
                            }
                        }
                    }

                    if (needles[i].Value == -1 && arr[arr.Length - 1] <= needles[i].Key)
                        needles[i] = new KeyValuePair<int, int>(needles[i].Key, arr.Length);
                }
            }
        }
    }
    */
}