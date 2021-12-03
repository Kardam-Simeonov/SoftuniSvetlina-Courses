using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            MyTuple<string, string, string> firstLine = new MyTuple<string, string, string>($"{input[0]} {input[1]}", input[2], input[3]);

            input = Console.ReadLine().Split();
            MyTuple<string, int, bool> secondLine = new MyTuple<string, int, bool>(input[0], int.Parse(input[1]), input[2] == "drunk");

            input = Console.ReadLine().Split();
            MyTuple<string, double, string> thirdLine = new MyTuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);

            Console.WriteLine($"{firstLine.ItemOne} -> {firstLine.ItemTwo} -> {firstLine.ItemThree}");
            Console.WriteLine($"{secondLine.ItemOne} -> {secondLine.ItemTwo} -> {secondLine.ItemThree}");
            Console.WriteLine($"{thirdLine.ItemOne} -> {thirdLine.ItemTwo} -> {thirdLine.ItemThree}");
        }
    }
}
