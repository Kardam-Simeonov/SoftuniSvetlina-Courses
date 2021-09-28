using System;

namespace PrintNumbersInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            Array.Reverse(numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
