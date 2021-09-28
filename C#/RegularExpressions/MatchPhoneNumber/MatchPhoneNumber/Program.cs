using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matchedNumbers = Regex.Matches(input, @"\+359( |-)2\1\d{3}\1\d{4}");

            Console.WriteLine(String.Join(", ", matchedNumbers));

        }
    }
}
