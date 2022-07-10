using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ProcessLines(inputFilePath, outputFilePath);
        }
        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            int counter = 1;

            foreach (string line in lines)
            {
                Console.WriteLine($"Line {counter}: {line}({Regex.Matches(line, "[a-z]").Count})({Regex.Matches(line, "[-,.!?]").Count})");
                counter++;
            }
        }
    }
}
