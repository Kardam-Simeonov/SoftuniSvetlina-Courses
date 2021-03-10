using System;

namespace InLineIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = (n >= 0) ? "positive" : "negative";
            Console.WriteLine(result);
        }
    }
}
