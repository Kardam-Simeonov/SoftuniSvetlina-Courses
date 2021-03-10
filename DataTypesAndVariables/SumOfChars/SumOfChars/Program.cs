using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int charNum = int.Parse(Console.ReadLine());
            int charSum = 0;

            for (int i = 1; i <= charNum; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                charSum += Convert.ToInt32(currentChar);
            }

            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
