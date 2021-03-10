using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine()
                .ToCharArray()
                .ToList();

            List<int> numbers = new List<int>();
            List<int> text = new List<int>();

            for (int i = 0; input.Count; i++)
            {
                int currentDigit = 0;
                if (Int32.TryParse(input[i].ToString(), out currentDigit))
                {
                    numbers.Add(currentDigit);
                }
                else
                {
                    text.Add(input[i]);
                }
            }
            List<char> result = new List<char>();

            for (int i = 0; i < numbers.Count; i += 2)
            {
                result = text.Take(numbers[i]).ToList();
                int skip = numbers[i] + numbers[i + 1];
            }

            foreach(var el in result)
                Console.Write(el);
        }
    }
}
