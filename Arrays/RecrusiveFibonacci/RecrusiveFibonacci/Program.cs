using System;

namespace RecrusiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[num];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < num; i++)
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

            Console.WriteLine(fibonacci[fibonacci.Length - 1]);
        }
    }
}
