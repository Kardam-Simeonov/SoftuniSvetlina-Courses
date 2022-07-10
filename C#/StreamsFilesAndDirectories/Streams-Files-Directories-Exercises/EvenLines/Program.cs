using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(inputFilePath))
            {
                string line = reader.ReadLine();
                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 == 0)
                        lines.Add(line);

                    counter++;
                    line = reader.ReadLine();
                }

                foreach (string item in lines)
                    Regex.Replace(item, "[-,.!?]", "@");

                lines.Reverse();
            }

            return String.Join("\n", lines);
        }
    }
}
