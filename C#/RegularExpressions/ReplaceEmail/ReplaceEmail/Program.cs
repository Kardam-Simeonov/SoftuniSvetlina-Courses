using System;
using System.Text.RegularExpressions;

namespace ReplaceEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex expression = new Regex(@"([a-zA-Z0-9_\-.]+)@([a-zA-Z0-9_]+)\.([a-zA-Z]{2,3})");

            Console.WriteLine(expression.Replace(input, "xxxxxxxxxx"));
        }
    }
}
