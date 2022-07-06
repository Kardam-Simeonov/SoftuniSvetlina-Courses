using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            string firstInputFilePath = @"..\..\..\Files\firstInput.txt";
            string secondInputFilePath = @"..\..\..\Files\secondInput.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string
        secondInputFilePath, string outputFilePath)
        {
            using (var firstInputReader = new StreamReader(firstInputFilePath))
            {
                string firstInputLine = firstInputReader.ReadLine();
                
                using (var secondInputReader = new StreamReader(secondInputFilePath))
                {
                    string secondInputLine = secondInputReader.ReadLine();

                    using (var writer = new StreamWriter(outputFilePath))
                    {
                        while (firstInputLine != null && secondInputLine != null)
                        {
                            if (firstInputLine != null)
                            {
                                writer.WriteLine(firstInputLine);
                                firstInputLine = firstInputReader.ReadLine();
                            }
                            if (secondInputLine != null)
                            {
                                writer.WriteLine(secondInputLine);
                                secondInputLine = secondInputReader.ReadLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
