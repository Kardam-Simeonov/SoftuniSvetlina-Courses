using System;

namespace EqualSumsLeftRightPosition
{
    class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int fifthNum = i % 10;
                int fourthNum = (i / 10) % 10;
                int thirdNum = (i / 100) % 10;
                int secondNum = (i / 1000) % 10;
                int firstNum = (i / 10000) % 10;
                int leftSum = firstNum + secondNum;
                int rightsum = fourthNum + fifthNum;

                if (leftSum == rightsum)
                    Console.Write(i + " ");

                else if (Math.Min(leftSum, rightsum) + thirdNum == Math.Max(leftSum, rightsum))
                    Console.Write(i + " ");
            }
        }
    }
}
