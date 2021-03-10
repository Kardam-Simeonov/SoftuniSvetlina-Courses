using System;
using System.Linq;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join("", input.Where(x => Char.IsDigit(x))));
            Console.WriteLine(string.Join("", input.Where(x => Char.IsLetter(x))));
            Console.WriteLine(string.Join("", input.Where(x => !Char.IsLetterOrDigit(x))));
        }


    }
}
