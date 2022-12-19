using System;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                box.Add(int.Parse(Console.ReadLine()));

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int temp = box[input[0]];
            box[input[0]] = box[input[1]];
            box[input[1]] = temp;

            for (int i = 0; i < box.Count; i++)
                Console.WriteLine($"{box[i].GetType()}: {box[i]}");
        }
    }
}
