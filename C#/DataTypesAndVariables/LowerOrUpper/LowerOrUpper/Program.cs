using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());

            if (Convert.ToInt32(character) > 90)
                Console.WriteLine("lower-case");
            else
                Console.WriteLine("upper-case");
        }
    }
}
