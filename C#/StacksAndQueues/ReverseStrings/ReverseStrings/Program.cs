using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedString = new Stack<char>();

            foreach (char character in input)
                reversedString.Push(character);
            
            Console.WriteLine(String.Join("", reversedString));
        }
    }
}
