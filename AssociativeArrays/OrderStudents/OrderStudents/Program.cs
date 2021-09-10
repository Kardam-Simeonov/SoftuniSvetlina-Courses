using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrderStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> examinedStudents = Console.ReadLine().Split('|').ToList();

            examinedStudents.Reverse();

            Console.WriteLine(String.Join(" ", examinedStudents.Select(x => Regex.Replace(x, @"\s+", " ").Trim())));
        }
    }
}
