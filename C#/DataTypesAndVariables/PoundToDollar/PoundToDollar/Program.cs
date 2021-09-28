using System;

namespace PoundToDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            int pound = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"{(pound * 1.31):f3}");
        }
    }
}
