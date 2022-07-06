using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                int counter = 1;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter(outputFilePath))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
