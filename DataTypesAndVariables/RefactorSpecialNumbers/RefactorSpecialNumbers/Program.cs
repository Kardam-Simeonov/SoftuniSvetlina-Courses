using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
         
            for (int i = 1; i <= n; i++)
            {
                int digitSum = 0;
                int num = i;
               
                while (i > 0)
                {
                    digitSum += i % 10;
                    i = i / 10;
                }
                bool isSpecial = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecial);

                digitSum = 0;
                i = num;
            }

        }
    }
}
