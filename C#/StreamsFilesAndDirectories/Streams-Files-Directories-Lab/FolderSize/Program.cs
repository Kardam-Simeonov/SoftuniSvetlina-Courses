using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputFilePath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputFilePath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;

            DirectoryInfo dir = new DirectoryInfo("TestFolder");
            FileInfo[] infos = dir.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fileInfo in infos)
                sum += fileInfo.Length;

            sum = sum / 1024 / 1024;

            File.WriteAllText("оutput.txt", sum.ToString());
        }
    }
}
