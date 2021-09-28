using System;
using System.Linq;

namespace CondenseArrayToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToArray();



            while (numbers.Sum() != numbers[0])
            {
                for (int i = 0; i <= numbers.Length - count; i++)
                {
                    if (i != numbers.Length - count)
                        numbers[i] = numbers[i] + numbers[i + 1];
                    else
                        numbers[i] = 0;
                }

                count++;
            }

            Console.WriteLine(numbers[0]);

        }
    }
}
