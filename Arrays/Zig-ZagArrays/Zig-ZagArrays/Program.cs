using System;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];

            bool isFirstArray = true;

            for (int i = 0; i < n; i++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (isFirstArray)
                {
                    first[i] = currentArray[0];
                    second[i] = currentArray[1];
                }
                else
                {
                    first[i] = currentArray[1];
                    second[i] = currentArray[0];
                }

                isFirstArray = !isFirstArray;
            }

            Console.WriteLine(string.Join(' ', first));
            Console.WriteLine(string.Join(' ', second));
        }
    }
}
