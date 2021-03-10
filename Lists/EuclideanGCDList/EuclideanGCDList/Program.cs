using System;
using System.Collections.Generic;

namespace EuclideanGCDList
{
    class Program
    {
        static void Main(string[] args)
        {
            int listLen = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>(listLen);

            for (int i = 0; i < listLen; i++)
                numbers.Add(int.Parse(Console.ReadLine()));

            for (int i = 0; i < numbers.Count; i++)
            {
                if (isPower(k, numbers[i]) == false)
                    numbers.RemoveAt(i);
            }

            FindGCD(numbers);
        }

        public static bool isPower(int k, int currentNum)
        {
            if (k == 1)
                return (currentNum == 1);

            int pow = 1;

            while (pow < currentNum)
                pow = pow * k;

            return (pow == currentNum);
        }

        public static void FindGCD(List<int> numbers)
        {
            int currentGCD = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int a = numbers[i];
                int b = numbers[i + 1];

                while (a != b)
                {
                    if (a > b)
                        a = a - b;

                    else
                        b = b - a;
                }

                if (i == 0)
                    currentGCD = a;

                else if (currentGCD > a)
                    currentGCD = a;
            }


            Console.WriteLine(currentGCD);
            Console.WriteLine(String.Join(' ', numbers));
        }
    }
}
