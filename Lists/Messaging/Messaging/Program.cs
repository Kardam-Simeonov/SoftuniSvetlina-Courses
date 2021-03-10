using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<char> text = Console.ReadLine()
                .ToCharArray()
                .ToList();

            string result = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                char[] currentDigits = currentNumber.ToString().ToCharArray();

                int sum = 0;
                for (int j = 0; j < currentDigits.Length; j++)
                {
                    sum += int.Parse(currentDigits[j].ToString());
                }

                int index = sum % text.Count;

                result += text[index];
                text.RemoveAt(index);
            }

            Console.WriteLine(result);
        }
    }
}
