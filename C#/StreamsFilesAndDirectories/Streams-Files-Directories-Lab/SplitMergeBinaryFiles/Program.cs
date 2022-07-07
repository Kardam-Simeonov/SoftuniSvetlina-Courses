using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string partOneFilePath = @"..\..\..\Files\part-1.bin";
            string partTwoFilePath = @"..\..\..\Files\part-2.bin";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";

            SplitBinaryFile(sourceFilePath, partOneFilePath, partTwoFilePath);
            MergeBinaryFiles(partOneFilePath, partTwoFilePath, joinedFilePath);
        }
        public static void SplitBinaryFile(string sourceFilePath, string
        partOneFilePath, string partTwoFilePath)
        {
            byte[] sourceBytes = File.ReadAllBytes(sourceFilePath);
            byte[] partTwo, partOne;
            
            if (sourceBytes.Length % 2 == 0)
            {
                partOne = new byte[sourceBytes.Length / 2];
                partTwo = new byte[sourceBytes.Length / 2];
                Array.Copy(sourceBytes, 0, partOne, 0, sourceBytes.Length / 2 - 1);
                Array.Copy(sourceBytes, sourceBytes.Length / 2, partOne, 0, sourceBytes.Length / 2);
            }
            else
            {
                partOne = new byte[sourceBytes.Length / 2 + 1];
                partTwo = new byte[sourceBytes.Length / 2];
                Array.Copy(sourceBytes, 0, partOne, 0, sourceBytes.Length / 2 + 1);
                Array.Copy(sourceBytes, sourceBytes.Length / 2 + 2, partOne, 0, sourceBytes.Length / 2);
            }

            using (var partOneWriter = new FileStream(partOneFilePath, FileMode.OpenOrCreate))
            using (var partTwoWriter = new FileStream(partOneFilePath, FileMode.OpenOrCreate))
            {
                partOneWriter.Write(partOne);
                partTwoWriter.Write(partTwo);
            }
        }
        public static void MergeBinaryFiles(string partOneFilePath, string
        partTwoFilePath, string joinedFilePath)
        {
            using (var joinedFileWriter = new FileStream(joinedFilePath, FileMode.OpenOrCreate))
            {
                joinedFileWriter.Write(File.ReadAllBytes(partOneFilePath));
                joinedFileWriter.Write(File.ReadAllBytes(partTwoFilePath));
            }
        }
    }
}
