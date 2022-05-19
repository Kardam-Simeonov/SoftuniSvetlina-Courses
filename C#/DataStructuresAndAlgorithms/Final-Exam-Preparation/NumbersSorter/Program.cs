using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new long[3];

            for (int i = 0; i < 3; i++)
                nums[i] = long.Parse(Console.ReadLine());

            BubbleSort(ref nums);

            foreach (var num in nums)
                Console.WriteLine(num);
        }

        static void BubbleSort(ref long[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[j - 1] < nums[j])
                        Swap(nums, j - 1, j);
                }
            }
        }

        private static void Swap(long[] nums, long a, long b)
        {
            long temp = nums[a];
            
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
