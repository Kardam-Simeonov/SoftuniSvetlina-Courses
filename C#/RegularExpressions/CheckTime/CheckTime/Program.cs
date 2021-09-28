using System;
using System.Text.RegularExpressions;

namespace CheckTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, @"(([0-1][1-9])|(2[0-3])):([0-5][0-9]):([0-5][0-9])"))
                Console.WriteLine("Time is Valid");
            else
                Console.WriteLine("Time is NOT Valid");
        }
    }
}
