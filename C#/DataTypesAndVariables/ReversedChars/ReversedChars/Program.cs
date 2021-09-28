using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            char charThree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{charThree} {charTwo} {charOne}");
        }
    }
}
