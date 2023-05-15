using System;

namespace ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> print = x => Console.WriteLine(x);

            foreach (string name in input)
            {
                print(name);
            }
        }
    }
}
