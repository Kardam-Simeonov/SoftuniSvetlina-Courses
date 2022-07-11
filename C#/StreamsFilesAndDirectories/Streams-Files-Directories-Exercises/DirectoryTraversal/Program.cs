using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string reportPath = @"..\..\..\Desktop";
            WriteReportToDesktop(TraverseDirectory(folderPath), reportPath);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo directory = new DirectoryInfo(inputFolderPath);
            FileInfo[] files = directory.GetFiles("*", SearchOption.TopDirectoryOnly);
            StringBuilder output = new StringBuilder();

            foreach (string extension in files.Select(x => x.Extension).Distinct())
            {
                output.AppendLine(extension);

                foreach (var file in files.Where(x => x.Extension == extension))
                    output.AppendLine($"--{file} - {file.Length / 1024}kb");
            }

            return output.ToString();
        }
        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            File.WriteAllText(reportFileName, textContent);
        }
    }
}
