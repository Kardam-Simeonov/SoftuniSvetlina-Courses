using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(Sum(a,b), c));
        }

        static int Sum (int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static int Subtract (int sum, int c)
        {
            int result = sum - c;
            return result;
        }
    }
}
