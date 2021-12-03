using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            MyTuple<string, string> firstLine = new MyTuple<string, string>($"{input[0]} {input[1]}", input[2]);

            input = Console.ReadLine().Split();
            MyTuple<string, int> secondLine = new MyTuple<string, int>(input[0], int.Parse(input[1]));

            input = Console.ReadLine().Split();
            MyTuple<int, double> thirdLine = new MyTuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine($"{firstLine.ItemOne} -> {firstLine.ItemTwo}");
            Console.WriteLine($"{secondLine.ItemOne} -> {secondLine.ItemTwo}");
            Console.WriteLine($"{thirdLine.ItemOne} -> {thirdLine.ItemTwo}");
        }
    }
}
