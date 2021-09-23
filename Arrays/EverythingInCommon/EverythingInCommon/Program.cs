using System;
using System.Linq;

namespace EverythingInCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("Arrays are not identical.");
                Console.WriteLine($"Found difference at {firstArray.Length - 1} index");
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("Arrays are not identical.");
                Console.WriteLine($"Found difference at {secondArray.Length - 1} index");
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("Arrays are not identical.");
                        Console.WriteLine($"Found difference at {i} index");
                        System.Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine("Arrays are identical.");
            Console.WriteLine($"Sum: {firstArray.Sum()}");
        }
    }
}
