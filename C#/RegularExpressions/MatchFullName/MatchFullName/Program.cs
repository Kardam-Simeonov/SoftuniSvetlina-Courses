using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            Console.WriteLine(String.Join(Environment.NewLine, matchedNames));
        }
    }
}
