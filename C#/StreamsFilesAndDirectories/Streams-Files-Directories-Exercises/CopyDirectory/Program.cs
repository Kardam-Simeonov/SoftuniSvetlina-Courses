using System;
using System.IO;

namespace CopyDirectory
{
    public class CopyDirectory
    {
        static void Main()
        {
            string inputFolderPath = Console.ReadLine();
            string outputFolderPath = Console.ReadLine();
            CopyAllFiles(inputFolderPath, outputFolderPath);
        }
        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            DirectoryInfo inputFolder = new DirectoryInfo(inputPath);
            DirectoryInfo outputFolder = new DirectoryInfo(outputPath);
            
            if (outputFolder.Exists)
                outputFolder.Delete(true);
            
            outputFolder.Create();

            foreach (var file in inputFolder.GetFiles())
                Directory.Move(file.FullName, outputPath);
        }
    }
}
