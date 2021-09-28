using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadAndCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> appearance = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (appearance.ContainsKey(letter))
                    appearance[letter] += 1;
                else
                    appearance.Add(letter, 1);
            }

            foreach (var el in appearance.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{el.Key}: {el.Value} time/s");
            }
        }
    }
}
