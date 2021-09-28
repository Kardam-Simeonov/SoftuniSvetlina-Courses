using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


            int biggest = int.MinValue;
            string output = "";

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];
                    output += Convert.ToChar(biggest + '0');
                }
            }

            foreach(int i in numbers)
            {
                if 
            }

            char[] charArray = output.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(String.Join(" ", charArray));
        }
    }
}
