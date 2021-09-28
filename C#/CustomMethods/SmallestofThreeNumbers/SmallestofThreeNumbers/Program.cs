using System;

namespace SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintSmallest(num1, num2, num3);
        }

        static void PrintSmallest(int num1, int num2, int num3)
        {
            int smallest = int.MaxValue;

            smallest = num1;

            if (smallest > num2)
                smallest = num2;

            if (smallest > num3)
                smallest = num3;

            Console.WriteLine(smallest);
        }
    }
}
